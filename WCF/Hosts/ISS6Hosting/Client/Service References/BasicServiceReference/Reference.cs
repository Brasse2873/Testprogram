﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.BasicServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BasicServiceReference.IBasicService")]
    public interface IBasicService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasicService/Method1", ReplyAction="http://tempuri.org/IBasicService/Method1Response")]
        int Method1(int arg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasicService/Method1", ReplyAction="http://tempuri.org/IBasicService/Method1Response")]
        System.Threading.Tasks.Task<int> Method1Async(int arg);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBasicServiceChannel : Client.BasicServiceReference.IBasicService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BasicServiceClient : System.ServiceModel.ClientBase<Client.BasicServiceReference.IBasicService>, Client.BasicServiceReference.IBasicService {
        
        public BasicServiceClient() {
        }
        
        public BasicServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BasicServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BasicServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BasicServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Method1(int arg) {
            return base.Channel.Method1(arg);
        }
        
        public System.Threading.Tasks.Task<int> Method1Async(int arg) {
            return base.Channel.Method1Async(arg);
        }
    }
}
