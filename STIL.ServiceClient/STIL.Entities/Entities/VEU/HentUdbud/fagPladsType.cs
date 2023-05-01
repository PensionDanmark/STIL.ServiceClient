namespace STIL.Entities.VEU.HentUdbud
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
    public partial class fagPladsType
    {
        
        private System.DateTime datoField;
        
        private decimal antalPladserField;
        
        private bool antalPladserFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=0)]
        public System.DateTime Dato
        {
            get
            {
                return this.datoField;
            }
            set
            {
                this.datoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public decimal AntalPladser
        {
            get
            {
                return this.antalPladserField;
            }
            set
            {
                this.antalPladserField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AntalPladserSpecified
        {
            get
            {
                return this.antalPladserFieldSpecified;
            }
            set
            {
                this.antalPladserFieldSpecified = value;
            }
        }
    }
}