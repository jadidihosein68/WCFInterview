using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SEBWarmup.WcfService
{
    class MyTestSetrvice : IMyTestService
    {
        public string getData()
        {
            return "Test Sccessflly done!";
        }



        public string getMessage(string name)
        {
            return $"Hello {name}";
        }
    }
}
