
using System.Runtime.Serialization;
[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://webservices.sabre.com", ClrNamespace = "webservices.sabre.com")]

namespace GD.Sabre.Connect.Common.Service;

using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.ComponentModel;
using GD.Sabre.Common.Core.Reference;


/// <remarks/>



/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ebxml.org/namespaces/messageHeader")]
public partial class From
{

    private PartyId[] partyIdField;

    private string roleField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PartyId")]
    public PartyId[] PartyId
    {
        get
        {
            return this.partyIdField;
        }
        set
        {
            this.partyIdField = value;
        }
    }

    /// <remarks/>
    public string Role
    {
        get
        {
            return this.roleField;
        }
        set
        {
            this.roleField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ebxml.org/namespaces/messageHeader")]
public partial class PartyId
{

    private string typeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://services.sabre.com/STL_Header/v120")]
public partial class ProblemBase
{

    private ErrorType typeField;

    private CompletionCodes statusField;

    private System.DateTime timeStampField;

    private bool timeStampFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ErrorType type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public CompletionCodes status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime timeStamp
    {
        get
        {
            return this.timeStampField;
        }
        set
        {
            this.timeStampField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeStampSpecified
    {
        get
        {
            return this.timeStampFieldSpecified;
        }
        set
        {
            this.timeStampFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://services.sabre.com/STL_Header/v120")]
public enum ErrorType
{

    /// <remarks/>
    Transport,

    /// <remarks/>
    Validation,

    /// <remarks/>
    Application,

    /// <remarks/>
    BusinessLogic,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://services.sabre.com/STL_Header/v120")]
public enum CompletionCodes
{

    /// <remarks/>
    Complete,

    /// <remarks/>
    Incomplete,

    /// <remarks/>
    NotProcessed,

    /// <remarks/>
    Unknown,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://services.sabre.com/STL_Header/v120")]
public partial class Diagnostics
{

    private DiagnosticLevels levelField;

    private bool levelFieldSpecified;

    private string dataField;

    private System.Xml.XmlElement diagnosticField;

    /// <remarks/>
    public DiagnosticLevels Level
    {
        get
        {
            return this.levelField;
        }
        set
        {
            this.levelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool LevelSpecified
    {
        get
        {
            return this.levelFieldSpecified;
        }
        set
        {
            this.levelFieldSpecified = value;
        }
    }

    /// <remarks/>
    public string Data
    {
        get
        {
            return this.dataField;
        }
        set
        {
            this.dataField = value;
        }
    }

    /// <remarks/>
    public System.Xml.XmlElement Diagnostic
    {
        get
        {
            return this.diagnosticField;
        }
        set
        {
            this.diagnosticField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://services.sabre.com/STL_Header/v120")]
public enum DiagnosticLevels
{

    /// <remarks/>
    Mock,

    /// <remarks/>
    Simulate,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://services.sabre.com/STL_Header/v120")]
public partial class TraceRecord
{

    private string keyField;

    private System.DateTime startField;

    private System.DateTime endField;

    private bool endFieldSpecified;

    private string appInstanceField;

    private string clusterField;

    private string hostField;

    private string targetURIField;

    private TraceRole roleField;

    private bool roleFieldSpecified;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string key
    {
        get
        {
            return this.keyField;
        }
        set
        {
            this.keyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime start
    {
        get
        {
            return this.startField;
        }
        set
        {
            this.startField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime end
    {
        get
        {
            return this.endField;
        }
        set
        {
            this.endField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool endSpecified
    {
        get
        {
            return this.endFieldSpecified;
        }
        set
        {
            this.endFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string appInstance
    {
        get
        {
            return this.appInstanceField;
        }
        set
        {
            this.appInstanceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string cluster
    {
        get
        {
            return this.clusterField;
        }
        set
        {
            this.clusterField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string host
    {
        get
        {
            return this.hostField;
        }
        set
        {
            this.hostField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string targetURI
    {
        get
        {
            return this.targetURIField;
        }
        set
        {
            this.targetURIField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public TraceRole role
    {
        get
        {
            return this.roleField;
        }
        set
        {
            this.roleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool roleSpecified
    {
        get
        {
            return this.roleFieldSpecified;
        }
        set
        {
            this.roleFieldSpecified = value;
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://services.sabre.com/STL_Header/v120")]
public enum TraceRole
{

    /// <remarks/>
    consumer,

    /// <remarks/>
    provider,

    /// <remarks/>
    gateway,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://services.sabre.com/STL_Header/v120")]
public partial class Security
{

    private string itemField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SecurityToken")]
    public string Item
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
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName = "Identifier.System", Namespace = "http://services.sabre.com/STL_Header/v120")]
public partial class IdentifierSystem
{

    private string instanceField;

    private string clusterField;

    private string hostField;

    private string uriField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string instance
    {
        get
        {
            return this.instanceField;
        }
        set
        {
            this.instanceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string cluster
    {
        get
        {
            return this.clusterField;
        }
        set
        {
            this.clusterField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string host
    {
        get
        {
            return this.hostField;
        }
        set
        {
            this.hostField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string uri
    {
        get
        {
            return this.uriField;
        }
        set
        {
            this.uriField = value;
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://services.sabre.com/STL_Header/v120")]
public partial class ProblemSummary
{

    private IdentifierSystem sourceField;

    private IdentifierSystem reportingSystemField;

    private MessageCondition messageField;

    private string shortTextField;

    private ErrorType typeField;

    private CompletionCodes statusField;

    private System.DateTime timeStampField;

    private bool timeStampFieldSpecified;

    /// <remarks/>
    public IdentifierSystem Source
    {
        get
        {
            return this.sourceField;
        }
        set
        {
            this.sourceField = value;
        }
    }

    /// <remarks/>
    public IdentifierSystem ReportingSystem
    {
        get
        {
            return this.reportingSystemField;
        }
        set
        {
            this.reportingSystemField = value;
        }
    }

    /// <remarks/>
    public MessageCondition Message
    {
        get
        {
            return this.messageField;
        }
        set
        {
            this.messageField = value;
        }
    }

    /// <remarks/>
    public string ShortText
    {
        get
        {
            return this.shortTextField;
        }
        set
        {
            this.shortTextField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ErrorType type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public CompletionCodes status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime timeStamp
    {
        get
        {
            return this.timeStampField;
        }
        set
        {
            this.timeStampField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeStampSpecified
    {
        get
        {
            return this.timeStampFieldSpecified;
        }
        set
        {
            this.timeStampFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName = "Message.Condition", Namespace = "http://services.sabre.com/STL_Header/v120")]
public partial class MessageCondition
{

    private string codeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://services.sabre.com/STL_Header/v120")]
public partial class ResultSummary
{

    private object itemField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Error", typeof(ProblemSummary))]
    [System.Xml.Serialization.XmlElementAttribute("Success", typeof(string))]
    public object Item
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
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://services.sabre.com/STL_Header/v120")]
public partial class TrackingID
{

    private string seqField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    public string seq
    {
        get
        {
            return this.seqField;
        }
        set
        {
            this.seqField = value;
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://services.sabre.com/STL_Header/v120")]
public partial class Identification
{

    private string customerIDField;

    private string customerAppIDField;

    private TrackingID conversationIDField;

    private string messageIDField;

    private System.DateTime timeStampField;

    private bool timeStampFieldSpecified;

    /// <remarks/>
    public string CustomerID
    {
        get
        {
            return this.customerIDField;
        }
        set
        {
            this.customerIDField = value;
        }
    }

    /// <remarks/>
    public string CustomerAppID
    {
        get
        {
            return this.customerAppIDField;
        }
        set
        {
            this.customerAppIDField = value;
        }
    }

    /// <remarks/>
    public TrackingID ConversationID
    {
        get
        {
            return this.conversationIDField;
        }
        set
        {
            this.conversationIDField = value;
        }
    }

    /// <remarks/>
    public string MessageID
    {
        get
        {
            return this.messageIDField;
        }
        set
        {
            this.messageIDField = value;
        }
    }

    /// <remarks/>
    public System.DateTime TimeStamp
    {
        get
        {
            return this.timeStampField;
        }
        set
        {
            this.timeStampField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TimeStampSpecified
    {
        get
        {
            return this.timeStampFieldSpecified;
        }
        set
        {
            this.timeStampFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName = "Service", Namespace = "http://services.sabre.com/STL_Header/v120")]
public partial class Service1
{

    private string operationField;

    private string versionField;

    private string ttlField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string operation
    {
        get
        {
            return this.operationField;
        }
        set
        {
            this.operationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
    public string ttl
    {
        get
        {
            return this.ttlField;
        }
        set
        {
            this.ttlField = value;
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://services.sabre.com/STL_Header/v120")]
public partial class SabreHeader
{

    private Service1 serviceField;

    private Identification identificationField;

    private ResultSummary resultSummaryField;

    private Security securityField;

    private TraceRecord[] tracesField;

    private Diagnostics diagnosticsField;

    /// <remarks/>
    public Service1 Service
    {
        get
        {
            return this.serviceField;
        }
        set
        {
            this.serviceField = value;
        }
    }

    /// <remarks/>
    public Identification Identification
    {
        get
        {
            return this.identificationField;
        }
        set
        {
            this.identificationField = value;
        }
    }

    /// <remarks/>
    public ResultSummary ResultSummary
    {
        get
        {
            return this.resultSummaryField;
        }
        set
        {
            this.resultSummaryField = value;
        }
    }

    /// <remarks/>
    public Security Security
    {
        get
        {
            return this.securityField;
        }
        set
        {
            this.securityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Trace", IsNullable = false)]
    public TraceRecord[] Traces
    {
        get
        {
            return this.tracesField;
        }
        set
        {
            this.tracesField = value;
        }
    }

    /// <remarks/>
    public Diagnostics Diagnostics
    {
        get
        {
            return this.diagnosticsField;
        }
        set
        {
            this.diagnosticsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
public partial class detail
{

    private System.Xml.XmlElement[] anyField;

    private System.Xml.XmlAttribute[] anyAttrField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any
    {
        get
        {
            return this.anyField;
        }
        set
        {
            this.anyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAnyAttributeAttribute()]
    public System.Xml.XmlAttribute[] AnyAttr
    {
        get
        {
            return this.anyAttrField;
        }
        set
        {
            this.anyAttrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
public partial class Fault
{

    private System.Xml.XmlQualifiedName faultcodeField;

    private string faultstringField;

    private string faultactorField;

    private detail detailField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Xml.XmlQualifiedName faultcode
    {
        get
        {
            return this.faultcodeField;
        }
        set
        {
            this.faultcodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string faultstring
    {
        get
        {
            return this.faultstringField;
        }
        set
        {
            this.faultstringField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "anyURI")]
    public string faultactor
    {
        get
        {
            return this.faultactorField;
        }
        set
        {
            this.faultactorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public detail detail
    {
        get
        {
            return this.detailField;
        }
        set
        {
            this.detailField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
public partial class Body
{

    private System.Xml.XmlElement[] anyField;

    private System.Xml.XmlAttribute[] anyAttrField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any
    {
        get
        {
            return this.anyField;
        }
        set
        {
            this.anyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAnyAttributeAttribute()]
    public System.Xml.XmlAttribute[] AnyAttr
    {
        get
        {
            return this.anyAttrField;
        }
        set
        {
            this.anyAttrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
public partial class Header
{

    private System.Xml.XmlElement[] anyField;

    private System.Xml.XmlAttribute[] anyAttrField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any
    {
        get
        {
            return this.anyField;
        }
        set
        {
            this.anyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAnyAttributeAttribute()]
    public System.Xml.XmlAttribute[] AnyAttr
    {
        get
        {
            return this.anyAttrField;
        }
        set
        {
            this.anyAttrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
public partial class Envelope
{

    private Header[] headerField;

    private Body bodyField;

    private System.Xml.XmlElement[] anyField;

    private System.Xml.XmlAttribute[] anyAttrField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Header")]
    public Header[] Header
    {
        get
        {
            return this.headerField;
        }
        set
        {
            this.headerField = value;
        }
    }

    /// <remarks/>
    public Body Body
    {
        get
        {
            return this.bodyField;
        }
        set
        {
            this.bodyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any
    {
        get
        {
            return this.anyField;
        }
        set
        {
            this.anyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAnyAttributeAttribute()]
    public System.Xml.XmlAttribute[] AnyAttr
    {
        get
        {
            return this.anyAttrField;
        }
        set
        {
            this.anyAttrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class SignaturePropertyType
{

    private System.Xml.XmlElement[] itemsField;

    private string[] textField;

    private string targetField;

    private string idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text
    {
        get
        {
            return this.textField;
        }
        set
        {
            this.textField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string Target
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

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class SignaturePropertiesType
{

    private SignaturePropertyType[] signaturePropertyField;

    private string idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SignatureProperty")]
    public SignaturePropertyType[] SignatureProperty
    {
        get
        {
            return this.signaturePropertyField;
        }
        set
        {
            this.signaturePropertyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class ManifestType
{

    private ReferenceType[] referenceField;

    private string idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Reference")]
    public ReferenceType[] Reference
    {
        get
        {
            return this.referenceField;
        }
        set
        {
            this.referenceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class ReferenceType
{

    private TransformType[] transformsField;

    private DigestMethodType digestMethodField;

    private byte[] digestValueField;

    private string idField;

    private string uRIField;

    private string typeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
    public TransformType[] Transforms
    {
        get
        {
            return this.transformsField;
        }
        set
        {
            this.transformsField = value;
        }
    }

    /// <remarks/>
    public DigestMethodType DigestMethod
    {
        get
        {
            return this.digestMethodField;
        }
        set
        {
            this.digestMethodField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
    public byte[] DigestValue
    {
        get
        {
            return this.digestValueField;
        }
        set
        {
            this.digestValueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string URI
    {
        get
        {
            return this.uRIField;
        }
        set
        {
            this.uRIField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class TransformType
{

    private object[] itemsField;

    private string[] textField;

    private string algorithmField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    [System.Xml.Serialization.XmlElementAttribute("XPath", typeof(string))]
    public object[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text
    {
        get
        {
            return this.textField;
        }
        set
        {
            this.textField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string Algorithm
    {
        get
        {
            return this.algorithmField;
        }
        set
        {
            this.algorithmField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class DigestMethodType
{

    private System.Xml.XmlNode[] anyField;

    private string algorithmField;

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlNode[] Any
    {
        get
        {
            return this.anyField;
        }
        set
        {
            this.anyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string Algorithm
    {
        get
        {
            return this.algorithmField;
        }
        set
        {
            this.algorithmField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class ObjectType
{

    private System.Xml.XmlNode[] anyField;

    private string idField;

    private string mimeTypeField;

    private string encodingField;

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlNode[] Any
    {
        get
        {
            return this.anyField;
        }
        set
        {
            this.anyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MimeType
    {
        get
        {
            return this.mimeTypeField;
        }
        set
        {
            this.mimeTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string Encoding
    {
        get
        {
            return this.encodingField;
        }
        set
        {
            this.encodingField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class SPKIDataType
{

    private byte[] sPKISexpField;

    private System.Xml.XmlElement anyField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SPKISexp", DataType = "base64Binary")]
    public byte[] SPKISexp
    {
        get
        {
            return this.sPKISexpField;
        }
        set
        {
            this.sPKISexpField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement Any
    {
        get
        {
            return this.anyField;
        }
        set
        {
            this.anyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class PGPDataType
{

    private byte[] pGPKeyIDField;

    private byte[] pGPKeyPacketField;

    private System.Xml.XmlElement[] anyField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
    public byte[] PGPKeyID
    {
        get
        {
            return this.pGPKeyIDField;
        }
        set
        {
            this.pGPKeyIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
    public byte[] PGPKeyPacket
    {
        get
        {
            return this.pGPKeyPacketField;
        }
        set
        {
            this.pGPKeyPacketField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any
    {
        get
        {
            return this.anyField;
        }
        set
        {
            this.anyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class X509IssuerSerialType
{

    private string x509IssuerNameField;

    private string x509SerialNumberField;

    /// <remarks/>
    public string X509IssuerName
    {
        get
        {
            return this.x509IssuerNameField;
        }
        set
        {
            this.x509IssuerNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string X509SerialNumber
    {
        get
        {
            return this.x509SerialNumberField;
        }
        set
        {
            this.x509SerialNumberField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class X509DataType
{

    private object[] itemsField;

    private ItemsChoiceType[] itemsElementNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    [System.Xml.Serialization.XmlElementAttribute("X509CRL", typeof(byte[]), DataType = "base64Binary")]
    [System.Xml.Serialization.XmlElementAttribute("X509Certificate", typeof(byte[]), DataType = "base64Binary")]
    [System.Xml.Serialization.XmlElementAttribute("X509IssuerSerial", typeof(X509IssuerSerialType))]
    [System.Xml.Serialization.XmlElementAttribute("X509SKI", typeof(byte[]), DataType = "base64Binary")]
    [System.Xml.Serialization.XmlElementAttribute("X509SubjectName", typeof(string))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType[] ItemsElementName
    {
        get
        {
            return this.itemsElementNameField;
        }
        set
        {
            this.itemsElementNameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
public enum ItemsChoiceType
{

    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("##any:")]
    Item,

    /// <remarks/>
    X509CRL,

    /// <remarks/>
    X509Certificate,

    /// <remarks/>
    X509IssuerSerial,

    /// <remarks/>
    X509SKI,

    /// <remarks/>
    X509SubjectName,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class RetrievalMethodType
{

    private TransformType[] transformsField;

    private string uRIField;

    private string typeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
    public TransformType[] Transforms
    {
        get
        {
            return this.transformsField;
        }
        set
        {
            this.transformsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string URI
    {
        get
        {
            return this.uRIField;
        }
        set
        {
            this.uRIField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class RSAKeyValueType
{

    private byte[] modulusField;

    private byte[] exponentField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
    public byte[] Modulus
    {
        get
        {
            return this.modulusField;
        }
        set
        {
            this.modulusField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
    public byte[] Exponent
    {
        get
        {
            return this.exponentField;
        }
        set
        {
            this.exponentField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class DSAKeyValueType
{

    private byte[] pField;

    private byte[] qField;

    private byte[] gField;

    private byte[] yField;

    private byte[] jField;

    private byte[] seedField;

    private byte[] pgenCounterField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
    public byte[] P
    {
        get
        {
            return this.pField;
        }
        set
        {
            this.pField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
    public byte[] Q
    {
        get
        {
            return this.qField;
        }
        set
        {
            this.qField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
    public byte[] G
    {
        get
        {
            return this.gField;
        }
        set
        {
            this.gField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
    public byte[] Y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
    public byte[] J
    {
        get
        {
            return this.jField;
        }
        set
        {
            this.jField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
    public byte[] Seed
    {
        get
        {
            return this.seedField;
        }
        set
        {
            this.seedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
    public byte[] PgenCounter
    {
        get
        {
            return this.pgenCounterField;
        }
        set
        {
            this.pgenCounterField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class KeyValueType
{

    private object itemField;

    private string[] textField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    [System.Xml.Serialization.XmlElementAttribute("DSAKeyValue", typeof(DSAKeyValueType))]
    [System.Xml.Serialization.XmlElementAttribute("RSAKeyValue", typeof(RSAKeyValueType))]
    public object Item
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
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text
    {
        get
        {
            return this.textField;
        }
        set
        {
            this.textField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class KeyInfoType
{

    private object[] itemsField;

    private ItemsChoiceType1[] itemsElementNameField;

    private string[] textField;

    private string idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    [System.Xml.Serialization.XmlElementAttribute("KeyName", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("KeyValue", typeof(KeyValueType))]
    [System.Xml.Serialization.XmlElementAttribute("MgmtData", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("PGPData", typeof(PGPDataType))]
    [System.Xml.Serialization.XmlElementAttribute("RetrievalMethod", typeof(RetrievalMethodType))]
    [System.Xml.Serialization.XmlElementAttribute("SPKIData", typeof(SPKIDataType))]
    [System.Xml.Serialization.XmlElementAttribute("X509Data", typeof(X509DataType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType1[] ItemsElementName
    {
        get
        {
            return this.itemsElementNameField;
        }
        set
        {
            this.itemsElementNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text
    {
        get
        {
            return this.textField;
        }
        set
        {
            this.textField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
public enum ItemsChoiceType1
{

    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("##any:")]
    Item,

    /// <remarks/>
    KeyName,

    /// <remarks/>
    KeyValue,

    /// <remarks/>
    MgmtData,

    /// <remarks/>
    PGPData,

    /// <remarks/>
    RetrievalMethod,

    /// <remarks/>
    SPKIData,

    /// <remarks/>
    X509Data,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class SignatureValueType
{

    private string idField;

    private byte[] valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
    public byte[] Value
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class SignatureMethodType
{

    private string hMACOutputLengthField;

    private System.Xml.XmlNode[] anyField;

    private string algorithmField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string HMACOutputLength
    {
        get
        {
            return this.hMACOutputLengthField;
        }
        set
        {
            this.hMACOutputLengthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlNode[] Any
    {
        get
        {
            return this.anyField;
        }
        set
        {
            this.anyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string Algorithm
    {
        get
        {
            return this.algorithmField;
        }
        set
        {
            this.algorithmField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class CanonicalizationMethodType
{

    private System.Xml.XmlNode[] anyField;

    private string algorithmField;

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlNode[] Any
    {
        get
        {
            return this.anyField;
        }
        set
        {
            this.anyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string Algorithm
    {
        get
        {
            return this.algorithmField;
        }
        set
        {
            this.algorithmField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class SignedInfoType
{

    private CanonicalizationMethodType canonicalizationMethodField;

    private SignatureMethodType signatureMethodField;

    private ReferenceType[] referenceField;

    private string idField;

    /// <remarks/>
    public CanonicalizationMethodType CanonicalizationMethod
    {
        get
        {
            return this.canonicalizationMethodField;
        }
        set
        {
            this.canonicalizationMethodField = value;
        }
    }

    /// <remarks/>
    public SignatureMethodType SignatureMethod
    {
        get
        {
            return this.signatureMethodField;
        }
        set
        {
            this.signatureMethodField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Reference")]
    public ReferenceType[] Reference
    {
        get
        {
            return this.referenceField;
        }
        set
        {
            this.referenceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class SignatureType
{

    private SignedInfoType signedInfoField;

    private SignatureValueType signatureValueField;

    private KeyInfoType keyInfoField;

    private ObjectType[] objectField;

    private string idField;

    /// <remarks/>
    public SignedInfoType SignedInfo
    {
        get
        {
            return this.signedInfoField;
        }
        set
        {
            this.signedInfoField = value;
        }
    }

    /// <remarks/>
    public SignatureValueType SignatureValue
    {
        get
        {
            return this.signatureValueField;
        }
        set
        {
            this.signatureValueField = value;
        }
    }

    /// <remarks/>
    public KeyInfoType KeyInfo
    {
        get
        {
            return this.keyInfoField;
        }
        set
        {
            this.keyInfoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Object")]
    public ObjectType[] Object
    {
        get
        {
            return this.objectField;
        }
        set
        {
            this.objectField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://services.sabre.com/STL/v01")]
public partial class HostCommand
{

    private string lNIATAField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string LNIATA
    {
        get
        {
            return this.lNIATAField;
        }
        set
        {
            this.lNIATAField = value;
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://services.sabre.com/STL/v01")]
public partial class SystemSpecificResults
{

    private HostCommand hostCommandField;

    private MessageCondition[] messageField;

    private string shortTextField;

    private string elementField;

    private string recordIDField;

    private string docURLField;

    private System.DateTime timeStampField;

    private bool timeStampFieldSpecified;

    /// <remarks/>
    public HostCommand HostCommand
    {
        get
        {
            return this.hostCommandField;
        }
        set
        {
            this.hostCommandField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Message")]
    public MessageCondition[] Message
    {
        get
        {
            return this.messageField;
        }
        set
        {
            this.messageField = value;
        }
    }

    /// <remarks/>
    public string ShortText
    {
        get
        {
            return this.shortTextField;
        }
        set
        {
            this.shortTextField = value;
        }
    }

    /// <remarks/>
    public string Element
    {
        get
        {
            return this.elementField;
        }
        set
        {
            this.elementField = value;
        }
    }

    /// <remarks/>
    public string RecordID
    {
        get
        {
            return this.recordIDField;
        }
        set
        {
            this.recordIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "anyURI")]
    public string DocURL
    {
        get
        {
            return this.docURLField;
        }
        set
        {
            this.docURLField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime timeStamp
    {
        get
        {
            return this.timeStampField;
        }
        set
        {
            this.timeStampField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeStampSpecified
    {
        get
        {
            return this.timeStampFieldSpecified;
        }
        set
        {
            this.timeStampFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://services.sabre.com/STL/v01")]
public partial class ProblemInformation
{

    private SystemSpecificResults[] systemSpecificResultsField;

    private ErrorType typeField;

    private bool typeFieldSpecified;

    private System.DateTime timeStampField;

    private bool timeStampFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SystemSpecificResults")]
    public SystemSpecificResults[] SystemSpecificResults
    {
        get
        {
            return this.systemSpecificResultsField;
        }
        set
        {
            this.systemSpecificResultsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ErrorType type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool typeSpecified
    {
        get
        {
            return this.typeFieldSpecified;
        }
        set
        {
            this.typeFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime timeStamp
    {
        get
        {
            return this.timeStampField;
        }
        set
        {
            this.timeStampField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeStampSpecified
    {
        get
        {
            return this.timeStampFieldSpecified;
        }
        set
        {
            this.timeStampFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationResults))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://services.sabre.com/STL/v01")]
public partial class Results
{
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://services.sabre.com/STL/v01")]
public partial class ApplicationResults : Results
{

    private ProblemInformation[] successField;

    private ProblemInformation[] errorField;

    private ProblemInformation[] warningField;

    private CompletionCodes statusField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Success")]
    public ProblemInformation[] Success
    {
        get
        {
            return this.successField;
        }
        set
        {
            this.successField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Error")]
    public ProblemInformation[] Error
    {
        get
        {
            return this.errorField;
        }
        set
        {
            this.errorField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Warning")]
    public ProblemInformation[] Warning
    {
        get
        {
            return this.warningField;
        }
        set
        {
            this.warningField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public CompletionCodes status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://services.sabre.com/STL/v01")]
public partial class STL_Payload
{

    private ApplicationResults applicationResultsField;

    private string versionField;

    /// <remarks/>
    public ApplicationResults ApplicationResults
    {
        get
        {
            return this.applicationResultsField;
        }
        set
        {
            this.applicationResultsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ebxml.org/namespaces/messageHeader")]
public partial class To
{

    private PartyId[] partyIdField;

    private string roleField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PartyId")]
    public PartyId[] PartyId
    {
        get
        {
            return this.partyIdField;
        }
        set
        {
            this.partyIdField = value;
        }
    }

    /// <remarks/>
    public string Role
    {
        get
        {
            return this.roleField;
        }
        set
        {
            this.roleField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ebxml.org/namespaces/messageHeader")]
public partial class Service
{

    private string typeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ebxml.org/namespaces/messageHeader")]
public partial class MessageData
{

    private string messageIdField;

    private string timestampField;

    private string refToMessageIdField;

    private System.DateTime timeToLiveField;

    private bool timeToLiveFieldSpecified;

    private string timeoutField;

    /// <remarks/>
    public string MessageId
    {
        get
        {
            return this.messageIdField;
        }
        set
        {
            this.messageIdField = value;
        }
    }

    /// <remarks/>
    public string Timestamp
    {
        get
        {
            return this.timestampField;
        }
        set
        {
            this.timestampField = value;
        }
    }

    /// <remarks/>
    public string RefToMessageId
    {
        get
        {
            return this.refToMessageIdField;
        }
        set
        {
            this.refToMessageIdField = value;
        }
    }

    /// <remarks/>
    public System.DateTime TimeToLive
    {
        get
        {
            return this.timeToLiveField;
        }
        set
        {
            this.timeToLiveField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TimeToLiveSpecified
    {
        get
        {
            return this.timeToLiveFieldSpecified;
        }
        set
        {
            this.timeToLiveFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
    public string Timeout
    {
        get
        {
            return this.timeoutField;
        }
        set
        {
            this.timeoutField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ebxml.org/namespaces/messageHeader")]
public partial class Description
{

    private string langField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
    public string lang
    {
        get
        {
            return this.langField;
        }
        set
        {
            this.langField = value;
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/ws/2002/12/secext")]
[System.Xml.Serialization.XmlRootAttribute("Security", Namespace = "http://schemas.xmlsoap.org/ws/2002/12/secext", IsNullable = false)]
public partial class Security1 
{

    private SecurityUsernameToken usernameTokenField;

    private string sabreAthField;

    private string binarySecurityTokenField;

    /// <remarks/>
    public SecurityUsernameToken UsernameToken
    {
        get
        {
            return this.usernameTokenField;
        }
        set
        {
            this.usernameTokenField = value;
        }
    }

    /// <remarks/>
    public string SabreAth
    {
        get
        {
            return this.sabreAthField;
        }
        set
        {
            this.sabreAthField = value;
        }
    }

    /// <remarks/>
    public string BinarySecurityToken
    {
        get
        {
            return this.binarySecurityTokenField;
        }
        set
        {
            this.binarySecurityTokenField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/ws/2002/12/secext")]
public partial class SecurityUsernameToken
{

    private string usernameField;

    private string passwordField;

    private string[] newPasswordField;

    private string organizationField;

    private string domainField;

    /// <remarks/>
    public string Username
    {
        get
        {
            return this.usernameField;
        }
        set
        {
            this.usernameField = value;
        }
    }

    /// <remarks/>
    public string Password
    {
        get
        {
            return this.passwordField;
        }
        set
        {
            this.passwordField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NewPassword")]
    public string[] NewPassword
    {
        get
        {
            return this.newPasswordField;
        }
        set
        {
            this.newPasswordField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Organization
    {
        get
        {
            return this.organizationField;
        }
        set
        {
            this.organizationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Domain
    {
        get
        {
            return this.domainField;
        }
        set
        {
            this.domainField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
//[DataContract(Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]


public partial class OTA_AirAvailRQ
{

    private OTA_AirAvailRQOptionalQualifiers optionalQualifiersField;

    private OTA_AirAvailRQOriginDestinationInformation originDestinationInformationField;

    private bool returnHostCommandField;

    private bool returnHostCommandFieldSpecified;

    private System.DateTime timeStampField;

    private bool timeStampFieldSpecified;

    private string versionField;

    public OTA_AirAvailRQ()
    {
        this.versionField = "2.0.0";
    }

    /// <remarks/>
    public OTA_AirAvailRQOptionalQualifiers OptionalQualifiers
    {
        get
        {
            return this.optionalQualifiersField;
        }
        set
        {
            this.optionalQualifiersField = value;
        }
    }

    /// <remarks/>
    public OTA_AirAvailRQOriginDestinationInformation OriginDestinationInformation
    {
        get
        {
            return this.originDestinationInformationField;
        }
        set
        {
            this.originDestinationInformationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ReturnHostCommand
    {
        get
        {
            return this.returnHostCommandField;
        }
        set
        {
            this.returnHostCommandField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ReturnHostCommandSpecified
    {
        get
        {
            return this.returnHostCommandFieldSpecified;
        }
        set
        {
            this.returnHostCommandFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime TimeStamp
    {
        get
        {
            return this.timeStampField;
        }
        set
        {
            this.timeStampField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TimeStampSpecified
    {
        get
        {
            return this.timeStampFieldSpecified;
        }
        set
        {
            this.timeStampFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRQOptionalQualifiers
{

    private OTA_AirAvailRQOptionalQualifiersAdditionalAvailability additionalAvailabilityField;

    private OTA_AirAvailRQOptionalQualifiersFlightQualifiers flightQualifiersField;

    private OTA_AirAvailRQOptionalQualifiersTimeQualifiers timeQualifiersField;

    /// <remarks/>
    public OTA_AirAvailRQOptionalQualifiersAdditionalAvailability AdditionalAvailability
    {
        get
        {
            return this.additionalAvailabilityField;
        }
        set
        {
            this.additionalAvailabilityField = value;
        }
    }

    /// <remarks/>
    public OTA_AirAvailRQOptionalQualifiersFlightQualifiers FlightQualifiers
    {
        get
        {
            return this.flightQualifiersField;
        }
        set
        {
            this.flightQualifiersField = value;
        }
    }

    /// <remarks/>
    public OTA_AirAvailRQOptionalQualifiersTimeQualifiers TimeQualifiers
    {
        get
        {
            return this.timeQualifiersField;
        }
        set
        {
            this.timeQualifiersField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRQOptionalQualifiersAdditionalAvailability
{

    private string airExtrasField;

    private bool directAccessField;

    private bool directAccessFieldSpecified;

    private bool indField;

    private bool indFieldSpecified;

    private bool moveDownField;

    private bool moveDownFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string AirExtras
    {
        get
        {
            return this.airExtrasField;
        }
        set
        {
            this.airExtrasField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool DirectAccess
    {
        get
        {
            return this.directAccessField;
        }
        set
        {
            this.directAccessField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DirectAccessSpecified
    {
        get
        {
            return this.directAccessFieldSpecified;
        }
        set
        {
            this.directAccessFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Ind
    {
        get
        {
            return this.indField;
        }
        set
        {
            this.indField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool IndSpecified
    {
        get
        {
            return this.indFieldSpecified;
        }
        set
        {
            this.indFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool MoveDown
    {
        get
        {
            return this.moveDownField;
        }
        set
        {
            this.moveDownField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool MoveDownSpecified
    {
        get
        {
            return this.moveDownFieldSpecified;
        }
        set
        {
            this.moveDownFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRQOptionalQualifiersFlightQualifiers
{

    private OTA_AirAvailRQOptionalQualifiersFlightQualifiersVendorPrefs vendorPrefsField;

    private bool chartersField;

    private bool chartersFieldSpecified;

    private bool directOnlyField;

    private bool directOnlyFieldSpecified;

    private bool excludeCodesharesField;

    private bool excludeCodesharesFieldSpecified;

    private bool scanField;

    private bool scanFieldSpecified;

    /// <remarks/>
    public OTA_AirAvailRQOptionalQualifiersFlightQualifiersVendorPrefs VendorPrefs
    {
        get
        {
            return this.vendorPrefsField;
        }
        set
        {
            this.vendorPrefsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Charters
    {
        get
        {
            return this.chartersField;
        }
        set
        {
            this.chartersField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ChartersSpecified
    {
        get
        {
            return this.chartersFieldSpecified;
        }
        set
        {
            this.chartersFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool DirectOnly
    {
        get
        {
            return this.directOnlyField;
        }
        set
        {
            this.directOnlyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DirectOnlySpecified
    {
        get
        {
            return this.directOnlyFieldSpecified;
        }
        set
        {
            this.directOnlyFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ExcludeCodeshares
    {
        get
        {
            return this.excludeCodesharesField;
        }
        set
        {
            this.excludeCodesharesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ExcludeCodesharesSpecified
    {
        get
        {
            return this.excludeCodesharesFieldSpecified;
        }
        set
        {
            this.excludeCodesharesFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Scan
    {
        get
        {
            return this.scanField;
        }
        set
        {
            this.scanField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ScanSpecified
    {
        get
        {
            return this.scanFieldSpecified;
        }
        set
        {
            this.scanFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRQOptionalQualifiersFlightQualifiersVendorPrefs
{

    private OTA_AirAvailRQOptionalQualifiersFlightQualifiersVendorPrefsAirline[] airlineField;

    private bool directAccessField;

    private bool directAccessFieldSpecified;

    private bool excludeField;

    private bool excludeFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Airline")]
    public OTA_AirAvailRQOptionalQualifiersFlightQualifiersVendorPrefsAirline[] Airline
    {
        get
        {
            return this.airlineField;
        }
        set
        {
            this.airlineField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool DirectAccess
    {
        get
        {
            return this.directAccessField;
        }
        set
        {
            this.directAccessField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DirectAccessSpecified
    {
        get
        {
            return this.directAccessFieldSpecified;
        }
        set
        {
            this.directAccessFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Exclude
    {
        get
        {
            return this.excludeField;
        }
        set
        {
            this.excludeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ExcludeSpecified
    {
        get
        {
            return this.excludeFieldSpecified;
        }
        set
        {
            this.excludeFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRQOptionalQualifiersFlightQualifiersVendorPrefsAirline
{

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRQOptionalQualifiersTimeQualifiers
{

    private OTA_AirAvailRQOptionalQualifiersTimeQualifiersArrivalTime arrivalTimeField;

    private OTA_AirAvailRQOptionalQualifiersTimeQualifiersDepartureTime departureTimeField;

    /// <remarks/>
    public OTA_AirAvailRQOptionalQualifiersTimeQualifiersArrivalTime ArrivalTime
    {
        get
        {
            return this.arrivalTimeField;
        }
        set
        {
            this.arrivalTimeField = value;
        }
    }

    /// <remarks/>
    public OTA_AirAvailRQOptionalQualifiersTimeQualifiersDepartureTime DepartureTime
    {
        get
        {
            return this.departureTimeField;
        }
        set
        {
            this.departureTimeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRQOptionalQualifiersTimeQualifiersArrivalTime
{

    private string windowAfterField;

    private string windowBeforeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string WindowAfter
    {
        get
        {
            return this.windowAfterField;
        }
        set
        {
            this.windowAfterField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string WindowBefore
    {
        get
        {
            return this.windowBeforeField;
        }
        set
        {
            this.windowBeforeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRQOptionalQualifiersTimeQualifiersDepartureTime
{

    private string windowBeforeField;

    private string windowAfterField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string WindowBefore
    {
        get
        {
            return this.windowBeforeField;
        }
        set
        {
            this.windowBeforeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string WindowAfter
    {
        get
        {
            return this.windowAfterField;
        }
        set
        {
            this.windowAfterField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRQOriginDestinationInformation
{

    private OTA_AirAvailRQOriginDestinationInformationFlightSegment flightSegmentField;

    /// <remarks/>
    public OTA_AirAvailRQOriginDestinationInformationFlightSegment FlightSegment
    {
        get
        {
            return this.flightSegmentField;
        }
        set
        {
            this.flightSegmentField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRQOriginDestinationInformationFlightSegment
{

    private OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocations connectionLocationsField;

    private OTA_AirAvailRQOriginDestinationInformationFlightSegmentDestinationLocation destinationLocationField;

    private OTA_AirAvailRQOriginDestinationInformationFlightSegmentOriginLocation originLocationField;

    private string arrivalDateTimeField;

    private string departureDateTimeField;

    private string flightNumberField;

    private string numberInPartyField;

    private string resBookDesigCodeField;

    /// <remarks/>
    public OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocations ConnectionLocations
    {
        get
        {
            return this.connectionLocationsField;
        }
        set
        {
            this.connectionLocationsField = value;
        }
    }

    /// <remarks/>
    public OTA_AirAvailRQOriginDestinationInformationFlightSegmentDestinationLocation DestinationLocation
    {
        get
        {
            return this.destinationLocationField;
        }
        set
        {
            this.destinationLocationField = value;
        }
    }

    /// <remarks/>
    public OTA_AirAvailRQOriginDestinationInformationFlightSegmentOriginLocation OriginLocation
    {
        get
        {
            return this.originLocationField;
        }
        set
        {
            this.originLocationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ArrivalDateTime
    {
        get
        {
            return this.arrivalDateTimeField;
        }
        set
        {
            this.arrivalDateTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DepartureDateTime
    {
        get
        {
            return this.departureDateTimeField;
        }
        set
        {
            this.departureDateTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FlightNumber
    {
        get
        {
            return this.flightNumberField;
        }
        set
        {
            this.flightNumberField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NumberInParty
    {
        get
        {
            return this.numberInPartyField;
        }
        set
        {
            this.numberInPartyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ResBookDesigCode
    {
        get
        {
            return this.resBookDesigCodeField;
        }
        set
        {
            this.resBookDesigCodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocations
{

    private OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplay carrierSpecificDisplayField;

    private OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsConnectionLocation[] connectionLocationField;

    private OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsConnectTimeOverrides connectTimeOverridesField;

    /// <remarks/>
    public OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplay CarrierSpecificDisplay
    {
        get
        {
            return this.carrierSpecificDisplayField;
        }
        set
        {
            this.carrierSpecificDisplayField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ConnectionLocation")]
    public OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsConnectionLocation[] ConnectionLocation
    {
        get
        {
            return this.connectionLocationField;
        }
        set
        {
            this.connectionLocationField = value;
        }
    }

    /// <remarks/>
    public OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsConnectTimeOverrides ConnectTimeOverrides
    {
        get
        {
            return this.connectTimeOverridesField;
        }
        set
        {
            this.connectTimeOverridesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplay
{

    private OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegOne legOneField;

    private OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegThree legThreeField;

    private OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegTwo legTwoField;

    /// <remarks/>
    public OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegOne LegOne
    {
        get
        {
            return this.legOneField;
        }
        set
        {
            this.legOneField = value;
        }
    }

    /// <remarks/>
    public OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegThree LegThree
    {
        get
        {
            return this.legThreeField;
        }
        set
        {
            this.legThreeField = value;
        }
    }

    /// <remarks/>
    public OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegTwo LegTwo
    {
        get
        {
            return this.legTwoField;
        }
        set
        {
            this.legTwoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegOne
{

    private OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegOneVendorPrefs vendorPrefsField;

    /// <remarks/>
    public OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegOneVendorPrefs VendorPrefs
    {
        get
        {
            return this.vendorPrefsField;
        }
        set
        {
            this.vendorPrefsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegOneVendorPrefs
{

    private OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegOneVendorPrefsAirline[] airlineField;

    private bool excludeField;

    private bool excludeFieldSpecified;

    private bool excludeCodesharesField;

    private bool excludeCodesharesFieldSpecified;

    private bool anyField;

    private bool anyFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Airline")]
    public OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegOneVendorPrefsAirline[] Airline
    {
        get
        {
            return this.airlineField;
        }
        set
        {
            this.airlineField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Exclude
    {
        get
        {
            return this.excludeField;
        }
        set
        {
            this.excludeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ExcludeSpecified
    {
        get
        {
            return this.excludeFieldSpecified;
        }
        set
        {
            this.excludeFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ExcludeCodeshares
    {
        get
        {
            return this.excludeCodesharesField;
        }
        set
        {
            this.excludeCodesharesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ExcludeCodesharesSpecified
    {
        get
        {
            return this.excludeCodesharesFieldSpecified;
        }
        set
        {
            this.excludeCodesharesFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Any
    {
        get
        {
            return this.anyField;
        }
        set
        {
            this.anyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AnySpecified
    {
        get
        {
            return this.anyFieldSpecified;
        }
        set
        {
            this.anyFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegOneVendorPrefsAirline
{

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegThree
{

    private OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegThreeVendorPrefs vendorPrefsField;

    /// <remarks/>
    public OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegThreeVendorPrefs VendorPrefs
    {
        get
        {
            return this.vendorPrefsField;
        }
        set
        {
            this.vendorPrefsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegThreeVendorPrefs
{

    private OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegThreeVendorPrefsAirline[] airlineField;

    private bool excludeField;

    private bool excludeFieldSpecified;

    private bool excludeCodesharesField;

    private bool excludeCodesharesFieldSpecified;

    private bool anyField;

    private bool anyFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Airline")]
    public OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegThreeVendorPrefsAirline[] Airline
    {
        get
        {
            return this.airlineField;
        }
        set
        {
            this.airlineField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Exclude
    {
        get
        {
            return this.excludeField;
        }
        set
        {
            this.excludeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ExcludeSpecified
    {
        get
        {
            return this.excludeFieldSpecified;
        }
        set
        {
            this.excludeFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ExcludeCodeshares
    {
        get
        {
            return this.excludeCodesharesField;
        }
        set
        {
            this.excludeCodesharesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ExcludeCodesharesSpecified
    {
        get
        {
            return this.excludeCodesharesFieldSpecified;
        }
        set
        {
            this.excludeCodesharesFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Any
    {
        get
        {
            return this.anyField;
        }
        set
        {
            this.anyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AnySpecified
    {
        get
        {
            return this.anyFieldSpecified;
        }
        set
        {
            this.anyFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegThreeVendorPrefsAirline
{

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegTwo
{

    private OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegTwoVendorPrefs vendorPrefsField;

    /// <remarks/>
    public OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegTwoVendorPrefs VendorPrefs
    {
        get
        {
            return this.vendorPrefsField;
        }
        set
        {
            this.vendorPrefsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegTwoVendorPrefs
{

    private OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegTwoVendorPrefsAirline[] airlineField;

    private bool excludeField;

    private bool excludeFieldSpecified;

    private bool excludeCodesharesField;

    private bool excludeCodesharesFieldSpecified;

    private bool anyField;

    private bool anyFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Airline")]
    public OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegTwoVendorPrefsAirline[] Airline
    {
        get
        {
            return this.airlineField;
        }
        set
        {
            this.airlineField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Exclude
    {
        get
        {
            return this.excludeField;
        }
        set
        {
            this.excludeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ExcludeSpecified
    {
        get
        {
            return this.excludeFieldSpecified;
        }
        set
        {
            this.excludeFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ExcludeCodeshares
    {
        get
        {
            return this.excludeCodesharesField;
        }
        set
        {
            this.excludeCodesharesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ExcludeCodesharesSpecified
    {
        get
        {
            return this.excludeCodesharesFieldSpecified;
        }
        set
        {
            this.excludeCodesharesFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Any
    {
        get
        {
            return this.anyField;
        }
        set
        {
            this.anyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool AnySpecified
    {
        get
        {
            return this.anyFieldSpecified;
        }
        set
        {
            this.anyFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsCarrierSpecificDisplayLegTwoVendorPrefsAirline
{

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsConnectionLocation
{

    private string locationCodeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string LocationCode
    {
        get
        {
            return this.locationCodeField;
        }
        set
        {
            this.locationCodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRQOriginDestinationInformationFlightSegmentConnectionLocationsConnectTimeOverrides
{

    private string minField;

    private string maxField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Min
    {
        get
        {
            return this.minField;
        }
        set
        {
            this.minField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Max
    {
        get
        {
            return this.maxField;
        }
        set
        {
            this.maxField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRQOriginDestinationInformationFlightSegmentDestinationLocation
{

    private string locationCodeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string LocationCode
    {
        get
        {
            return this.locationCodeField;
        }
        set
        {
            this.locationCodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRQOriginDestinationInformationFlightSegmentOriginLocation
{

    private string locationCodeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string LocationCode
    {
        get
        {
            return this.locationCodeField;
        }
        set
        {
            this.locationCodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
//[DataContract(Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRS
{

    private ApplicationResults applicationResultsField;

    private OTA_AirAvailRSOriginDestinationOptions originDestinationOptionsField;

    private string versionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://services.sabre.com/STL/v01")]
    public ApplicationResults ApplicationResults
    {
        get
        {
            return this.applicationResultsField;
        }
        set
        {
            this.applicationResultsField = value;
        }
    }

    /// <remarks/>
    public OTA_AirAvailRSOriginDestinationOptions OriginDestinationOptions
    {
        get
        {
            return this.originDestinationOptionsField;
        }
        set
        {
            this.originDestinationOptionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRSOriginDestinationOptions
{

    private OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOption[] originDestinationOptionField;

    private string originTimeZoneField;

    private string destinationTimeZoneField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OriginDestinationOption")]
    public OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOption[] OriginDestinationOption
    {
        get
        {
            return this.originDestinationOptionField;
        }
        set
        {
            this.originDestinationOptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string OriginTimeZone
    {
        get
        {
            return this.originTimeZoneField;
        }
        set
        {
            this.originTimeZoneField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DestinationTimeZone
    {
        get
        {
            return this.destinationTimeZoneField;
        }
        set
        {
            this.destinationTimeZoneField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOption
{

    private OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegment[] flightSegmentField;

    private string rPHField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FlightSegment")]
    public OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegment[] FlightSegment
    {
        get
        {
            return this.flightSegmentField;
        }
        set
        {
            this.flightSegmentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RPH
    {
        get
        {
            return this.rPHField;
        }
        set
        {
            this.rPHField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegment
{

    private OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentBookingClassAvail[] bookingClassAvailField;

    private OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentDaysOfOperation daysOfOperationField;

    private OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentDestinationLocation destinationLocationField;

    private OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentDisclosureAirline disclosureAirlineField;

    private OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentEquipment equipmentField;

    private OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentFlightDetails flightDetailsField;

    private OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentMarketingAirline marketingAirlineField;

    private OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentMeal[] mealField;

    private OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentOperatingAirline operatingAirlineField;

    private OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentOriginLocation originLocationField;

    private string arrivalDateTimeField;

    private string connectionIndField;

    private string departureDateTimeField;

    private string dOT_IndField;

    private bool eTicketField;

    private bool eTicketFieldSpecified;

    private string flightNumberField;

    private string rPHField;

    private bool smokingAllowedField;

    private bool smokingAllowedFieldSpecified;

    private string stopQuantityField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BookingClassAvail")]
    public OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentBookingClassAvail[] BookingClassAvail
    {
        get
        {
            return this.bookingClassAvailField;
        }
        set
        {
            this.bookingClassAvailField = value;
        }
    }

    /// <remarks/>
    public OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentDaysOfOperation DaysOfOperation
    {
        get
        {
            return this.daysOfOperationField;
        }
        set
        {
            this.daysOfOperationField = value;
        }
    }

    /// <remarks/>
    public OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentDestinationLocation DestinationLocation
    {
        get
        {
            return this.destinationLocationField;
        }
        set
        {
            this.destinationLocationField = value;
        }
    }

    /// <remarks/>
    public OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentDisclosureAirline DisclosureAirline
    {
        get
        {
            return this.disclosureAirlineField;
        }
        set
        {
            this.disclosureAirlineField = value;
        }
    }

    /// <remarks/>
    public OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentEquipment Equipment
    {
        get
        {
            return this.equipmentField;
        }
        set
        {
            this.equipmentField = value;
        }
    }

    /// <remarks/>
    public OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentFlightDetails FlightDetails
    {
        get
        {
            return this.flightDetailsField;
        }
        set
        {
            this.flightDetailsField = value;
        }
    }

    /// <remarks/>
    public OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentMarketingAirline MarketingAirline
    {
        get
        {
            return this.marketingAirlineField;
        }
        set
        {
            this.marketingAirlineField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Meal")]
    public OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentMeal[] Meal
    {
        get
        {
            return this.mealField;
        }
        set
        {
            this.mealField = value;
        }
    }

    /// <remarks/>
    public OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentOperatingAirline OperatingAirline
    {
        get
        {
            return this.operatingAirlineField;
        }
        set
        {
            this.operatingAirlineField = value;
        }
    }

    /// <remarks/>
    public OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentOriginLocation OriginLocation
    {
        get
        {
            return this.originLocationField;
        }
        set
        {
            this.originLocationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ArrivalDateTime
    {
        get
        {
            return this.arrivalDateTimeField;
        }
        set
        {
            this.arrivalDateTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ConnectionInd
    {
        get
        {
            return this.connectionIndField;
        }
        set
        {
            this.connectionIndField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DepartureDateTime
    {
        get
        {
            return this.departureDateTimeField;
        }
        set
        {
            this.departureDateTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DOT_Ind
    {
        get
        {
            return this.dOT_IndField;
        }
        set
        {
            this.dOT_IndField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool eTicket
    {
        get
        {
            return this.eTicketField;
        }
        set
        {
            this.eTicketField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool eTicketSpecified
    {
        get
        {
            return this.eTicketFieldSpecified;
        }
        set
        {
            this.eTicketFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FlightNumber
    {
        get
        {
            return this.flightNumberField;
        }
        set
        {
            this.flightNumberField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RPH
    {
        get
        {
            return this.rPHField;
        }
        set
        {
            this.rPHField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool SmokingAllowed
    {
        get
        {
            return this.smokingAllowedField;
        }
        set
        {
            this.smokingAllowedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SmokingAllowedSpecified
    {
        get
        {
            return this.smokingAllowedFieldSpecified;
        }
        set
        {
            this.smokingAllowedFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string StopQuantity
    {
        get
        {
            return this.stopQuantityField;
        }
        set
        {
            this.stopQuantityField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentBookingClassAvail
{

    private string availabilityField;

    private string brandIDField;

    private string resBookDesigCodeField;

    private string rPHField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Availability
    {
        get
        {
            return this.availabilityField;
        }
        set
        {
            this.availabilityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string BrandID
    {
        get
        {
            return this.brandIDField;
        }
        set
        {
            this.brandIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ResBookDesigCode
    {
        get
        {
            return this.resBookDesigCodeField;
        }
        set
        {
            this.resBookDesigCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RPH
    {
        get
        {
            return this.rPHField;
        }
        set
        {
            this.rPHField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentDaysOfOperation
{

    private OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentDaysOfOperationOperationSchedule operationScheduleField;

    /// <remarks/>
    public OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentDaysOfOperationOperationSchedule OperationSchedule
    {
        get
        {
            return this.operationScheduleField;
        }
        set
        {
            this.operationScheduleField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentDaysOfOperationOperationSchedule
{

    private OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentDaysOfOperationOperationScheduleOperationTimes operationTimesField;

    /// <remarks/>
    public OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentDaysOfOperationOperationScheduleOperationTimes OperationTimes
    {
        get
        {
            return this.operationTimesField;
        }
        set
        {
            this.operationTimesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentDaysOfOperationOperationScheduleOperationTimes
{

    private OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentDaysOfOperationOperationScheduleOperationTimesOperationTime operationTimeField;

    /// <remarks/>
    public OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentDaysOfOperationOperationScheduleOperationTimesOperationTime OperationTime
    {
        get
        {
            return this.operationTimeField;
        }
        set
        {
            this.operationTimeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentDaysOfOperationOperationScheduleOperationTimesOperationTime
{

    private bool friField;

    private bool friFieldSpecified;

    private bool monField;

    private bool monFieldSpecified;

    private bool satField;

    private bool satFieldSpecified;

    private bool sunField;

    private bool sunFieldSpecified;

    private bool thurField;

    private bool thurFieldSpecified;

    private bool tueField;

    private bool tueFieldSpecified;

    private bool wedsField;

    private bool wedsFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Fri
    {
        get
        {
            return this.friField;
        }
        set
        {
            this.friField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FriSpecified
    {
        get
        {
            return this.friFieldSpecified;
        }
        set
        {
            this.friFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Mon
    {
        get
        {
            return this.monField;
        }
        set
        {
            this.monField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool MonSpecified
    {
        get
        {
            return this.monFieldSpecified;
        }
        set
        {
            this.monFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Sat
    {
        get
        {
            return this.satField;
        }
        set
        {
            this.satField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SatSpecified
    {
        get
        {
            return this.satFieldSpecified;
        }
        set
        {
            this.satFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Sun
    {
        get
        {
            return this.sunField;
        }
        set
        {
            this.sunField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SunSpecified
    {
        get
        {
            return this.sunFieldSpecified;
        }
        set
        {
            this.sunFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Thur
    {
        get
        {
            return this.thurField;
        }
        set
        {
            this.thurField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ThurSpecified
    {
        get
        {
            return this.thurFieldSpecified;
        }
        set
        {
            this.thurFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Tue
    {
        get
        {
            return this.tueField;
        }
        set
        {
            this.tueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TueSpecified
    {
        get
        {
            return this.tueFieldSpecified;
        }
        set
        {
            this.tueFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Weds
    {
        get
        {
            return this.wedsField;
        }
        set
        {
            this.wedsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool WedsSpecified
    {
        get
        {
            return this.wedsFieldSpecified;
        }
        set
        {
            this.wedsFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentDestinationLocation
{

    private string locationCodeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string LocationCode
    {
        get
        {
            return this.locationCodeField;
        }
        set
        {
            this.locationCodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentDisclosureAirline
{

    private string[] textField;

    private string codeField;

    private string companyShortNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Text")]
    public string[] Text
    {
        get
        {
            return this.textField;
        }
        set
        {
            this.textField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CompanyShortName
    {
        get
        {
            return this.companyShortNameField;
        }
        set
        {
            this.companyShortNameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentEquipment
{

    private string airEquipTypeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string AirEquipType
    {
        get
        {
            return this.airEquipTypeField;
        }
        set
        {
            this.airEquipTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentFlightDetails
{

    private string[] textField;

    private bool canceledField;

    private bool canceledFieldSpecified;

    private bool charterField;

    private bool charterFieldSpecified;

    private string codeshareBlockDisplayField;

    private string discontinueDateField;

    private string effectiveDateField;

    private string groundTimeField;

    private string totalTravelTimeField;

    private string trafficRestrictionCodeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Text")]
    public string[] Text
    {
        get
        {
            return this.textField;
        }
        set
        {
            this.textField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Canceled
    {
        get
        {
            return this.canceledField;
        }
        set
        {
            this.canceledField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CanceledSpecified
    {
        get
        {
            return this.canceledFieldSpecified;
        }
        set
        {
            this.canceledFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Charter
    {
        get
        {
            return this.charterField;
        }
        set
        {
            this.charterField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CharterSpecified
    {
        get
        {
            return this.charterFieldSpecified;
        }
        set
        {
            this.charterFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CodeshareBlockDisplay
    {
        get
        {
            return this.codeshareBlockDisplayField;
        }
        set
        {
            this.codeshareBlockDisplayField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DiscontinueDate
    {
        get
        {
            return this.discontinueDateField;
        }
        set
        {
            this.discontinueDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string EffectiveDate
    {
        get
        {
            return this.effectiveDateField;
        }
        set
        {
            this.effectiveDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string GroundTime
    {
        get
        {
            return this.groundTimeField;
        }
        set
        {
            this.groundTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TotalTravelTime
    {
        get
        {
            return this.totalTravelTimeField;
        }
        set
        {
            this.totalTravelTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TrafficRestrictionCode
    {
        get
        {
            return this.trafficRestrictionCodeField;
        }
        set
        {
            this.trafficRestrictionCodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentMarketingAirline
{

    private string codeField;

    private string flightNumberField;

    private string participationLevelField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FlightNumber
    {
        get
        {
            return this.flightNumberField;
        }
        set
        {
            this.flightNumberField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ParticipationLevel
    {
        get
        {
            return this.participationLevelField;
        }
        set
        {
            this.participationLevelField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentMeal
{

    private string mealCodeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MealCode
    {
        get
        {
            return this.mealCodeField;
        }
        set
        {
            this.mealCodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentOperatingAirline
{

    private string codeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.sabre.com/sabreXML/2011/10")]
public partial class OTA_AirAvailRSOriginDestinationOptionsOriginDestinationOptionFlightSegmentOriginLocation
{

    private string locationCodeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string LocationCode
    {
        get
        {
            return this.locationCodeField;
        }
        set
        {
            this.locationCodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
public delegate void OTA_AirAvailRQCompletedEventHandler(object sender, OTA_AirAvailRQCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class OTA_AirAvailRQCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal OTA_AirAvailRQCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public OTA_AirAvailRS Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((OTA_AirAvailRS)(this.results[0]));
        }
    }
}

#pragma warning restore 1591
