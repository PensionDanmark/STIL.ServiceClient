namespace STIL.Entities.Entities.VEU.HentTilmeldingerVeuInteressenter;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThrough()]
[System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/tilmelding")]
public partial class holdType
{

    private string betegnelseField;

    private string kviknummerField;

    private string uddannelsestypeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public string Betegnelse
    {
        get
        {
            return betegnelseField;
        }
        set
        {
            betegnelseField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string Kviknummer
    {
        get
        {
            return kviknummerField;
        }
        set
        {
            kviknummerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 2)]
    public string Uddannelsestype
    {
        get
        {
            return uddannelsestypeField;
        }
        set
        {
            uddannelsestypeField = value;
        }
    }
}