namespace STIL.Entities.Entities.VEU.HentTilmeldingerVeuInteressenter;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThrough()]
[System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/skolefagHoldplace" +
                                                     "ring")]
public partial class skolefagType
{

    private string skolefagskodeField;

    private string niveauField;

    private string betegnelseField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public string Skolefagskode
    {
        get
        {
            return skolefagskodeField;
        }
        set
        {
            skolefagskodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string Niveau
    {
        get
        {
            return niveauField;
        }
        set
        {
            niveauField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 2)]
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
}