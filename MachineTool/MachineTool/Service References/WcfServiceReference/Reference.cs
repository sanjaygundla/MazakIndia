﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MachineTool.WcfServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tool_Details", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class Tool_Details : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tool_descField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tool_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tool_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tool_sizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tool_typeField;
        
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
        public string tool_desc {
            get {
                return this.tool_descField;
            }
            set {
                if ((object.ReferenceEquals(this.tool_descField, value) != true)) {
                    this.tool_descField = value;
                    this.RaisePropertyChanged("tool_desc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tool_id {
            get {
                return this.tool_idField;
            }
            set {
                if ((object.ReferenceEquals(this.tool_idField, value) != true)) {
                    this.tool_idField = value;
                    this.RaisePropertyChanged("tool_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tool_name {
            get {
                return this.tool_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.tool_nameField, value) != true)) {
                    this.tool_nameField = value;
                    this.RaisePropertyChanged("tool_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tool_size {
            get {
                return this.tool_sizeField;
            }
            set {
                if ((object.ReferenceEquals(this.tool_sizeField, value) != true)) {
                    this.tool_sizeField = value;
                    this.RaisePropertyChanged("tool_size");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tool_type {
            get {
                return this.tool_typeField;
            }
            set {
                if ((object.ReferenceEquals(this.tool_typeField, value) != true)) {
                    this.tool_typeField = value;
                    this.RaisePropertyChanged("tool_type");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfServiceReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetToolDetails", ReplyAction="http://tempuri.org/IService1/GetToolDetailsResponse")]
        System.Collections.ObjectModel.ObservableCollection<MachineTool.WcfServiceReference.Tool_Details> GetToolDetails();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetToolDetails", ReplyAction="http://tempuri.org/IService1/GetToolDetailsResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<MachineTool.WcfServiceReference.Tool_Details>> GetToolDetailsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateToolDetails", ReplyAction="http://tempuri.org/IService1/UpdateToolDetailsResponse")]
        void UpdateToolDetails(MachineTool.WcfServiceReference.Tool_Details obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateToolDetails", ReplyAction="http://tempuri.org/IService1/UpdateToolDetailsResponse")]
        System.Threading.Tasks.Task UpdateToolDetailsAsync(MachineTool.WcfServiceReference.Tool_Details obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddToolDetails", ReplyAction="http://tempuri.org/IService1/AddToolDetailsResponse")]
        void AddToolDetails(MachineTool.WcfServiceReference.Tool_Details obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddToolDetails", ReplyAction="http://tempuri.org/IService1/AddToolDetailsResponse")]
        System.Threading.Tasks.Task AddToolDetailsAsync(MachineTool.WcfServiceReference.Tool_Details obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteToolDetails", ReplyAction="http://tempuri.org/IService1/DeleteToolDetailsResponse")]
        void DeleteToolDetails(MachineTool.WcfServiceReference.Tool_Details obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteToolDetails", ReplyAction="http://tempuri.org/IService1/DeleteToolDetailsResponse")]
        System.Threading.Tasks.Task DeleteToolDetailsAsync(MachineTool.WcfServiceReference.Tool_Details obj);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : MachineTool.WcfServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<MachineTool.WcfServiceReference.IService1>, MachineTool.WcfServiceReference.IService1 {
        
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
        
        public System.Collections.ObjectModel.ObservableCollection<MachineTool.WcfServiceReference.Tool_Details> GetToolDetails() {
            return base.Channel.GetToolDetails();
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<MachineTool.WcfServiceReference.Tool_Details>> GetToolDetailsAsync() {
            return base.Channel.GetToolDetailsAsync();
        }
        
        public void UpdateToolDetails(MachineTool.WcfServiceReference.Tool_Details obj) {
            base.Channel.UpdateToolDetails(obj);
        }
        
        public System.Threading.Tasks.Task UpdateToolDetailsAsync(MachineTool.WcfServiceReference.Tool_Details obj) {
            return base.Channel.UpdateToolDetailsAsync(obj);
        }
        
        public void AddToolDetails(MachineTool.WcfServiceReference.Tool_Details obj) {
            base.Channel.AddToolDetails(obj);
        }
        
        public System.Threading.Tasks.Task AddToolDetailsAsync(MachineTool.WcfServiceReference.Tool_Details obj) {
            return base.Channel.AddToolDetailsAsync(obj);
        }
        
        public void DeleteToolDetails(MachineTool.WcfServiceReference.Tool_Details obj) {
            base.Channel.DeleteToolDetails(obj);
        }
        
        public System.Threading.Tasks.Task DeleteToolDetailsAsync(MachineTool.WcfServiceReference.Tool_Details obj) {
            return base.Channel.DeleteToolDetailsAsync(obj);
        }
    }
}
