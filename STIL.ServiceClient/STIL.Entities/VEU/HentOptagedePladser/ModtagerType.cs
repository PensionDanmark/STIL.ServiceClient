namespace STIL.Entities.VEU.HentOptagedePladser
{
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.veu.stil.dk/hentudbud/webservice/commontypes")]
    public class ModtagerType {
        
        private string modtagerSystemIdField;
        
        private string modtagerSystemTransaktionsIDField;
        
    
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ModtagerSystemId {
            get => modtagerSystemIdField;
            set => modtagerSystemIdField = value;
        }
        
    
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ModtagerSystemTransaktionsID {
            get => modtagerSystemTransaktionsIDField;
            set => modtagerSystemTransaktionsIDField = value;
        }

    }
}