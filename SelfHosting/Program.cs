using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MulServiceLibrary;
using System.ServiceModel;
using System.ServiceModel.Description; // for the service meta data behavior

namespace SelfHosting
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
            //  for single bidning 
            Uri TCPbaseAddress = new Uri("net.tcp://localhost:9998"); // create base address 
            ServiceHost sh = new ServiceHost(typeof(MulService), HTTPbaseAddress); // service object  for single bidning 
            ServiceEndpoint se = sh.AddServiceEndpoint(typeof(IMulService), new WSHttpBinding(), baseAddress);
            
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            sh.Description.Behaviors.Add(smb); // add behaviod to the sh
            sh.Open();
              Console.WriteLine("started ...");
            Console.WriteLine(se.Address);
            Console.WriteLine(se.Binding.Name);
            Console.WriteLine(se.Contract.ContractType);
            Console.ReadLine();
            sh.Close();
             */


            // for multiple binding 
            Uri TCPbaseAddress = new Uri("net.tcp://localhost:9998"); // create base address 
            Uri HTTPbaseAddress = new Uri("http://localhost:9999"); // create base address 
            ServiceHost sh = new ServiceHost(typeof(MulService), new Uri[] { TCPbaseAddress, HTTPbaseAddress }); // service object 

            ServiceEndpoint TCPServiceEndpoint = sh.AddServiceEndpoint(typeof(IMulService), new NetTcpBinding(), TCPbaseAddress);
            ServiceEndpoint HTTPServiceEndpoint = sh.AddServiceEndpoint(typeof(IMulService), new BasicHttpBinding(), HTTPbaseAddress);



            //ServiceEndpoint se = sh.AddServiceEndpoint(typeof(IMulService), new WSHttpBinding(),baseAddress);
            // (contract, binding, Address )
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            sh.Description.Behaviors.Add(smb); // add behaviod to the sh
            sh.Open();
            foreach (var item in sh.Description.Endpoints)
            {
                Console.WriteLine($"Address : {item.Address.ToString()}");
                Console.WriteLine($"Binding : {item.Binding.Name.ToString()}");
                Console.WriteLine($"Contract : {item.Contract.ContractType.ToString()}");

            }

            Console.ReadLine();
            sh.Close();
        }
    }
}
