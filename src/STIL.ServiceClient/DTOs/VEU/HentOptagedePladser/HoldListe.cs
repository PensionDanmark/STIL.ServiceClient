namespace STIL.Entities.VEU.HentOptagedePladser
{
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentoptagedepladser")]
    public class HoldListe
    {
        private string aktiGUIDField;
        private HoldPladsType[] holdPladsListeField;
        private SkolefagPaHoldType[] skolefagPaHoldListeField;

        /// <summary>
        /// Gets or sets the <see cref="AktiGUID"/> value.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string AktiGUID
        {
            get => aktiGUIDField;
            set => aktiGUIDField = value;
        }

        /// <summary>
        /// Gets or sets the <see cref="HoldPladsListe"/> value.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("HoldPladsListe", Order = 1)]
        public HoldPladsType[] HoldPladsListe
        {
            get => holdPladsListeField;
            set => holdPladsListeField = value;
        }

        /// <summary>
        /// Gets or sets the <see cref="SkolefagPaHoldType"/> value.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("SkolefagPaHoldListe", Order = 2)]
        public SkolefagPaHoldType[] SkolefagPaHoldListe
        {
            get => skolefagPaHoldListeField;
            set => skolefagPaHoldListeField = value;
        }
    }
}