﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hangfire.HttpAgent.Owin.Config
{
    internal class JobMetaData
    {
        public bool Transien { get; set; }
        public bool Hang { get; set; }
    }
}
