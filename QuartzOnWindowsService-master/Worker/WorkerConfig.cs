﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    /// <summary>
    /// Config parameters for job initialize
    /// </summary>
    public class WorkerConfig
    {
        public bool RunImmediately { get; set; }
        public string DataValue { get; set; }
        public string TimeExecute { get; set; }
    }
}
