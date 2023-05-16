namespace STIL.Entities.VEU.HentOptagedePladser
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.veu.stil.dk/hentudbud/webservice/hentoptagedepladser")]
    public class HentOptagedePladserRequest : RequestType {
        
        private string[] aktiGUIDListeField;
        
    
        [System.Xml.Serialization.XmlElementAttribute("AktiGUIDListe", Order=0)]
        public string[] AktiGUIDListe {
            get => aktiGUIDListeField;
            set => aktiGUIDListeField = value;
        }
    }
}