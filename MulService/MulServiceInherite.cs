﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MulServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MulServiceInherite : IMulServiceInherite
    {
        public int div(int a, int b)
        {
            return a / b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }

        public double MulDouble(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
