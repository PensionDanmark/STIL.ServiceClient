namespace STIL.Entities.VEU.HentOptagedePladser
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ipl.stil.dk/services/veu/hentoptagedepladser/v1")]
    public class HentOptagedePladserRequestMessage {
        
        private HentOptagedePladserRequest hentOptagedePladserRequestField;
        
    
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.veu.stil.dk/hentudbud/webservice/hentoptagedepladser", Order=0)]
        public HentOptagedePladserRequest HentOptagedePladserRequest {
            get => hentOptagedePladserRequestField;
            set => hentOptagedePladserRequestField = value;
        }

    }
}