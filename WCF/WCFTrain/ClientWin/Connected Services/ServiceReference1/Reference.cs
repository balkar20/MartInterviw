﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientWin.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IGeeter")]
    public interface IGeeter {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeeter/Greet", ReplyAction="http://tempuri.org/IGeeter/GreetResponse")]
        string Greet(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGeeter/Greet", ReplyAction="http://tempuri.org/IGeeter/GreetResponse")]
        System.Threading.Tasks.Task<string> GreetAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGeeterChannel : ClientWin.ServiceReference1.IGeeter, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GeeterClient : System.ServiceModel.ClientBase<ClientWin.ServiceReference1.IGeeter>, ClientWin.ServiceReference1.IGeeter {
        
        public GeeterClient() {
        }
        
        public GeeterClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GeeterClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GeeterClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GeeterClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Greet(string name) {
            return base.Channel.Greet(name);
        }
        
        public System.Threading.Tasks.Task<string> GreetAsync(string name) {
            return base.Channel.GreetAsync(name);
        }
    }
}