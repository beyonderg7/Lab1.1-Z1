﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UTaritmetica.srvAritmetica {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="clsAritmetica", Namespace="http://schemas.datacontract.org/2004/07/WcfAritmetica")]
    [System.SerializableAttribute()]
    public partial class clsAritmetica : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int numeroAField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int numeroBField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int respuestaField;
        
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
        public int numeroA {
            get {
                return this.numeroAField;
            }
            set {
                if ((this.numeroAField.Equals(value) != true)) {
                    this.numeroAField = value;
                    this.RaisePropertyChanged("numeroA");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int numeroB {
            get {
                return this.numeroBField;
            }
            set {
                if ((this.numeroBField.Equals(value) != true)) {
                    this.numeroBField = value;
                    this.RaisePropertyChanged("numeroB");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int respuesta {
            get {
                return this.respuestaField;
            }
            set {
                if ((this.respuestaField.Equals(value) != true)) {
                    this.respuestaField = value;
                    this.RaisePropertyChanged("respuesta");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="srvAritmetica.IWSaritmetica")]
    public interface IWSaritmetica {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSaritmetica/sumar", ReplyAction="http://tempuri.org/IWSaritmetica/sumarResponse")]
        UTaritmetica.srvAritmetica.clsAritmetica sumar(int numero1, int numbero2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSaritmetica/sumar", ReplyAction="http://tempuri.org/IWSaritmetica/sumarResponse")]
        System.Threading.Tasks.Task<UTaritmetica.srvAritmetica.clsAritmetica> sumarAsync(int numero1, int numbero2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWSaritmeticaChannel : UTaritmetica.srvAritmetica.IWSaritmetica, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSaritmeticaClient : System.ServiceModel.ClientBase<UTaritmetica.srvAritmetica.IWSaritmetica>, UTaritmetica.srvAritmetica.IWSaritmetica {
        
        public WSaritmeticaClient() {
        }
        
        public WSaritmeticaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSaritmeticaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSaritmeticaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSaritmeticaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public UTaritmetica.srvAritmetica.clsAritmetica sumar(int numero1, int numbero2) {
            return base.Channel.sumar(numero1, numbero2);
        }
        
        public System.Threading.Tasks.Task<UTaritmetica.srvAritmetica.clsAritmetica> sumarAsync(int numero1, int numbero2) {
            return base.Channel.sumarAsync(numero1, numbero2);
        }
    }
}
