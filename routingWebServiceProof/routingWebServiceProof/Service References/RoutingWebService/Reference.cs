﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace routingWebServiceProof.RoutingWebService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RequestBase", Namespace="http://schemas.datacontract.org/2004/07/RoutingWebService")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(routingWebServiceProof.RoutingWebService.RouteRequest))]
    public partial class RequestBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IntegrationIdField;
        
        private string PasswordField;
        
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int IntegrationId {
            get {
                return this.IntegrationIdField;
            }
            set {
                if ((this.IntegrationIdField.Equals(value) != true)) {
                    this.IntegrationIdField = value;
                    this.RaisePropertyChanged("IntegrationId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RouteRequest", Namespace="http://schemas.datacontract.org/2004/07/RoutingWebService")]
    [System.SerializableAttribute()]
    public partial class RouteRequest : routingWebServiceProof.RoutingWebService.RequestBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private routingWebServiceProof.RoutingWebService.RouteLocation[] LocationsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double MilesPerGallonField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public routingWebServiceProof.RoutingWebService.RouteLocation[] Locations {
            get {
                return this.LocationsField;
            }
            set {
                if ((object.ReferenceEquals(this.LocationsField, value) != true)) {
                    this.LocationsField = value;
                    this.RaisePropertyChanged("Locations");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double MilesPerGallon {
            get {
                return this.MilesPerGallonField;
            }
            set {
                if ((this.MilesPerGallonField.Equals(value) != true)) {
                    this.MilesPerGallonField = value;
                    this.RaisePropertyChanged("MilesPerGallon");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RouteLocation", Namespace="http://schemas.datacontract.org/2004/07/RoutingWebService")]
    [System.SerializableAttribute()]
    public partial class RouteLocation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string CityField;
        
        private string StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ZipField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Zip {
            get {
                return this.ZipField;
            }
            set {
                if ((object.ReferenceEquals(this.ZipField, value) != true)) {
                    this.ZipField = value;
                    this.RaisePropertyChanged("Zip");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReturnBase", Namespace="http://schemas.datacontract.org/2004/07/RoutingWebService")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(routingWebServiceProof.RoutingWebService.RouteReturn))]
    public partial class ReturnBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private routingWebServiceProof.RoutingWebService.Error[] ErrorsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public routingWebServiceProof.RoutingWebService.Error[] Errors {
            get {
                return this.ErrorsField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorsField, value) != true)) {
                    this.ErrorsField = value;
                    this.RaisePropertyChanged("Errors");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RouteReturn", Namespace="http://schemas.datacontract.org/2004/07/RoutingWebService")]
    [System.SerializableAttribute()]
    public partial class RouteReturn : routingWebServiceProof.RoutingWebService.ReturnBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double AverageFuelPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double CostPerMileField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double EstimatedFuelCostField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private routingWebServiceProof.RoutingWebService.Fuelstop[] FuelStopsOnRouteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double MilesOnRouteField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double AverageFuelPrice {
            get {
                return this.AverageFuelPriceField;
            }
            set {
                if ((this.AverageFuelPriceField.Equals(value) != true)) {
                    this.AverageFuelPriceField = value;
                    this.RaisePropertyChanged("AverageFuelPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double CostPerMile {
            get {
                return this.CostPerMileField;
            }
            set {
                if ((this.CostPerMileField.Equals(value) != true)) {
                    this.CostPerMileField = value;
                    this.RaisePropertyChanged("CostPerMile");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double EstimatedFuelCost {
            get {
                return this.EstimatedFuelCostField;
            }
            set {
                if ((this.EstimatedFuelCostField.Equals(value) != true)) {
                    this.EstimatedFuelCostField = value;
                    this.RaisePropertyChanged("EstimatedFuelCost");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public routingWebServiceProof.RoutingWebService.Fuelstop[] FuelStopsOnRoute {
            get {
                return this.FuelStopsOnRouteField;
            }
            set {
                if ((object.ReferenceEquals(this.FuelStopsOnRouteField, value) != true)) {
                    this.FuelStopsOnRouteField = value;
                    this.RaisePropertyChanged("FuelStopsOnRoute");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double MilesOnRoute {
            get {
                return this.MilesOnRouteField;
            }
            set {
                if ((this.MilesOnRouteField.Equals(value) != true)) {
                    this.MilesOnRouteField = value;
                    this.RaisePropertyChanged("MilesOnRoute");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Error", Namespace="http://schemas.datacontract.org/2004/07/Truckstop2.Objects")]
    [System.SerializableAttribute()]
    public partial class Error : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] SuggestionsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Suggestions {
            get {
                return this.SuggestionsField;
            }
            set {
                if ((object.ReferenceEquals(this.SuggestionsField, value) != true)) {
                    this.SuggestionsField = value;
                    this.RaisePropertyChanged("Suggestions");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Fuelstop", Namespace="http://schemas.datacontract.org/2004/07/Truckstop2.Objects.GeoObjects")]
    [System.SerializableAttribute()]
    public partial class Fuelstop : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ChainField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExitLocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Chain {
            get {
                return this.ChainField;
            }
            set {
                if ((object.ReferenceEquals(this.ChainField, value) != true)) {
                    this.ChainField = value;
                    this.RaisePropertyChanged("Chain");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ExitLocation {
            get {
                return this.ExitLocationField;
            }
            set {
                if ((object.ReferenceEquals(this.ExitLocationField, value) != true)) {
                    this.ExitLocationField = value;
                    this.RaisePropertyChanged("ExitLocation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RoutingWebService.IRoutingService")]
    public interface IRoutingService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoutingService/GetRoute", ReplyAction="http://tempuri.org/IRoutingService/GetRouteResponse")]
        routingWebServiceProof.RoutingWebService.RouteReturn GetRoute(routingWebServiceProof.RoutingWebService.RouteRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRoutingServiceChannel : routingWebServiceProof.RoutingWebService.IRoutingService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RoutingServiceClient : System.ServiceModel.ClientBase<routingWebServiceProof.RoutingWebService.IRoutingService>, routingWebServiceProof.RoutingWebService.IRoutingService {
        
        public RoutingServiceClient() {
        }
        
        public RoutingServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RoutingServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RoutingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RoutingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public routingWebServiceProof.RoutingWebService.RouteReturn GetRoute(routingWebServiceProof.RoutingWebService.RouteRequest request) {
            return base.Channel.GetRoute(request);
        }
    }
}
