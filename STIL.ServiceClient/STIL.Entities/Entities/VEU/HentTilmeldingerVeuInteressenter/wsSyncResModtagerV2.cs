namespace STIL.Entities.Entities.VEU.HentTilmeldingerVeuInteressenter;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThrough()]
[System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/common")]
public partial class wsSyncResModtagerV2
{

    private string modtagerSystemIDField;

    private string modtagerSystemTransaktionsIDField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public string ModtagerSystemID
    {
        get
        {
            return modtagerSystemIDField;
        }
        set
        {
            modtagerSystemIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public string ModtagerSystemTransaktionsID
    {
        get
        {
            return modtagerSystemTransaktionsIDField;
        }
        set
        {
            modtagerSystemTransaktionsIDField = value;
        }
    }
}