namespace STIL.Entities.VEU.HentUdbud
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
    public partial class skoleType
    {
        
        private string dsnrField;
        
        private string navnField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Dsnr
        {
            get
            {
                return this.dsnrField;
            }
            set
            {
                this.dsnrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Navn
        {
            get
            {
                return this.navnField;
            }
            set
            {
                this.navnField = value;
            }
        }
    }
}