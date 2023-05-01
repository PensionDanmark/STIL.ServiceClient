namespace STIL.Entities.VEU.HentUdbud
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
    public partial class Opdatering
    {
        
        private long loebenummerField;
        
        private string aktiGuidField;
        
        private string instNrField;
        
        private HandlingType handlingField;
        
        private Hold holdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public long Loebenummer
        {
            get
            {
                return this.loebenummerField;
            }
            set
            {
                this.loebenummerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string AktiGuid
        {
            get
            {
                return this.aktiGuidField;
            }
            set
            {
                this.aktiGuidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string InstNr
        {
            get
            {
                return this.instNrField;
            }
            set
            {
                this.instNrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public HandlingType Handling
        {
            get
            {
                return this.handlingField;
            }
            set
            {
                this.handlingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public Hold Hold
        {
            get
            {
                return this.holdField;
            }
            set
            {
                this.holdField = value;
            }
        }
    }
}