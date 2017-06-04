﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISHaU.Library.File.Model
{
    public class RangeModel
    {
        public long? From { get; set; }
        public long? To { get; set; }
    }

    public class DownloadFileInfo
    {
        public ResultModel FileInfo { get; set; }
        public IList<DownPartInfoModel> Parts { get; set; }
    }


}
