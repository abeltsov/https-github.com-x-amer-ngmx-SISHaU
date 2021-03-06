﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISHaU.Library.File.Model
{
    public class ResponseModel
    {
        public DateTimeOffset? ResultDate { get; set; }//
        public XErrorContext? ServerError { get; set; }//
    }

    public class ResponseIdModel : ResponseModel
    {
        public string UploadId { get; set; } //  X-Upload-UploadID:<uploadID>, 
    }

    public class ResponseSessionCloseModel : ResponseModel
    {
        public bool? IsClose { get; set; } //Connection: close
    }

    public class ResponseInfoModel : ResponseModel
    {
        public string FileName { get; set; } //X-Upload-Filename: filename
        public long FileSize{ get; set; } //X-Upload-Length: length
        public int[] FileCompleateParts { get; set; } //X-Upload-Completed-Parts: list of patrs
        public bool? IsCompleate { get; set; } //X-Upload-Completed: flag
    }

    public class ResponseDownloadModel : ResponseModel
    {
        public DateTimeOffset? FileLastModification { get; set; }
        //public long RFileLength { get; set; }
        public string FileType { get; set; }
        public byte[] RFileBytes { get; set; }
    }


}
