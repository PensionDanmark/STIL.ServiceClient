namespace STIL.Entities.VEU.HentUdbud
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.veu.stil.dk/hentudbud/webservice/commontypes")]
    public partial class ModtagerType
    {
        
        private string modtagerSystemIdField;
        
        private string modtagerSystemTransaktionsIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ModtagerSystemId
        {
            get
            {
                return this.modtagerSystemIdField;
            }
            set
            {
                this.modtagerSystemIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ModtagerSystemTransaktionsID
        {
            get
            {
                return this.modtagerSystemTransaktionsIDField;
            }
            set
            {
                this.modtagerSystemTransaktionsIDField = value;
            }
        }
    }
}