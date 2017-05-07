﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISHaU.Library.File.Model
{
    public class UploadeResultModel : ResultModel
    {
        public string GostHash { get; set; }

        public string FileGuid { get; set; }

        public DateTime UTime { get; set; }

        public RequestErrorModel ErrorMessage { get; set; }


    }
}
