﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.ServiceReference3 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference3.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMicrosoftData", ReplyAction="http://tempuri.org/IService1/GetMicrosoftDataResponse")]
        string GetMicrosoftData(string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMicrosoftData", ReplyAction="http://tempuri.org/IService1/GetMicrosoftDataResponse")]
        System.Threading.Tasks.Task<string> GetMicrosoftDataAsync(string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAppleData", ReplyAction="http://tempuri.org/IService1/GetAppleDataResponse")]
        string GetAppleData(string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAppleData", ReplyAction="http://tempuri.org/IService1/GetAppleDataResponse")]
        System.Threading.Tasks.Task<string> GetAppleDataAsync(string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetIntelData", ReplyAction="http://tempuri.org/IService1/GetIntelDataResponse")]
        string GetIntelData(string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetIntelData", ReplyAction="http://tempuri.org/IService1/GetIntelDataResponse")]
        System.Threading.Tasks.Task<string> GetIntelDataAsync(string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetYahooData", ReplyAction="http://tempuri.org/IService1/GetYahooDataResponse")]
        string GetYahooData(string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetYahooData", ReplyAction="http://tempuri.org/IService1/GetYahooDataResponse")]
        System.Threading.Tasks.Task<string> GetYahooDataAsync(string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEbayData", ReplyAction="http://tempuri.org/IService1/GetEbayDataResponse")]
        string GetEbayData(string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEbayData", ReplyAction="http://tempuri.org/IService1/GetEbayDataResponse")]
        System.Threading.Tasks.Task<string> GetEbayDataAsync(string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetNetflixData", ReplyAction="http://tempuri.org/IService1/GetNetflixDataResponse")]
        string GetNetflixData(string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetNetflixData", ReplyAction="http://tempuri.org/IService1/GetNetflixDataResponse")]
        System.Threading.Tasks.Task<string> GetNetflixDataAsync(string date);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebApplication1.ServiceReference3.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebApplication1.ServiceReference3.IService1>, WebApplication1.ServiceReference3.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetMicrosoftData(string date) {
            return base.Channel.GetMicrosoftData(date);
        }
        
        public System.Threading.Tasks.Task<string> GetMicrosoftDataAsync(string date) {
            return base.Channel.GetMicrosoftDataAsync(date);
        }
        
        public string GetAppleData(string date) {
            return base.Channel.GetAppleData(date);
        }
        
        public System.Threading.Tasks.Task<string> GetAppleDataAsync(string date) {
            return base.Channel.GetAppleDataAsync(date);
        }
        
        public string GetIntelData(string date) {
            return base.Channel.GetIntelData(date);
        }
        
        public System.Threading.Tasks.Task<string> GetIntelDataAsync(string date) {
            return base.Channel.GetIntelDataAsync(date);
        }
        
        public string GetYahooData(string date) {
            return base.Channel.GetYahooData(date);
        }
        
        public System.Threading.Tasks.Task<string> GetYahooDataAsync(string date) {
            return base.Channel.GetYahooDataAsync(date);
        }
        
        public string GetEbayData(string date) {
            return base.Channel.GetEbayData(date);
        }
        
        public System.Threading.Tasks.Task<string> GetEbayDataAsync(string date) {
            return base.Channel.GetEbayDataAsync(date);
        }
        
        public string GetNetflixData(string date) {
            return base.Channel.GetNetflixData(date);
        }
        
        public System.Threading.Tasks.Task<string> GetNetflixDataAsync(string date) {
            return base.Channel.GetNetflixDataAsync(date);
        }
    }
}
