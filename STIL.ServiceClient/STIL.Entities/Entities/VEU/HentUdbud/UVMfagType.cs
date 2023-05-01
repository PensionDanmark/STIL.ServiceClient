namespace STIL.Entities.VEU.HentUdbud
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
    public partial class UVMfagType
    {
        
        private string uVMfagKodeField;
        
        private string niveauField;
        
        private string betegnelseField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string UVMfagKode
        {
            get
            {
                return this.uVMfagKodeField;
            }
            set
            {
                this.uVMfagKodeField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Betegnelse
        {
            get
            {
                return this.betegnelseField;
            }
            set
            {
                this.betegnelseField = value;
            }
        }
    }
}