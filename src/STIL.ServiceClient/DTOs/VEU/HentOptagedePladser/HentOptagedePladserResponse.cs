namespace STIL.ServiceClient.DTOs.VEU.HentOptagedePladser
{
    /// <summary>
    /// HentOptagedePladserResponse.
    /// </summary>
    [System.SerializableAttribute]
    [System.Xml.Serialization.XmlRoot(ElementName = "HentOptagedePladserResponse", Namespace = "http://ipl.stil.dk/services/veu/hentoptagedepladser/v1")]
    public class HentOptagedePladserResponse
    {
        /// <summary>
        /// Identifier.
        /// </summary>
        public Identifier Identifier;

        /// <summary>
        /// CorrelationId.
        /// </summary>
        public string CorrelationID;

        /// <summary>
        /// Message.
        /// </summary>
        public HentOptagedePladserResponseMessage Message;

        /// <summary>
        /// Initializes a new instance of the <see cref="HentOptagedePladserResponse"/> class.
        /// </summary>
        public HentOptagedePladserResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HentOptagedePladserResponse"/> class.
        /// </summary>
        /// <param name="Identifier">The identifier.</param>
        /// <param name="CorrelationID">The correlationId.</param>
        /// <param name="Message">The message.</param>
        public HentOptagedePladserResponse(Identifier Identifier, string CorrelationID, HentOptagedePladserResponseMessage Message)
        {
            this.Identifier = Identifier;
            this.CorrelationID = CorrelationID;
            this.Message = Message;
        }
    }
}