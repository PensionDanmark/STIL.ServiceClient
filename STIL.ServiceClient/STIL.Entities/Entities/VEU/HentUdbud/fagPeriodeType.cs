namespace STIL.Entities.VEU.HentUdbud
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
    public partial class fagPeriodeType
    {
        
        private System.DateTime startDatoField;
        
        private System.DateTime slutDatoField;
        
        private decimal varighedDageField;
        
        private bool varighedDageFieldSpecified;
        
        private enumJN foregarUndervisningPaVirkField;
        
        private bool foregarUndervisningPaVirkFieldSpecified;
        
        private enumJN fjernundervisningField;
        
        private bool fjernundervisningFieldSpecified;
        
        private lokationType lokationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=0)]
        public System.DateTime StartDato
        {
            get
            {
                return this.startDatoField;
            }
            set
            {
                this.startDatoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime SlutDato
        {
            get
            {
                return this.slutDatoField;
            }
            set
            {
                this.slutDatoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public decimal VarighedDage
        {
            get
            {
                return this.varighedDageField;
            }
            set
            {
                this.varighedDageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VarighedDageSpecified
        {
            get
            {
                return this.varighedDageFieldSpecified;
            }
            set
            {
                this.varighedDageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public enumJN ForegarUndervisningPaVirk
        {
            get
            {
                return this.foregarUndervisningPaVirkField;
            }
            set
            {
                this.foregarUndervisningPaVirkField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ForegarUndervisningPaVirkSpecified
        {
            get
            {
                return this.foregarUndervisningPaVirkFieldSpecified;
            }
            set
            {
                this.foregarUndervisningPaVirkFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public enumJN Fjernundervisning
        {
            get
            {
                return this.fjernundervisningField;
            }
            set
            {
                this.fjernundervisningField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FjernundervisningSpecified
        {
            get
            {
                return this.fjernundervisningFieldSpecified;
            }
            set
            {
                this.fjernundervisningFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public lokationType Lokation
        {
            get
            {
                return this.lokationField;
            }
            set
            {
                this.lokationField = value;
            }
        }
    }
}