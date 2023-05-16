namespace STIL.Entities.VEU.HentOptagedePladser
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/hentoptagedepladser/v1")]
    public class Identifier {
        
        private string systemNameField;
        
        private string systemTransactionIDField;
        
    
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string SystemName {
            get => systemNameField;
            set => systemNameField = value;
        }
        
    
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string SystemTransactionID {
            get => systemTransactionIDField;
            set => systemTransactionIDField = value;
        }
        

    }
}