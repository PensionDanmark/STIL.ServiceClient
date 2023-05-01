namespace STIL.Entities.VEU.HentUdbud
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.veu.stil.dk/hentudbud/webservice/commontypes")]
    public abstract partial class ResponseType
    {
        
        private ModtagerType modtagerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ModtagerType Modtager
        {
            get
            {
                return this.modtagerField;
            }
            set
            {
                this.modtagerField = value;
            }
        }
    }
}