namespace STIL.Entities.VEU.HentOptagedePladser
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.veu.stil.dk/hentudbud/webservice/hentoptagedepladser")]
    public class HentOptagedePladserResponse : ResponseType {
        
        private System.DateTime behandlingstidspunktField;
        
        private HoldListe[] holdListeField;
        
    
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.DateTime Behandlingstidspunkt {
            get => behandlingstidspunktField;
            set => behandlingstidspunktField = value;
        }
        
    
        [System.Xml.Serialization.XmlElementAttribute("HoldListe", Order=1)]
        public HoldListe[] HoldListe {
            get => holdListeField;
            set => holdListeField = value;
        }
    }
}