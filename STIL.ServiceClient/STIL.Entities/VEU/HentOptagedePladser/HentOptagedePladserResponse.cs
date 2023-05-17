namespace STIL.Entities.VEU.HentOptagedePladser
{
    [System.SerializableAttribute]
    [System.Xml.Serialization.XmlRoot(ElementName = "HentOptagedePladserResponse", Namespace = "http://ipl.stil.dk/services/veu/hentoptagedepladser/v1")]
    public class HentOptagedePladserResponse
    {
        public Identifier Identifier;
        public string CorrelationID;
        public HentOptagedePladserResponseMessage Message;

        public HentOptagedePladserResponse()
        {
        }

        public HentOptagedePladserResponse(Identifier Identifier, string CorrelationID, HentOptagedePladserResponseMessage Message)
        {
            this.Identifier = Identifier;
            this.CorrelationID = CorrelationID;
            this.Message = Message;
        }
    }
}