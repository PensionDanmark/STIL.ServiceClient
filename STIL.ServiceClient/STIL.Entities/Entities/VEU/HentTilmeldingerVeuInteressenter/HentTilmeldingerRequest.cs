using System.Xml.Serialization;

namespace STIL.Entities.Entities.VEU.HentTilmeldingerVeuInteressenter;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.Diagnostics.DebuggerStepThrough()]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0")]
[XmlRoot(Namespace = "http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0")]
public partial class HentTilmeldingerRequest
{

    private Identifier identifierField;

    private HentTilmeldingerRequestMessage messageField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 0)]
    public Identifier Identifier
    {
        get
        {
            return identifierField;
        }
        set
        {
            identifierField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElement(Order = 1)]
    public HentTilmeldingerRequestMessage Message
    {
        get
        {
            return messageField;
        }
        set
        {
            messageField = value;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.veu.stil.dk/tilmelding/ws/syncskole/henttilmeldinger")]
    public partial class hentTilmeldingerRequest
    {

        private hentTilmeldingerReqIndhold indholdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public hentTilmeldingerReqIndhold Indhold
        {
            get
            {
                return indholdField;
            }
            set
            {
                indholdField = value;
            }
        }
    }
}