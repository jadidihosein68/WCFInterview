﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SEBWarmup.MulServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MulServiceReference.IMulService")]
    public interface IMulService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMulService/Mul", ReplyAction="http://tempuri.org/IMulService/MulResponse")]
        int Mul(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMulService/Mul", ReplyAction="http://tempuri.org/IMulService/MulResponse")]
        System.Threading.Tasks.Task<int> MulAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMulServiceChannel : SEBWarmup.MulServiceReference.IMulService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MulServiceClient : System.ServiceModel.ClientBase<SEBWarmup.MulServiceReference.IMulService>, SEBWarmup.MulServiceReference.IMulService {
        
        public MulServiceClient() {
        }
        
        public MulServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MulServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MulServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MulServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Mul(int a, int b) {
            return base.Channel.Mul(a, b);
        }
        
        public System.Threading.Tasks.Task<int> MulAsync(int a, int b) {
            return base.Channel.MulAsync(a, b);
        }
    }
}
