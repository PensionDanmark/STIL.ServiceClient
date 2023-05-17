namespace STIL.Entities.VEU.HentOptagedePladser
{
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.veu.stil.dk/hentudbud/webservice/hentoptagedepladser")]
    public class HentOptagedePladserRequest1 : RequestType
    {
        private string[] aktiGUIDListeField;

        [System.Xml.Serialization.XmlElementAttribute("AktiGUIDListe", Order = 0)]
        public string[] AktiGUIDListe
        {
            get => aktiGUIDListeField;
            set => aktiGUIDListeField = value;
        }
    }
}