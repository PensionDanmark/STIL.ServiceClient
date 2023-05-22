namespace STIL.Entities.VEU.HentOptagedePladser
{
    /// <summary>
    /// HentOptagedePladserRequest.
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.Xml.Serialization.XmlRoot(ElementName = "HentOptagedePladserRequest", Namespace = "http://ipl.stil.dk/services/veu/hentoptagedepladser/v1")]
    public class HentOptagedePladserRequest
    {
        /// <summary>
        /// Identifier.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Identifier Identifier;

        /// <summary>
        /// Message.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public HentOptagedePladserRequestMessage Message;

        /// <summary>
        /// Initializes a new instance of the <see cref="HentOptagedePladserRequest"/> class.
        /// </summary>
        public HentOptagedePladserRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HentOptagedePladserRequest"/> class.
        /// </summary>
        /// <param name="Identifier">The identifier.</param>
        /// <param name="Message">The message.</param>
        public HentOptagedePladserRequest(Identifier Identifier, HentOptagedePladserRequestMessage Message)
        {
            this.Identifier = Identifier;
            this.Message = Message;
        }
    }
}