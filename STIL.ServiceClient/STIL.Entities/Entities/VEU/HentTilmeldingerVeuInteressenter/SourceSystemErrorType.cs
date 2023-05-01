namespace STIL.Entities.Entities.VEU.HentTilmeldingerVeuInteressenter;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThrough()]
[System.Xml.Serialization.XmlType(Namespace = "http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0")]
public partial class SourceSystemErrorType
{

    private string sourceSystemNameField;

    private string errorCodeField;

    private string detailsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public string SourceSystemName
    {
        get
        {
            return sourceSystemNameField;
        }
        set
        {
            sourceSystemNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string ErrorCode
    {
        get
        {
            return errorCodeField;
        }
        set
        {
            errorCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public string Details
    {
        get
        {
            return detailsField;
        }
        set
        {
            detailsField = value;
        }
    }
}