namespace STIL.Entities.VEU.HentTilmeldingerVeuInteressenter
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0")]
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
    }
}