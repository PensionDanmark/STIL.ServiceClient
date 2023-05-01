namespace STIL.Entities.Entities.VEU.HentTilmeldingerVeuInteressenter;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThrough()]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0")]
public partial class Identifier
{

    private string systemNameField;

    private string systemTransactionIDField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public string SystemName
    {
        get
        {
            return systemNameField;
        }
        set
        {
            systemNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string SystemTransactionID
    {
        get
        {
            return systemTransactionIDField;
        }
        set
        {
            systemTransactionIDField = value;
        }
    }
}