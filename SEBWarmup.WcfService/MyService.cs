﻿using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEBWarmup.WcfService
{
    class MyService : IMyTestService
    {
        public string getdata()
        {
            return "My WCF !";
        }

    }
}
