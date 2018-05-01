using SEBWarmup.Model;
using SEBWarmup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SEBWarmup.WCF_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MyService : IMyService
    {

        private ApplicationDbContext _context;

        public MyService()
        {
            _context = new ApplicationDbContext();
        }

        public string GetData(int value)
        {

            var obj = _context.SEBTest.Where(c=>c.name=="Test");


            return "wtf?!2";

           // return obj.ToString();

            //return $"the value THAT U ARE LOOKING  is {value}";
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "SuffixS";
            }
            return composite;
        }





    }
}
