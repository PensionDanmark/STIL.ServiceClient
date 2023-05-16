namespace STIL.Entities.VEU.HentOptagedePladser
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ipl.stil.dk/services/veu/hentoptagedepladser/v1")]
    public class HentOptagedePladserResponseMessage {
        
        private HentOptagedePladserResponse hentOptagedePladserResponseField;
        
    
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.veu.stil.dk/hentudbud/webservice/hentoptagedepladser", Order=0)]
        public HentOptagedePladserResponse HentOptagedePladserResponse {
            get => hentOptagedePladserResponseField;
            set => hentOptagedePladserResponseField = value;
        }
        

    }
}