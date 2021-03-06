﻿using System;
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

        public static void multiple()
        {

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
            getresult(sh);
            sh.Close();

        }



        public static void multipleModified()
        {

            // for multiple binding 
            Uri TCPbaseAddress = new Uri("net.tcp://localhost:9998"); // create base address 
            Uri HTTPbaseAddress = new Uri("http://localhost:9999"); // create base address 
            ServiceHost sh = new ServiceHost(typeof(MulService), new Uri[] { TCPbaseAddress, HTTPbaseAddress }); // service object 

            ServiceEndpoint TCPServiceEndpoint = sh.AddServiceEndpoint(typeof(IMulService), new NetTcpBinding(), TCPbaseAddress);

            var basicHttpbinding = new BasicHttpBinding();
            basicHttpbinding.CloseTimeout = new TimeSpan(0,10,30);

                        ServiceEndpoint HTTPServiceEndpoint = sh.AddServiceEndpoint(typeof(IMulService), basicHttpbinding, HTTPbaseAddress);



            //ServiceEndpoint se = sh.AddServiceEndpoint(typeof(IMulService), new WSHttpBinding(),baseAddress);
            // (contract, binding, Address )
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            sh.Description.Behaviors.Add(smb); // add behaviod to the sh
            sh.Open();
            getresult(sh);
            sh.Close();

        }



        public static void multipleMEx()
        {

            // for multiple binding 
            Uri TCPbaseAddress = new Uri("net.tcp://localhost:9998"); // create base address 
            Uri HTTPbaseAddress = new Uri("http://localhost:9999/httpendpoint"); // create base address 
            ServiceHost sh = new ServiceHost(typeof(MulService), new Uri[] { TCPbaseAddress, HTTPbaseAddress }); // service object 

            ServiceEndpoint TCPServiceEndpoint = sh.AddServiceEndpoint(typeof(IMulService), new NetTcpBinding(), TCPbaseAddress);
            ServiceEndpoint HTTPServiceEndpoint = sh.AddServiceEndpoint(typeof(IMulService), new BasicHttpBinding(), HTTPbaseAddress);



            //ServiceEndpoint se = sh.AddServiceEndpoint(typeof(IMulService), new WSHttpBinding(),baseAddress);
            // (contract, binding, Address )
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = false;
            sh.Description.Behaviors.Add(smb); // add behaviod to the sh

            ServiceEndpoint httpmex = sh.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "http://localhost:9999/mex");


            sh.Open();
            getresult(sh);
            sh.Close();

        }


        public static void single (){
            Uri TCPbaseAddress = new Uri("net.tcp://localhost:9998"); // create base address 
            ServiceHost sh = new ServiceHost(typeof(MulService), TCPbaseAddress); // service object  for single bidning 
            ServiceEndpoint se = sh.AddServiceEndpoint(typeof(IMulService), new WSHttpBinding(), TCPbaseAddress);
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            sh.Description.Behaviors.Add(smb); // add behaviod to the sh
            sh.Open();
            getresult(sh);
            sh.Close();
        }





        public static void getresult(ServiceHost sh)
        {

            foreach (var item in sh.Description.Endpoints)
            {
                Console.WriteLine("started ///////////////////////////");
                Console.WriteLine($"Address : {item.Address.ToString()}");
                Console.WriteLine($"Binding : {item.Binding.Name.ToString()}");
                Console.WriteLine($"Contract : {item.Contract.ContractType.ToString()}");
                Console.WriteLine($"close time out : {item.Binding.CloseTimeout}");

            }
            Console.ReadLine();

        }


        static void Main(string[] args)
        {

            //single();
            //  multiple();
            multipleMEx();
            // multipleModified();


        }
    }
}
