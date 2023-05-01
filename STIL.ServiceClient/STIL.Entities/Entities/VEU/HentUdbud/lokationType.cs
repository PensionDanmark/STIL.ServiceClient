namespace STIL.Entities.VEU.HentUdbud
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
    public partial class lokationType
    {
        
        private string lokationIdentifikatorField;
        
        private string betegnelseField;
        
        private string gadeField;
        
        private string stedField;
        
        private string postNrField;
        
        private string kommunekodeField;
        
        private string telefonnummerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string LokationIdentifikator
        {
            get
            {
                return this.lokationIdentifikatorField;
            }
            set
            {
                this.lokationIdentifikatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Gade
        {
            get
            {
                return this.gadeField;
            }
            set
            {
                this.gadeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Sted
        {
            get
            {
                return this.stedField;
            }
            set
            {
                this.stedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string PostNr
        {
            get
            {
                return this.postNrField;
            }
            set
            {
                this.postNrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Kommunekode
        {
            get
            {
                return this.kommunekodeField;
            }
            set
            {
                this.kommunekodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Telefonnummer
        {
            get
            {
                return this.telefonnummerField;
            }
            set
            {
                this.telefonnummerField = value;
            }
        }
    }
}