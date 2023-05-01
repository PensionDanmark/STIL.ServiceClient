namespace STIL.Entities.VEU.HentTilmeldingerVeuInteressenter
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0")]
    public partial class hentTilmeldingerResponse
    {

        private Identifier identifierField;

        private string correlationIDField;

        private hentTilmeldingerResponseMessage messageField;

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
        public string CorrelationID
        {
            get
            {
                return correlationIDField;
            }
            set
            {
                correlationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 2)]
        public hentTilmeldingerResponseMessage Message
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