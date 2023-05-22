namespace STIL.Entities.VEU.HentOptagedePladser
{
    /// <summary>
    /// HentOptagedePladserResponse1.
    /// </summary>
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentoptagedepladser")]
    public class HentOptagedePladserResponse1 : ResponseType
    {
        private System.DateTime behandlingstidspunktField;
        private HoldListe[] holdListeField;

        /// <summary>
        /// Gets or sets the <see cref="Behandlingstidspunkt"/> value.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public System.DateTime Behandlingstidspunkt
        {
            get => behandlingstidspunktField;
            set => behandlingstidspunktField = value;
        }

        /// <summary>
        /// Gets or sets the <see cref="HoldListe"/> value.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("HoldListe", Order = 1)]
        public HoldListe[] HoldListe
        {
            get => holdListeField;
            set => holdListeField = value;
        }
    }
}