namespace STIL.Entities.VEU.HentUdbud
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
    public partial class tillegsprisType
    {
        
        private decimal tillegsprisField;
        
        private bool tillegsprisFieldSpecified;
        
        private string tillegsprisArsagField;
        
        private enumJN finanslovFastsatField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public decimal Tillegspris
        {
            get
            {
                return this.tillegsprisField;
            }
            set
            {
                this.tillegsprisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TillegsprisSpecified
        {
            get
            {
                return this.tillegsprisFieldSpecified;
            }
            set
            {
                this.tillegsprisFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string TillegsprisArsag
        {
            get
            {
                return this.tillegsprisArsagField;
            }
            set
            {
                this.tillegsprisArsagField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public enumJN FinanslovFastsat
        {
            get
            {
                return this.finanslovFastsatField;
            }
            set
            {
                this.finanslovFastsatField = value;
            }
        }
    }
}