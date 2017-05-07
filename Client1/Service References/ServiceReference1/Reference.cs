﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Issue", Namespace="http://schemas.datacontract.org/2004/07/RsiZ3Bookshelf")]
    [System.SerializableAttribute()]
    public partial class Issue : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriorityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public int Priority {
            get {
                return this.PriorityField;
            }
            set {
                if ((this.PriorityField.Equals(value) != true)) {
                    this.PriorityField = value;
                    this.RaisePropertyChanged("Priority");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IIssueTracker")]
    public interface IIssueTracker {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIssueTracker/putIssue", ReplyAction="http://tempuri.org/IIssueTracker/putIssueResponse")]
        int putIssue(Client1.ServiceReference1.Issue issue, string projectName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIssueTracker/putIssue", ReplyAction="http://tempuri.org/IIssueTracker/putIssueResponse")]
        System.Threading.Tasks.Task<int> putIssueAsync(Client1.ServiceReference1.Issue issue, string projectName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIssueTracker/getIssue", ReplyAction="http://tempuri.org/IIssueTracker/getIssueResponse")]
        Client1.ServiceReference1.Issue getIssue(int id, string projectName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIssueTracker/getIssue", ReplyAction="http://tempuri.org/IIssueTracker/getIssueResponse")]
        System.Threading.Tasks.Task<Client1.ServiceReference1.Issue> getIssueAsync(int id, string projectName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIssueTracker/delete", ReplyAction="http://tempuri.org/IIssueTracker/deleteResponse")]
        bool delete(int id, string projectName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIssueTracker/delete", ReplyAction="http://tempuri.org/IIssueTracker/deleteResponse")]
        System.Threading.Tasks.Task<bool> deleteAsync(int id, string projectName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IIssueTrackerChannel : Client1.ServiceReference1.IIssueTracker, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IssueTrackerClient : System.ServiceModel.ClientBase<Client1.ServiceReference1.IIssueTracker>, Client1.ServiceReference1.IIssueTracker {
        
        public IssueTrackerClient() {
        }
        
        public IssueTrackerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IssueTrackerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IssueTrackerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IssueTrackerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int putIssue(Client1.ServiceReference1.Issue issue, string projectName) {
            return base.Channel.putIssue(issue, projectName);
        }
        
        public System.Threading.Tasks.Task<int> putIssueAsync(Client1.ServiceReference1.Issue issue, string projectName) {
            return base.Channel.putIssueAsync(issue, projectName);
        }
        
        public Client1.ServiceReference1.Issue getIssue(int id, string projectName) {
            return base.Channel.getIssue(id, projectName);
        }
        
        public System.Threading.Tasks.Task<Client1.ServiceReference1.Issue> getIssueAsync(int id, string projectName) {
            return base.Channel.getIssueAsync(id, projectName);
        }
        
        public bool delete(int id, string projectName) {
            return base.Channel.delete(id, projectName);
        }
        
        public System.Threading.Tasks.Task<bool> deleteAsync(int id, string projectName) {
            return base.Channel.deleteAsync(id, projectName);
        }
    }
}
