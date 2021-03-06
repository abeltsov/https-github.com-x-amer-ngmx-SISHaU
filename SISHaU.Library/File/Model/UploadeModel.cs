﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISHaU.Library.File.Model
{
    public class UploadeModel
    {
        public ResultModel FileInfo { get; set; }

        public IList<ExplodUnitModel> Parts { get; set;  }

        public string GostHash { get; set; }

        public RequestErrorModel ErrorMessage { get; set; }
    }
}
