namespace STIL.Entities.VEU.HentOptagedePladser
{
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentoptagedepladser")]
    public class SkolefagPaHoldType
    {
        private string skolefagKodeField;
        private string niveauField;
        private FagPladsType[] fagPladsListeField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string SkolefagKode
        {
            get => skolefagKodeField;
            set => skolefagKodeField = value;
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Niveau
        {
            get => niveauField;
            set => niveauField = value;
        }

        [System.Xml.Serialization.XmlElementAttribute("FagPladsListe", Order = 2)]
        public FagPladsType[] FagPladsListe
        {
            get => fagPladsListeField;
            set => fagPladsListeField = value;
        }
    }
}