﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SupervivientesNet.Presentation.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/Supervivientes.Services")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AuthenticatedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public bool Authenticated {
            get {
                return this.AuthenticatedField;
            }
            set {
                if ((this.AuthenticatedField.Equals(value) != true)) {
                    this.AuthenticatedField = value;
                    this.RaisePropertyChanged("Authenticated");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IUsers")]
    public interface IUsers {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsers/Authenticate", ReplyAction="http://tempuri.org/IUsers/AuthenticateResponse")]
        SupervivientesNet.Presentation.ServiceReference.CompositeType Authenticate(string user, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsers/Authenticate", ReplyAction="http://tempuri.org/IUsers/AuthenticateResponse")]
        System.Threading.Tasks.Task<SupervivientesNet.Presentation.ServiceReference.CompositeType> AuthenticateAsync(string user, string pass);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUsersChannel : SupervivientesNet.Presentation.ServiceReference.IUsers, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UsersClient : System.ServiceModel.ClientBase<SupervivientesNet.Presentation.ServiceReference.IUsers>, SupervivientesNet.Presentation.ServiceReference.IUsers {
        
        public UsersClient() {
        }
        
        public UsersClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UsersClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsersClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsersClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SupervivientesNet.Presentation.ServiceReference.CompositeType Authenticate(string user, string pass) {
            return base.Channel.Authenticate(user, pass);
        }
        
        public System.Threading.Tasks.Task<SupervivientesNet.Presentation.ServiceReference.CompositeType> AuthenticateAsync(string user, string pass) {
            return base.Channel.AuthenticateAsync(user, pass);
        }
    }
}