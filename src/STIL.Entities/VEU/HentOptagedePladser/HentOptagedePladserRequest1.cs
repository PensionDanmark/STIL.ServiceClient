namespace STIL.Entities.VEU.HentOptagedePladser
{
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.Xml.Serialization.XmlRoot(ElementName = "HentOptagedePladserRequest", Namespace = "http://ipl.stil.dk/services/veu/hentoptagedepladser/v1")]
    public class HentOptagedePladserRequest
    {
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Identifier Identifier;

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public HentOptagedePladserRequestMessage Message;

        public HentOptagedePladserRequest()
        {
        }

        public HentOptagedePladserRequest(Identifier Identifier, HentOptagedePladserRequestMessage Message)
        {
            this.Identifier = Identifier;
            this.Message = Message;
        }
    }
}