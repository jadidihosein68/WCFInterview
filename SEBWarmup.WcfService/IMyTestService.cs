using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SEBWarmup.WcfService
{
    [ServiceContract] // Indicates that an interface or a class defines a service contract in a Windows Communication Foundation (WCF) application.
    public interface IMyTestService
    {
        [OperationContract]//In a service contract interface, only methods decorated with [OperationContract] are exposed to the client
        string getData();



        [OperationContract]//In a service contract interface, only methods decorated with [OperationContract] are exposed to the client
        string getMessage( string name);



    }
}
