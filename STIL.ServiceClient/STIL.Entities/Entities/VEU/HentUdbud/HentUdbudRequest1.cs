namespace STIL.Entities.VEU.HentUdbud
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
    public partial class HentUdbudRequest1 : RequestType
    {
        
        private IndholdRequestType indholdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public IndholdRequestType Indhold
        {
            get
            {
                return this.indholdField;
            }
            set
            {
                this.indholdField = value;
            }
        }
    }
}