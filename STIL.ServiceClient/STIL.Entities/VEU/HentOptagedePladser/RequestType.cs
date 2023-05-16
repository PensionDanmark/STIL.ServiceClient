namespace STIL.Entities.VEU.HentOptagedePladser
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.veu.stil.dk/hentudbud/webservice/commontypes")]
    public abstract class RequestType {
        
        private ModtagerType modtagerField;
        
    
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ModtagerType Modtager {
            get => modtagerField;
            set => modtagerField = value;
        }
        

    }
}