﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientServicer.Restoran_serv {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Dish", Namespace="http://schemas.datacontract.org/2004/07/Exam.Models")]
    [System.SerializableAttribute()]
    public partial class Dish : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientServicer.Restoran_serv.Ingredient[] IngredientsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TotalAmountField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientServicer.Restoran_serv.Ingredient[] Ingredients {
            get {
                return this.IngredientsField;
            }
            set {
                if ((object.ReferenceEquals(this.IngredientsField, value) != true)) {
                    this.IngredientsField = value;
                    this.RaisePropertyChanged("Ingredients");
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
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TotalAmount {
            get {
                return this.TotalAmountField;
            }
            set {
                if ((object.ReferenceEquals(this.TotalAmountField, value) != true)) {
                    this.TotalAmountField = value;
                    this.RaisePropertyChanged("TotalAmount");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Ingredient", Namespace="http://schemas.datacontract.org/2004/07/Exam.Models")]
    [System.SerializableAttribute()]
    public partial class Ingredient : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Restoran_serv.IKitchenService")]
    public interface IKitchenService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKitchenService/GetAllDishes", ReplyAction="http://tempuri.org/IKitchenService/GetAllDishesResponse")]
        ClientServicer.Restoran_serv.Dish[] GetAllDishes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKitchenService/GetAllDishes", ReplyAction="http://tempuri.org/IKitchenService/GetAllDishesResponse")]
        System.Threading.Tasks.Task<ClientServicer.Restoran_serv.Dish[]> GetAllDishesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKitchenService/AddDish", ReplyAction="http://tempuri.org/IKitchenService/AddDishResponse")]
        void AddDish(ClientServicer.Restoran_serv.Dish newDish);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKitchenService/AddDish", ReplyAction="http://tempuri.org/IKitchenService/AddDishResponse")]
        System.Threading.Tasks.Task AddDishAsync(ClientServicer.Restoran_serv.Dish newDish);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IKitchenServiceChannel : ClientServicer.Restoran_serv.IKitchenService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class KitchenServiceClient : System.ServiceModel.ClientBase<ClientServicer.Restoran_serv.IKitchenService>, ClientServicer.Restoran_serv.IKitchenService {
        
        public KitchenServiceClient() {
        }
        
        public KitchenServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public KitchenServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KitchenServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KitchenServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClientServicer.Restoran_serv.Dish[] GetAllDishes() {
            return base.Channel.GetAllDishes();
        }
        
        public System.Threading.Tasks.Task<ClientServicer.Restoran_serv.Dish[]> GetAllDishesAsync() {
            return base.Channel.GetAllDishesAsync();
        }
        
        public void AddDish(ClientServicer.Restoran_serv.Dish newDish) {
            base.Channel.AddDish(newDish);
        }
        
        public System.Threading.Tasks.Task AddDishAsync(ClientServicer.Restoran_serv.Dish newDish) {
            return base.Channel.AddDishAsync(newDish);
        }
    }
}
