﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.17929
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FastDFS.Client.Demo.webEyeSatisfactionSurvey {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SurveyDataEntity", Namespace="http://schemas.datacontract.org/2004/07/SatisfactionSurvey.Entity")]
    [System.SerializableAttribute()]
    public partial class SurveyDataEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ClinicDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeeCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeeNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ItemIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KindField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MobileField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PatientIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PatientNameField;
        
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
        public System.DateTime ClinicDate {
            get {
                return this.ClinicDateField;
            }
            set {
                if ((this.ClinicDateField.Equals(value) != true)) {
                    this.ClinicDateField = value;
                    this.RaisePropertyChanged("ClinicDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmployeeCode {
            get {
                return this.EmployeeCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeCodeField, value) != true)) {
                    this.EmployeeCodeField = value;
                    this.RaisePropertyChanged("EmployeeCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmployeeName {
            get {
                return this.EmployeeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeNameField, value) != true)) {
                    this.EmployeeNameField = value;
                    this.RaisePropertyChanged("EmployeeName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ItemId {
            get {
                return this.ItemIdField;
            }
            set {
                if ((this.ItemIdField.Equals(value) != true)) {
                    this.ItemIdField = value;
                    this.RaisePropertyChanged("ItemId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Kind {
            get {
                return this.KindField;
            }
            set {
                if ((object.ReferenceEquals(this.KindField, value) != true)) {
                    this.KindField = value;
                    this.RaisePropertyChanged("Kind");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mobile {
            get {
                return this.MobileField;
            }
            set {
                if ((object.ReferenceEquals(this.MobileField, value) != true)) {
                    this.MobileField = value;
                    this.RaisePropertyChanged("Mobile");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PatientId {
            get {
                return this.PatientIdField;
            }
            set {
                if ((object.ReferenceEquals(this.PatientIdField, value) != true)) {
                    this.PatientIdField = value;
                    this.RaisePropertyChanged("PatientId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PatientName {
            get {
                return this.PatientNameField;
            }
            set {
                if ((object.ReferenceEquals(this.PatientNameField, value) != true)) {
                    this.PatientNameField = value;
                    this.RaisePropertyChanged("PatientName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="webEyeSatisfactionSurvey.ISurveyService")]
    public interface ISurveyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISurveyService/SendSatisfactionSurvey", ReplyAction="http://tempuri.org/ISurveyService/SendSatisfactionSurveyResponse")]
        bool SendSatisfactionSurvey(FastDFS.Client.Demo.webEyeSatisfactionSurvey.SurveyDataEntity obj);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISurveyServiceChannel : FastDFS.Client.Demo.webEyeSatisfactionSurvey.ISurveyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SurveyServiceClient : System.ServiceModel.ClientBase<FastDFS.Client.Demo.webEyeSatisfactionSurvey.ISurveyService>, FastDFS.Client.Demo.webEyeSatisfactionSurvey.ISurveyService {
        
        public SurveyServiceClient() {
        }
        
        public SurveyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SurveyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SurveyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SurveyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool SendSatisfactionSurvey(FastDFS.Client.Demo.webEyeSatisfactionSurvey.SurveyDataEntity obj) {
            return base.Channel.SendSatisfactionSurvey(obj);
        }
    }
}
