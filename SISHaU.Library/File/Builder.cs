﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SISHaU.Library.File.Enginer;
using SISHaU.Library.File.Model;
using System.Threading;

namespace SISHaU.Library.File
{
    public interface IBuilder
    {
        IList<UploadeResultModel> UploadFilesList(IList<string> patch, Repo repository);
        UploadeResultModel UploadFiles(string patch, Repo repository);
        IList<DownloadResultModel> DownloadFilesList(IList<DownloadModel> model);
        DownloadResultModel DownloadFiles(DownloadModel model);
    }

    public class Builder : IDisposable, IBuilder
    {
        private static OperationFile Operation => new OperationFile();

        public IList<UploadeResultModel> UploadFilesList(IList<string> patch, Repo repository)
        {
            if (patch==null || !patch.Any()) throw new Exception($"Параметр {patch} не должен быть пустым"); 

            var result = new ConcurrentBag<UploadeResultModel>();

            var upFile = new ConcurrentBag<SplitFileModel>();

            var fpatch = new ConcurrentBag<string>(patch);
            var tempPatch = Config.TempPath(Config.TempType.Up);

            Parallel.ForEach(fpatch, (file, state) =>
            {
                if (!System.IO.File.Exists(file))
                {
                    result.Add(new UploadeResultModel
                    {
                        ErrorMessage = new RequestErrorModel
                        {
                            ErrorCode = 404,
                            ErrorInfo = $"По указанному пути {{{file}}} файл не был обнаружен.",
                            PointErrorDescript = $"Предупреждение произошло в {{{nameof(UploadFilesList)}}}."
                        }
                    });
                    return;
                }

                upFile.Add(Operation.SplitFile(file, tempPatch));
            });

            var ctsUp = new CancellationTokenSource();
            var poUp = new ParallelOptions {
                CancellationToken = ctsUp.Token
            };

            Parallel.ForEach(upFile, poUp, (cupFile, state) =>
             {
                 var upl = new EnginerFileRun(repository);
                 var res = upl.UploadFile(cupFile, ref poUp);
                 upl.Dispose();
                 result.Add(res);
             });

            ctsUp.Dispose();

            return result.ToList();
        }

        public UploadeResultModel UploadFiles(string patch, Repo repository)
        {
            var result = UploadFilesList( new []{ patch } , repository).SingleOrDefault();
            return result;
        }


        public IList<DownloadResultModel> DownloadFilesList(IList<DownloadModel> model)
        {
            if (model == null || !model.Any()) throw new Exception($"Параметр {{{nameof(model)}}} не должен быть пустым");

            var collect = new ConcurrentBag<DownloadModel>(model);
            var result = new List<DownloadResultModel>();

            //foreach(var download in collect)
            Parallel.ForEach(collect, (download, state) =>
            {
                result.Add(DownloadFiles(download));
                //Thread.Sleep(5000);
            });

            return result;
        }

        public DownloadResultModel DownloadFiles(DownloadModel model)
        {
            
            var bild = new EnginerFileRun(model.Repository);

            var file = bild.DownloadFile(model.FileGuid);

            bild.Dispose();

            var result=new DownloadResultModel
            {
                ErrorMessage = file.ErrorMessage,
                FileBytes = Operation.CollectFile(file.Parts),
                FileName = file.FileInfo.FileName,
                FileSize = file.FileInfo.FileSize
            };

            return result;
        }

        private void Dispose(bool disposing)
        {
            if (!disposing) return;
            Operation.Dispose();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~Builder()
        {
            Dispose(false);
        }
    }
}
