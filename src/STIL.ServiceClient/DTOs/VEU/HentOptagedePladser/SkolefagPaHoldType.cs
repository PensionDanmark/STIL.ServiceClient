namespace STIL.ServiceClient.DTOs.VEU.HentOptagedePladser
{
    /// <summary>
    /// SkolefagPaHoldType.
    /// </summary>
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentoptagedepladser")]
    public class SkolefagPaHoldType
    {
        /// <summary>
        /// The skolefag kode field.
        /// </summary>
        private string skolefagKodeField;

        /// <summary>
        /// The niveau field.
        /// </summary>
        private string niveauField;

        /// <summary>
        /// The fag plads liste field.
        /// </summary>
        private FagPladsType[] fagPladsListeField;

        /// <summary>
        /// Gets or sets the <see cref="SkolefagKode"/> value.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string SkolefagKode
        {
            get => skolefagKodeField;
            set => skolefagKodeField = value;
        }

        /// <summary>
        /// Gets or sets the <see cref="Niveau"/> value.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Niveau
        {
            get => niveauField;
            set => niveauField = value;
        }

        /// <summary>
        /// Gets or sets the <see cref="FagPladsType"/> value.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("FagPladsListe", Order = 2)]
        public FagPladsType[] FagPladsListe
        {
            get => fagPladsListeField;
            set => fagPladsListeField = value;
        }
    }
}