﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://microsoft.wcf.documentation", ConfigurationName="SampleService")]
public interface SampleService
{

    [System.ServiceModel.OperationContractAttribute(Action="http://microsoft.wcf.documentation/SampleService/SampleMethod", ReplyAction="http://microsoft.wcf.documentation/SampleService/SampleMethodResponse")]
    string SampleMethod(string msg);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface SampleServiceChannel : SampleService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class SampleServiceClient : System.ServiceModel.ClientBase<SampleService>, SampleService
{

    public SampleServiceClient()
    {
    }

    public SampleServiceClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
    {
    }

    public SampleServiceClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public SampleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public SampleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
    {
    }

    public string SampleMethod(string msg)
    {
        return base.Channel.SampleMethod(msg);
    }
}
