﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.8941
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// Then modified.
// 


namespace R5T.Tools.SVN.XML
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:SvnStatus.xsd")]
    [System.Xml.Serialization.XmlRootAttribute("status", Namespace = "urn:SvnStatus.xsd", IsNullable = false)]
    public partial class StatusType
    {

        private TargetType[] targetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("target")]
        public TargetType[] target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:SvnStatus.xsd")]
    public partial class TargetType
    {

        private StatusEntryType[] entryField;

        private AgainstType againstField;

        private string pathField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("entry")]
        public StatusEntryType[] entry
        {
            get
            {
                return this.entryField;
            }
            set
            {
                this.entryField = value;
            }
        }

        /// <remarks/>
        public AgainstType against
        {
            get
            {
                return this.againstField;
            }
            set
            {
                this.againstField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:SvnStatus.xsd")]
    public partial class StatusEntryType
    {

        private WorkingCopyStatusType wcstatusField;

        private RepositoryStatusType reposstatusField;

        private string pathField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("wc-status")]
        public WorkingCopyStatusType wcstatus
        {
            get
            {
                return this.wcstatusField;
            }
            set
            {
                this.wcstatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("repos-status")]
        public RepositoryStatusType reposstatus
        {
            get
            {
                return this.reposstatusField;
            }
            set
            {
                this.reposstatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:SvnStatus.xsd")]
    public partial class RepositoryStatusType
    {

        private LockType lockField;

        private RepositoryItemType itemField;

        private RepositoryPropertiesType propsField;

        /// <remarks/>
        public LockType @lock
        {
            get
            {
                return this.lockField;
            }
            set
            {
                this.lockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RepositoryItemType item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RepositoryPropertiesType props
        {
            get
            {
                return this.propsField;
            }
            set
            {
                this.propsField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:SvnStatus.xsd")]
    public partial class WorkingCopyStatusType
    {

        private CommitType commitField;

        private LockType lockField;

        private WorkingCopyItemType itemField;

        private WorkingCopyPropertiesType propsField;

        private uint revisionField;

        private bool revisionFieldSpecified;

        private bool wclockedField;

        private bool wclockedFieldSpecified;

        private bool copiedField;

        private bool copiedFieldSpecified;

        private bool switchedField;

        private bool switchedFieldSpecified;

        /// <remarks/>
        public CommitType commit
        {
            get
            {
                return this.commitField;
            }
            set
            {
                this.commitField = value;
            }
        }

        /// <remarks/>
        public LockType @lock
        {
            get
            {
                return this.lockField;
            }
            set
            {
                this.lockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public WorkingCopyItemType item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public WorkingCopyPropertiesType props
        {
            get
            {
                return this.propsField;
            }
            set
            {
                this.propsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint revision
        {
            get
            {
                return this.revisionField;
            }
            set
            {
                this.revisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool revisionSpecified
        {
            get
            {
                return this.revisionFieldSpecified;
            }
            set
            {
                this.revisionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("wc-locked")]
        public bool wclocked
        {
            get
            {
                return this.wclockedField;
            }
            set
            {
                this.wclockedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool wclockedSpecified
        {
            get
            {
                return this.wclockedFieldSpecified;
            }
            set
            {
                this.wclockedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool copied
        {
            get
            {
                return this.copiedField;
            }
            set
            {
                this.copiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool copiedSpecified
        {
            get
            {
                return this.copiedFieldSpecified;
            }
            set
            {
                this.copiedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool switched
        {
            get
            {
                return this.switchedField;
            }
            set
            {
                this.switchedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool switchedSpecified
        {
            get
            {
                return this.switchedFieldSpecified;
            }
            set
            {
                this.switchedFieldSpecified = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:SvnStatus.xsd")]
    public partial class AgainstType
    {

        private uint revisionField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint revision
        {
            get
            {
                return this.revisionField;
            }
            set
            {
                this.revisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:SvnStatus.xsd")]
    public partial class LockType
    {

        private string tokenField;

        private string ownerField;

        private string commentField;

        private System.DateTime createdField;

        private System.DateTime expiresField;

        private bool expiresFieldSpecified;

        /// <remarks/>
        public string token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }

        /// <remarks/>
        public string owner
        {
            get
            {
                return this.ownerField;
            }
            set
            {
                this.ownerField = value;
            }
        }

        /// <remarks/>
        public string comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }

        /// <remarks/>
        public System.DateTime created
        {
            get
            {
                return this.createdField;
            }
            set
            {
                this.createdField = value;
            }
        }

        /// <remarks/>
        public System.DateTime expires
        {
            get
            {
                return this.expiresField;
            }
            set
            {
                this.expiresField = value;
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool expiresSpecified
        {
            get
            {
                return this.expiresFieldSpecified;
            }
            set
            {
                this.expiresFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:SvnStatus.xsd")]
    public enum RepositoryPropertiesType
    {

        /// <remarks/>
        modified,

        /// <remarks/>
        none,
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:SvnStatus.xsd")]
    public enum WorkingCopyPropertiesType
    {

        /// <remarks/>
        conflicted,

        /// <remarks/>
        modified,

        /// <remarks/>
        normal,

        /// <remarks/>
        none,
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:SvnStatus.xsd")]
    public enum RepositoryItemType
    {

        /// <remarks/>
        added,

        /// <remarks/>
        deleted,

        /// <remarks/>
        modified,

        /// <remarks/>
        replaced,

        /// <remarks/>
        none,
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:SvnStatus.xsd")]
    public enum WorkingCopyItemType
    {

        /// <remarks/>
        added,

        /// <remarks/>
        conflicted,

        /// <remarks/>
        deleted,

        /// <remarks/>
        ignored,

        /// <remarks/>
        modified,

        /// <remarks/>
        replaced,

        /// <remarks/>
        external,

        /// <remarks/>
        unversioned,

        /// <remarks/>
        incomplete,

        /// <remarks/>
        obstructed,

        /// <remarks/>
        normal,

        /// <remarks/>
        none,
    }
}