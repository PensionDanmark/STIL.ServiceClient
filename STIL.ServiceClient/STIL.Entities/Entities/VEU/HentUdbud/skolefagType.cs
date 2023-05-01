namespace STIL.Entities.VEU.HentUdbud
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
    public partial class skolefagType
    {
        
        private string skolefagKodeField;
        
        private string niveauField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string SkolefagKode
        {
            get
            {
                return this.skolefagKodeField;
            }
            set
            {
                this.skolefagKodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Niveau
        {
            get
            {
                return this.niveauField;
            }
            set
            {
                this.niveauField = value;
            }
        }
    }
}