﻿using System;

namespace SISHaU.Library.File.Model
{
    public class UploadeResultModel : ResultModel
    {
        public Repo Repository { get; set; }

        public string GostHash { get; set; }

        public string FileGuid { get; set; }

        public DateTime UTime { get; set; }

        public RequestErrorModel ErrorMessage { get; set; }


    }
}
