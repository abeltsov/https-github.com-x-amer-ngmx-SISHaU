//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Integration.Base;


namespace Integration.NsiBase
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Svc2CodeConverter", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dom.gosuslugi.ru/schema/integration/nsi-base/")]
    public class nsiRef
    {
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Code
        {
            get;
            set;
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string GUID
        {
            get;
            set;
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Name
        {
            get;
            set;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Svc2CodeConverter", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dom.gosuslugi.ru/schema/integration/nsi-base/")]
    public class NsiListType
    {
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.DateTime Created
        {
            get;
            set;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("NsiItemInfo", Order=1)]
        public NsiItemInfoType[] NsiItemInfo
        {
            get;
            set;
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public ListGroup ListGroup
        {
            get;
            set;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Svc2CodeConverter", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dom.gosuslugi.ru/schema/integration/nsi-base/")]
    public class NsiItemInfoType
    {
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger", Order=0)]
        public string RegistryNumber
        {
            get;
            set;
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Name
        {
            get;
            set;
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public System.DateTime Modified
        {
            get;
            set;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Svc2CodeConverter", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://dom.gosuslugi.ru/schema/integration/nsi-base/")]
    public enum ListGroup
    {
        
        /// <remarks/>
        NSI,
        
        /// <remarks/>
        NSIRAO,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NsiElementAttachmentFieldType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NsiElementFiasAddressRefFieldType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NsiElementOkeiRefFieldType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NsiElementNsiRefFieldType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NsiElementNsiFieldType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NsiElementEnumFieldType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NsiElementIntegerFieldType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NsiElementDateFieldType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NsiElementFloatFieldType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NsiElementBooleanFieldType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NsiElementStringFieldType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Svc2CodeConverter", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dom.gosuslugi.ru/schema/integration/nsi-base/")]
    public class NsiElementFieldType
    {
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Name
        {
            get;
            set;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Svc2CodeConverter", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dom.gosuslugi.ru/schema/integration/nsi-base/")]
    public class NsiElementAttachmentFieldType : NsiElementFieldType
    {
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public AttachmentType Document
        {
            get;
            set;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Svc2CodeConverter", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dom.gosuslugi.ru/schema/integration/nsi-base/")]
    public class NsiElementFiasAddressRefFieldType : NsiElementFieldType
    {
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public NsiElementFiasAddressRefFieldTypeNsiRef NsiRef
        {
            get;
            set;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Svc2CodeConverter", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://dom.gosuslugi.ru/schema/integration/nsi-base/")]
    public class NsiElementFiasAddressRefFieldTypeNsiRef
    {
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Guid
        {
            get;
            set;
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string aoGuid
        {
            get;
            set;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Svc2CodeConverter", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dom.gosuslugi.ru/schema/integration/nsi-base/")]
    public class NsiElementOkeiRefFieldType : NsiElementFieldType
    {
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Code
        {
            get;
            set;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Svc2CodeConverter", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dom.gosuslugi.ru/schema/integration/nsi-base/")]
    public class NsiElementNsiRefFieldType : NsiElementFieldType
    {
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public NsiElementNsiRefFieldTypeNsiRef NsiRef
        {
            get;
            set;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Svc2CodeConverter", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://dom.gosuslugi.ru/schema/integration/nsi-base/")]
    public class NsiElementNsiRefFieldTypeNsiRef
    {
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger", Order=0)]
        public string NsiItemRegistryNumber
        {
            get;
            set;
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public nsiRef Ref
        {
            get;
            set;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Svc2CodeConverter", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dom.gosuslugi.ru/schema/integration/nsi-base/")]
    public class NsiElementNsiFieldType : NsiElementFieldType
    {
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public NsiElementNsiFieldTypeNsiRef NsiRef
        {
            get;
            set;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Svc2CodeConverter", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://dom.gosuslugi.ru/schema/integration/nsi-base/")]
    public class NsiElementNsiFieldTypeNsiRef
    {
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger", Order=0)]
        public string NsiItemRegistryNumber
        {
            get;
            set;
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ListGroup ListGroup
        {
            get;
            set;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Svc2CodeConverter", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dom.gosuslugi.ru/schema/integration/nsi-base/")]
    public class NsiElementEnumFieldType : NsiElementFieldType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("Position", Order=0)]
        public NsiElementEnumFieldTypePosition[] Position
        {
            get;
            set;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Svc2CodeConverter", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://dom.gosuslugi.ru/schema/integration/nsi-base/")]
    public class NsiElementEnumFieldTypePosition
    {
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public object GUID
        {
            get;
            set;
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Value
        {
            get;
            set;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Svc2CodeConverter", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dom.gosuslugi.ru/schema/integration/nsi-base/")]
    public class NsiElementIntegerFieldType : NsiElementFieldType
    {
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=0)]
        public string Value
        {
            get;
            set;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Svc2CodeConverter", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dom.gosuslugi.ru/schema/integration/nsi-base/")]
    public class NsiElementDateFieldType : NsiElementFieldType
    {
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=0)]
        public System.DateTime Value
        {
            get;
            set;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Svc2CodeConverter", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dom.gosuslugi.ru/schema/integration/nsi-base/")]
    public class NsiElementFloatFieldType : NsiElementFieldType
    {
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public float Value
        {
            get;
            set;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Svc2CodeConverter", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dom.gosuslugi.ru/schema/integration/nsi-base/")]
    public class NsiElementBooleanFieldType : NsiElementFieldType
    {
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool Value
        {
            get;
            set;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Svc2CodeConverter", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dom.gosuslugi.ru/schema/integration/nsi-base/")]
    public class NsiElementStringFieldType : NsiElementFieldType
    {
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Value
        {
            get;
            set;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Svc2CodeConverter", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dom.gosuslugi.ru/schema/integration/nsi-base/")]
    public class NsiElementType
    {
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Code
        {
            get;
            set;
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string GUID
        {
            get;
            set;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("EndDate", typeof(System.DateTime), Order=2)]
        public System.DateTime EndDate
        {
            get;
            set;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Modified", typeof(System.DateTime), Order=3)]
        public System.DateTime Modified
        {
            get;
            set;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("StartDate", typeof(System.DateTime), Order=4)]
        public System.DateTime StartDate
        {
            get;
            set;
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool IsActual
        {
            get;
            set;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("NsiElementField", Order=6)]
        public NsiElementFieldType[] NsiElementField
        {
            get;
            set;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ChildElement", Order=7)]
        public NsiElementType[] ChildElement
        {
            get;
            set;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Svc2CodeConverter", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dom.gosuslugi.ru/schema/integration/nsi-base/")]
    public class NsiItemType
    {
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger", Order=0)]
        public string NsiItemRegistryNumber
        {
            get;
            set;
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.DateTime Created
        {
            get;
            set;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("NsiElement", Order=2)]
        public NsiElementType[] NsiElement
        {
            get;
            set;
        }
    }
}
