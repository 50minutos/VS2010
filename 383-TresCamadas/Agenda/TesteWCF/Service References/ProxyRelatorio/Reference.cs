﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TesteWCF.ProxyRelatorio {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UsuarioModel", Namespace="http://schemas.datacontract.org/2004/07/BLL_DAL.Model")]
    [System.SerializableAttribute()]
    public partial class UsuarioModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private char AdmUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PwdUsuarioField;
        
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
        public char AdmUsuario {
            get {
                return this.AdmUsuarioField;
            }
            set {
                if ((this.AdmUsuarioField.Equals(value) != true)) {
                    this.AdmUsuarioField = value;
                    this.RaisePropertyChanged("AdmUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodUsuario {
            get {
                return this.CodUsuarioField;
            }
            set {
                if ((this.CodUsuarioField.Equals(value) != true)) {
                    this.CodUsuarioField = value;
                    this.RaisePropertyChanged("CodUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeUsuario {
            get {
                return this.NomeUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeUsuarioField, value) != true)) {
                    this.NomeUsuarioField = value;
                    this.RaisePropertyChanged("NomeUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PwdUsuario {
            get {
                return this.PwdUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.PwdUsuarioField, value) != true)) {
                    this.PwdUsuarioField = value;
                    this.RaisePropertyChanged("PwdUsuario");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyRelatorio.IRelatorio")]
    public interface IRelatorio {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRelatorio/ObterDadosRelatorioA", ReplyAction="http://tempuri.org/IRelatorio/ObterDadosRelatorioAResponse")]
        TesteWCF.ProxyRelatorio.UsuarioModel[] ObterDadosRelatorioA();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRelatorioChannel : TesteWCF.ProxyRelatorio.IRelatorio, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RelatorioClient : System.ServiceModel.ClientBase<TesteWCF.ProxyRelatorio.IRelatorio>, TesteWCF.ProxyRelatorio.IRelatorio {
        
        public RelatorioClient() {
        }
        
        public RelatorioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RelatorioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RelatorioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RelatorioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TesteWCF.ProxyRelatorio.UsuarioModel[] ObterDadosRelatorioA() {
            return base.Channel.ObterDadosRelatorioA();
        }
    }
}