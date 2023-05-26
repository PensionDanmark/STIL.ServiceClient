namespace STIL.ServiceClient.DTOs.VEU.HentOptagedePladser
{
    /// <summary>
    /// HentOptagedePladserRequestMessage.
    /// </summary>
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/hentoptagedepladser/v1")]
    public class HentOptagedePladserRequestMessage
    {
        /// <summary>
        /// The hent optagede pladser request field.
        /// </summary>
        private HentOptagedePladserRequest1 hentOptagedePladserRequestField;

        /// <summary>
        /// Gets or sets the <see cref="HentOptagedePladserRequest"/> value.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentoptagedepladser", Order = 0)]
        public HentOptagedePladserRequest1 HentOptagedePladserRequest
        {
            get => hentOptagedePladserRequestField;
            set => hentOptagedePladserRequestField = value;
        }
    }
}