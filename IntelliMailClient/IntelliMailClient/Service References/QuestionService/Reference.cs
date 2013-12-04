﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntelliMailClient.QuestionService {
    using System.Runtime.Serialization;
    using System;
    using System.ServiceModel.Web;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Question", Namespace="http://schemas.datacontract.org/2004/07/nl.fhict.IntelliCloud.Common.DataTransfer" +
        "")]
    [System.SerializableAttribute()]
    public partial class Question : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IntelliMailClient.QuestionService.Answer AnswerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IntelliMailClient.QuestionService.User AnswererField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> CreationTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsPrivateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IntelliMailClient.QuestionService.Keyword[] KeywordsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IntelliMailClient.QuestionService.LanguageDefinition LanguageDefinitionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IntelliMailClient.QuestionService.SourceDefinition SourceDefinitionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IntelliMailClient.QuestionService.User UserField;
        
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
        public IntelliMailClient.QuestionService.Answer Answer {
            get {
                return this.AnswerField;
            }
            set {
                if ((object.ReferenceEquals(this.AnswerField, value) != true)) {
                    this.AnswerField = value;
                    this.RaisePropertyChanged("Answer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public IntelliMailClient.QuestionService.User Answerer {
            get {
                return this.AnswererField;
            }
            set {
                if ((object.ReferenceEquals(this.AnswererField, value) != true)) {
                    this.AnswererField = value;
                    this.RaisePropertyChanged("Answerer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Content {
            get {
                return this.ContentField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentField, value) != true)) {
                    this.ContentField = value;
                    this.RaisePropertyChanged("Content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> CreationTime {
            get {
                return this.CreationTimeField;
            }
            set {
                if ((this.CreationTimeField.Equals(value) != true)) {
                    this.CreationTimeField = value;
                    this.RaisePropertyChanged("CreationTime");
                }
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
        public bool IsPrivate {
            get {
                return this.IsPrivateField;
            }
            set {
                if ((this.IsPrivateField.Equals(value) != true)) {
                    this.IsPrivateField = value;
                    this.RaisePropertyChanged("IsPrivate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public IntelliMailClient.QuestionService.Keyword[] Keywords {
            get {
                return this.KeywordsField;
            }
            set {
                if ((object.ReferenceEquals(this.KeywordsField, value) != true)) {
                    this.KeywordsField = value;
                    this.RaisePropertyChanged("Keywords");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public IntelliMailClient.QuestionService.LanguageDefinition LanguageDefinition {
            get {
                return this.LanguageDefinitionField;
            }
            set {
                if ((object.ReferenceEquals(this.LanguageDefinitionField, value) != true)) {
                    this.LanguageDefinitionField = value;
                    this.RaisePropertyChanged("LanguageDefinition");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public IntelliMailClient.QuestionService.SourceDefinition SourceDefinition {
            get {
                return this.SourceDefinitionField;
            }
            set {
                if ((object.ReferenceEquals(this.SourceDefinitionField, value) != true)) {
                    this.SourceDefinitionField = value;
                    this.RaisePropertyChanged("SourceDefinition");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public IntelliMailClient.QuestionService.User User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Answer", Namespace="http://schemas.datacontract.org/2004/07/nl.fhict.IntelliCloud.Common.DataTransfer" +
        "")]
    [System.SerializableAttribute()]
    public partial class Answer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IntelliMailClient.QuestionService.AnswerState AnswerStateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> CreationTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsPrivateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IntelliMailClient.QuestionService.Keyword[] KeywordsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IntelliMailClient.QuestionService.LanguageDefinition LanguageDefinitionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IntelliMailClient.QuestionService.User UserField;
        
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
        public IntelliMailClient.QuestionService.AnswerState AnswerState {
            get {
                return this.AnswerStateField;
            }
            set {
                if ((this.AnswerStateField.Equals(value) != true)) {
                    this.AnswerStateField = value;
                    this.RaisePropertyChanged("AnswerState");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Content {
            get {
                return this.ContentField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentField, value) != true)) {
                    this.ContentField = value;
                    this.RaisePropertyChanged("Content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> CreationTime {
            get {
                return this.CreationTimeField;
            }
            set {
                if ((this.CreationTimeField.Equals(value) != true)) {
                    this.CreationTimeField = value;
                    this.RaisePropertyChanged("CreationTime");
                }
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
        public bool IsPrivate {
            get {
                return this.IsPrivateField;
            }
            set {
                if ((this.IsPrivateField.Equals(value) != true)) {
                    this.IsPrivateField = value;
                    this.RaisePropertyChanged("IsPrivate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public IntelliMailClient.QuestionService.Keyword[] Keywords {
            get {
                return this.KeywordsField;
            }
            set {
                if ((object.ReferenceEquals(this.KeywordsField, value) != true)) {
                    this.KeywordsField = value;
                    this.RaisePropertyChanged("Keywords");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public IntelliMailClient.QuestionService.LanguageDefinition LanguageDefinition {
            get {
                return this.LanguageDefinitionField;
            }
            set {
                if ((object.ReferenceEquals(this.LanguageDefinitionField, value) != true)) {
                    this.LanguageDefinitionField = value;
                    this.RaisePropertyChanged("LanguageDefinition");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public IntelliMailClient.QuestionService.User User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/nl.fhict.IntelliCloud.Common.DataTransfer" +
        "")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> CreationTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InfixField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IntelliMailClient.QuestionService.Keyword[] KeywordsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IntelliMailClient.QuestionService.Source[] SourcesField;
        
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
        public System.Nullable<System.DateTime> CreationTime {
            get {
                return this.CreationTimeField;
            }
            set {
                if ((this.CreationTimeField.Equals(value) != true)) {
                    this.CreationTimeField = value;
                    this.RaisePropertyChanged("CreationTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
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
        public string Infix {
            get {
                return this.InfixField;
            }
            set {
                if ((object.ReferenceEquals(this.InfixField, value) != true)) {
                    this.InfixField = value;
                    this.RaisePropertyChanged("Infix");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public IntelliMailClient.QuestionService.Keyword[] Keywords {
            get {
                return this.KeywordsField;
            }
            set {
                if ((object.ReferenceEquals(this.KeywordsField, value) != true)) {
                    this.KeywordsField = value;
                    this.RaisePropertyChanged("Keywords");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public IntelliMailClient.QuestionService.Source[] Sources {
            get {
                return this.SourcesField;
            }
            set {
                if ((object.ReferenceEquals(this.SourcesField, value) != true)) {
                    this.SourcesField = value;
                    this.RaisePropertyChanged("Sources");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="LanguageDefinition", Namespace="http://schemas.datacontract.org/2004/07/nl.fhict.IntelliCloud.Common.DataTransfer" +
        "")]
    [System.SerializableAttribute()]
    public partial class LanguageDefinition : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SourceDefinition", Namespace="http://schemas.datacontract.org/2004/07/nl.fhict.IntelliCloud.Common.DataTransfer" +
        "")]
    [System.SerializableAttribute()]
    public partial class SourceDefinition : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreationTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UrlField;
        
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
        public System.DateTime CreationTime {
            get {
                return this.CreationTimeField;
            }
            set {
                if ((this.CreationTimeField.Equals(value) != true)) {
                    this.CreationTimeField = value;
                    this.RaisePropertyChanged("CreationTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Url {
            get {
                return this.UrlField;
            }
            set {
                if ((object.ReferenceEquals(this.UrlField, value) != true)) {
                    this.UrlField = value;
                    this.RaisePropertyChanged("Url");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Keyword", Namespace="http://schemas.datacontract.org/2004/07/nl.fhict.IntelliCloud.Common.DataTransfer" +
        "")]
    [System.SerializableAttribute()]
    public partial class Keyword : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AffinityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreationTimeField;
        
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
        public int Affinity {
            get {
                return this.AffinityField;
            }
            set {
                if ((this.AffinityField.Equals(value) != true)) {
                    this.AffinityField = value;
                    this.RaisePropertyChanged("Affinity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreationTime {
            get {
                return this.CreationTimeField;
            }
            set {
                if ((this.CreationTimeField.Equals(value) != true)) {
                    this.CreationTimeField = value;
                    this.RaisePropertyChanged("CreationTime");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AnswerState", Namespace="http://schemas.datacontract.org/2004/07/nl.fhict.IntelliCloud.Common.DataTransfer" +
        "")]
    public enum AnswerState : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Ready = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UnderReview = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Source", Namespace="http://schemas.datacontract.org/2004/07/nl.fhict.IntelliCloud.Common.DataTransfer" +
        "")]
    [System.SerializableAttribute()]
    public partial class Source : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreationTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IntelliMailClient.QuestionService.SourceDefinition SourceDefinitionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueField;
        
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
        public System.DateTime CreationTime {
            get {
                return this.CreationTimeField;
            }
            set {
                if ((this.CreationTimeField.Equals(value) != true)) {
                    this.CreationTimeField = value;
                    this.RaisePropertyChanged("CreationTime");
                }
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
        public IntelliMailClient.QuestionService.SourceDefinition SourceDefinition {
            get {
                return this.SourceDefinitionField;
            }
            set {
                if ((object.ReferenceEquals(this.SourceDefinitionField, value) != true)) {
                    this.SourceDefinitionField = value;
                    this.RaisePropertyChanged("SourceDefinition");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="QuestionService.IQuestionService")]
    public interface IQuestionService {
        
        [WebInvoke(BodyStyle=WebMessageBodyStyle.Wrapped)]
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionService/GetQuestions", ReplyAction="http://tempuri.org/IQuestionService/GetQuestionsResponse")]
        IntelliMailClient.QuestionService.Question[] GetQuestions(int employeeId);

        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionService/GetQuestions", ReplyAction="http://tempuri.org/IQuestionService/GetQuestionsResponse")]
        System.Threading.Tasks.Task<IntelliMailClient.QuestionService.Question[]> GetQuestionsAsync(int employeeId);

        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped)]
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionService/GetQuestion", ReplyAction="http://tempuri.org/IQuestionService/GetQuestionResponse")]
        IntelliMailClient.QuestionService.Question GetQuestion(string id);

        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionService/GetQuestion", ReplyAction="http://tempuri.org/IQuestionService/GetQuestionResponse")]
        System.Threading.Tasks.Task<IntelliMailClient.QuestionService.Question> GetQuestionAsync(string id);

        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped)]
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionService/CreateQuestion", ReplyAction="http://tempuri.org/IQuestionService/CreateQuestionResponse")]
        void CreateQuestion(string source, string reference, string question, string title);

        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionService/CreateQuestion", ReplyAction="http://tempuri.org/IQuestionService/CreateQuestionResponse")]
        System.Threading.Tasks.Task CreateQuestionAsync(string source, string reference, string question, string title);

        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped)]
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionService/UpdateQuestion", ReplyAction="http://tempuri.org/IQuestionService/UpdateQuestionResponse")]
        void UpdateQuestion(string id, int employeeId);

        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionService/UpdateQuestion", ReplyAction="http://tempuri.org/IQuestionService/UpdateQuestionResponse")]
        System.Threading.Tasks.Task UpdateQuestionAsync(string id, int employeeId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IQuestionServiceChannel : IntelliMailClient.QuestionService.IQuestionService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class QuestionServiceClient : System.ServiceModel.ClientBase<IntelliMailClient.QuestionService.IQuestionService>, IntelliMailClient.QuestionService.IQuestionService {
        
        public QuestionServiceClient() {
        }
        
        public QuestionServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public QuestionServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuestionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuestionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public IntelliMailClient.QuestionService.Question[] GetQuestions(int employeeId) {
            return base.Channel.GetQuestions(employeeId);
        }
        
        public System.Threading.Tasks.Task<IntelliMailClient.QuestionService.Question[]> GetQuestionsAsync(int employeeId) {
            return base.Channel.GetQuestionsAsync(employeeId);
        }
        
        public IntelliMailClient.QuestionService.Question GetQuestion(string id) {
            return base.Channel.GetQuestion(id);
        }
        
        public System.Threading.Tasks.Task<IntelliMailClient.QuestionService.Question> GetQuestionAsync(string id) {
            return base.Channel.GetQuestionAsync(id);
        }
        
        public void CreateQuestion(string source, string reference, string question, string title) {
            base.Channel.CreateQuestion(source, reference, question, title);
        }
        
        public System.Threading.Tasks.Task CreateQuestionAsync(string source, string reference, string question, string title) {
            return base.Channel.CreateQuestionAsync(source, reference, question, title);
        }
        
        public void UpdateQuestion(string id, int employeeId) {
            base.Channel.UpdateQuestion(id, employeeId);
        }
        
        public System.Threading.Tasks.Task UpdateQuestionAsync(string id, int employeeId) {
            return base.Channel.UpdateQuestionAsync(id, employeeId);
        }
    }
}