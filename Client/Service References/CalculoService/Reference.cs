﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.CalculoService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Calculo", Namespace="http://schemas.datacontract.org/2004/07/Maplink.Calculo.BE")]
    [System.SerializableAttribute()]
    public partial class Calculo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<Client.CalculoService.Endereco> EnderecoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.CalculoService.ETipoRota TipoRotaField;
        
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
        public System.Collections.Generic.List<Client.CalculoService.Endereco> Endereco {
            get {
                return this.EnderecoField;
            }
            set {
                if ((object.ReferenceEquals(this.EnderecoField, value) != true)) {
                    this.EnderecoField = value;
                    this.RaisePropertyChanged("Endereco");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.CalculoService.ETipoRota TipoRota {
            get {
                return this.TipoRotaField;
            }
            set {
                if ((this.TipoRotaField.Equals(value) != true)) {
                    this.TipoRotaField = value;
                    this.RaisePropertyChanged("TipoRota");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Endereco", Namespace="http://schemas.datacontract.org/2004/07/Maplink.Calculo.BE")]
    [System.SerializableAttribute()]
    public partial class Endereco : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CidadeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LogradouroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumeroField;
        
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
        public string Cidade {
            get {
                return this.CidadeField;
            }
            set {
                if ((object.ReferenceEquals(this.CidadeField, value) != true)) {
                    this.CidadeField = value;
                    this.RaisePropertyChanged("Cidade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Logradouro {
            get {
                return this.LogradouroField;
            }
            set {
                if ((object.ReferenceEquals(this.LogradouroField, value) != true)) {
                    this.LogradouroField = value;
                    this.RaisePropertyChanged("Logradouro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Numero {
            get {
                return this.NumeroField;
            }
            set {
                if ((object.ReferenceEquals(this.NumeroField, value) != true)) {
                    this.NumeroField = value;
                    this.RaisePropertyChanged("Numero");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ETipoRota", Namespace="http://schemas.datacontract.org/2004/07/Maplink.Calculo.BE.Constantes")]
    public enum ETipoRota : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Padrao = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        EvitarTransito = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Rota", Namespace="http://schemas.datacontract.org/2004/07/Maplink.Calculo.BE")]
    [System.SerializableAttribute()]
    public partial class Rota : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double CustoCombustivelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double CustoTotalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double DistanciaTotalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TempoTotalField;
        
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
        public double CustoCombustivel {
            get {
                return this.CustoCombustivelField;
            }
            set {
                if ((this.CustoCombustivelField.Equals(value) != true)) {
                    this.CustoCombustivelField = value;
                    this.RaisePropertyChanged("CustoCombustivel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double CustoTotal {
            get {
                return this.CustoTotalField;
            }
            set {
                if ((this.CustoTotalField.Equals(value) != true)) {
                    this.CustoTotalField = value;
                    this.RaisePropertyChanged("CustoTotal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double DistanciaTotal {
            get {
                return this.DistanciaTotalField;
            }
            set {
                if ((this.DistanciaTotalField.Equals(value) != true)) {
                    this.DistanciaTotalField = value;
                    this.RaisePropertyChanged("DistanciaTotal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TempoTotal {
            get {
                return this.TempoTotalField;
            }
            set {
                if ((object.ReferenceEquals(this.TempoTotalField, value) != true)) {
                    this.TempoTotalField = value;
                    this.RaisePropertyChanged("TempoTotal");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculoService.ICalculadora")]
    public interface ICalculadora {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadora/CustearRota", ReplyAction="http://tempuri.org/ICalculadora/CustearRotaResponse")]
        Client.CalculoService.Rota CustearRota(Client.CalculoService.Calculo calculo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadora/CustearRota", ReplyAction="http://tempuri.org/ICalculadora/CustearRotaResponse")]
        System.Threading.Tasks.Task<Client.CalculoService.Rota> CustearRotaAsync(Client.CalculoService.Calculo calculo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculadoraChannel : Client.CalculoService.ICalculadora, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculadoraClient : System.ServiceModel.ClientBase<Client.CalculoService.ICalculadora>, Client.CalculoService.ICalculadora {
        
        public CalculadoraClient() {
        }
        
        public CalculadoraClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculadoraClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculadoraClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculadoraClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client.CalculoService.Rota CustearRota(Client.CalculoService.Calculo calculo) {
            return base.Channel.CustearRota(calculo);
        }
        
        public System.Threading.Tasks.Task<Client.CalculoService.Rota> CustearRotaAsync(Client.CalculoService.Calculo calculo) {
            return base.Channel.CustearRotaAsync(calculo);
        }
    }
}
