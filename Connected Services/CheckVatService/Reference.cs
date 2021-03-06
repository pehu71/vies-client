﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ViesClient.CheckVatService {
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="matchCode", Namespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types")]
    public enum matchCode : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute(Value="1")]
        _1 = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute(Value="2")]
        _2 = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute(Value="3")]
        _3 = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:ec.europa.eu:taxud:vies:services:checkVat", ConfigurationName="CheckVatService.checkVatPortType")]
    public interface checkVatPortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        ViesClient.CheckVatService.checkVatResponse checkVat(ViesClient.CheckVatService.checkVatRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ViesClient.CheckVatService.checkVatResponse> checkVatAsync(ViesClient.CheckVatService.checkVatRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        ViesClient.CheckVatService.checkVatApproxResponse checkVatApprox(ViesClient.CheckVatService.checkVatApproxRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ViesClient.CheckVatService.checkVatApproxResponse> checkVatApproxAsync(ViesClient.CheckVatService.checkVatApproxRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class checkVatRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="checkVat", Namespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types", Order=0)]
        public ViesClient.CheckVatService.checkVatRequestBody Body;
        
        public checkVatRequest() {
        }
        
        public checkVatRequest(ViesClient.CheckVatService.checkVatRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types")]
    public partial class checkVatRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string countryCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string vatNumber;
        
        public checkVatRequestBody() {
        }
        
        public checkVatRequestBody(string countryCode, string vatNumber) {
            this.countryCode = countryCode;
            this.vatNumber = vatNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class checkVatResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="checkVatResponse", Namespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types", Order=0)]
        public ViesClient.CheckVatService.checkVatResponseBody Body;
        
        public checkVatResponse() {
        }
        
        public checkVatResponse(ViesClient.CheckVatService.checkVatResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types")]
    public partial class checkVatResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string countryCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string vatNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string requestDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public bool valid;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string name;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public string address;
        
        public checkVatResponseBody() {
        }
        
        public checkVatResponseBody(string countryCode, string vatNumber, string requestDate, bool valid, string name, string address) {
            this.countryCode = countryCode;
            this.vatNumber = vatNumber;
            this.requestDate = requestDate;
            this.valid = valid;
            this.name = name;
            this.address = address;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class checkVatApproxRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="checkVatApprox", Namespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types", Order=0)]
        public ViesClient.CheckVatService.checkVatApproxRequestBody Body;
        
        public checkVatApproxRequest() {
        }
        
        public checkVatApproxRequest(ViesClient.CheckVatService.checkVatApproxRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types")]
    public partial class checkVatApproxRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string countryCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string vatNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string traderName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string traderCompanyType;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string traderStreet;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string traderPostcode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string traderCity;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string requesterCountryCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string requesterVatNumber;
        
        public checkVatApproxRequestBody() {
        }
        
        public checkVatApproxRequestBody(string countryCode, string vatNumber, string traderName, string traderCompanyType, string traderStreet, string traderPostcode, string traderCity, string requesterCountryCode, string requesterVatNumber) {
            this.countryCode = countryCode;
            this.vatNumber = vatNumber;
            this.traderName = traderName;
            this.traderCompanyType = traderCompanyType;
            this.traderStreet = traderStreet;
            this.traderPostcode = traderPostcode;
            this.traderCity = traderCity;
            this.requesterCountryCode = requesterCountryCode;
            this.requesterVatNumber = requesterVatNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class checkVatApproxResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="checkVatApproxResponse", Namespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types", Order=0)]
        public ViesClient.CheckVatService.checkVatApproxResponseBody Body;
        
        public checkVatApproxResponse() {
        }
        
        public checkVatApproxResponse(ViesClient.CheckVatService.checkVatApproxResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:ec.europa.eu:taxud:vies:services:checkVat:types")]
    public partial class checkVatApproxResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string countryCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string vatNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string requestDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public bool valid;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string traderName;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public string traderCompanyType;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string traderAddress;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string traderStreet;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string traderPostcode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string traderCity;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=10)]
        public ViesClient.CheckVatService.matchCode traderNameMatch;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=11)]
        public ViesClient.CheckVatService.matchCode traderCompanyTypeMatch;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=12)]
        public ViesClient.CheckVatService.matchCode traderStreetMatch;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=13)]
        public ViesClient.CheckVatService.matchCode traderPostcodeMatch;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=14)]
        public ViesClient.CheckVatService.matchCode traderCityMatch;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=15)]
        public string requestIdentifier;
        
        public checkVatApproxResponseBody() {
        }
        
        public checkVatApproxResponseBody(
                    string countryCode, 
                    string vatNumber, 
                    string requestDate, 
                    bool valid, 
                    string traderName, 
                    string traderCompanyType, 
                    string traderAddress, 
                    string traderStreet, 
                    string traderPostcode, 
                    string traderCity, 
                    ViesClient.CheckVatService.matchCode traderNameMatch, 
                    ViesClient.CheckVatService.matchCode traderCompanyTypeMatch, 
                    ViesClient.CheckVatService.matchCode traderStreetMatch, 
                    ViesClient.CheckVatService.matchCode traderPostcodeMatch, 
                    ViesClient.CheckVatService.matchCode traderCityMatch, 
                    string requestIdentifier) {
            this.countryCode = countryCode;
            this.vatNumber = vatNumber;
            this.requestDate = requestDate;
            this.valid = valid;
            this.traderName = traderName;
            this.traderCompanyType = traderCompanyType;
            this.traderAddress = traderAddress;
            this.traderStreet = traderStreet;
            this.traderPostcode = traderPostcode;
            this.traderCity = traderCity;
            this.traderNameMatch = traderNameMatch;
            this.traderCompanyTypeMatch = traderCompanyTypeMatch;
            this.traderStreetMatch = traderStreetMatch;
            this.traderPostcodeMatch = traderPostcodeMatch;
            this.traderCityMatch = traderCityMatch;
            this.requestIdentifier = requestIdentifier;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface checkVatPortTypeChannel : ViesClient.CheckVatService.checkVatPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class checkVatPortTypeClient : System.ServiceModel.ClientBase<ViesClient.CheckVatService.checkVatPortType>, ViesClient.CheckVatService.checkVatPortType {
        
        public checkVatPortTypeClient() {
        }
        
        public checkVatPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public checkVatPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public checkVatPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public checkVatPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ViesClient.CheckVatService.checkVatResponse checkVat(ViesClient.CheckVatService.checkVatRequest request) {
            return base.Channel.checkVat(request);
        }
        
        public System.Threading.Tasks.Task<ViesClient.CheckVatService.checkVatResponse> checkVatAsync(ViesClient.CheckVatService.checkVatRequest request) {
            return base.Channel.checkVatAsync(request);
        }
        
        public ViesClient.CheckVatService.checkVatApproxResponse checkVatApprox(ViesClient.CheckVatService.checkVatApproxRequest request) {
            return base.Channel.checkVatApprox(request);
        }
        
        public System.Threading.Tasks.Task<ViesClient.CheckVatService.checkVatApproxResponse> checkVatApproxAsync(ViesClient.CheckVatService.checkVatApproxRequest request) {
            return base.Channel.checkVatApproxAsync(request);
        }
    }
}
