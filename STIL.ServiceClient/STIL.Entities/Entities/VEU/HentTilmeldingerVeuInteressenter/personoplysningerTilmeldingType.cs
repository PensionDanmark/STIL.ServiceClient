namespace STIL.Entities.Entities.VEU.HentTilmeldingerVeuInteressenter;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThrough()]
[System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger/tilmelding")]
public partial class personoplysningerTilmeldingType
{

    private string arbejderSomField;

    private enumJN loenUnderKursusField;

    private bool loenUnderKursusFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public string ArbejderSom
    {
        get
        {
            return arbejderSomField;
        }
        set
        {
            arbejderSomField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public enumJN LoenUnderKursus
    {
        get
        {
            return loenUnderKursusField;
        }
        set
        {
            loenUnderKursusField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnore()]
    public bool LoenUnderKursusSpecified
    {
        get
        {
            return loenUnderKursusFieldSpecified;
        }
        set
        {
            loenUnderKursusFieldSpecified = value;
        }
    }
}