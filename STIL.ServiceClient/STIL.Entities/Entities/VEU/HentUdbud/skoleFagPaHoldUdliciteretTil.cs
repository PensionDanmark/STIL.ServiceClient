namespace STIL.Entities.VEU.HentUdbud
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
    public partial class skoleFagPaHoldUdliciteretTil
    {
        
        private string cVRnrField;
        
        private string pnummerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string CVRnr
        {
            get
            {
                return this.cVRnrField;
            }
            set
            {
                this.cVRnrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Pnummer
        {
            get
            {
                return this.pnummerField;
            }
            set
            {
                this.pnummerField = value;
            }
        }
    }
}