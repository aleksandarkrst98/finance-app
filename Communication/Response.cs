﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication
{
    [Serializable]
    public class Response
    {
        public bool isSuccessful { get; set; }
        public object Result { get; set; }
        public String Error { get; set; }
    }
}
