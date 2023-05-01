namespace STIL.Entities.VEU.HentUdbud
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
    public partial class IndholdRequestType
    {
        
        private string[] dsNummerListeField;
        
        private long nyereEndLoebenummerField;
        
        private bool nyereEndLoebenummerFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DsNummerListe", Order=0)]
        public string[] DsNummerListe
        {
            get
            {
                return this.dsNummerListeField;
            }
            set
            {
                this.dsNummerListeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public long NyereEndLoebenummer
        {
            get
            {
                return this.nyereEndLoebenummerField;
            }
            set
            {
                this.nyereEndLoebenummerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NyereEndLoebenummerSpecified
        {
            get
            {
                return this.nyereEndLoebenummerFieldSpecified;
            }
            set
            {
                this.nyereEndLoebenummerFieldSpecified = value;
            }
        }
    }
}