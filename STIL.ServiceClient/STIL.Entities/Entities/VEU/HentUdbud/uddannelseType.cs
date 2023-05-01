namespace STIL.Entities.VEU.HentUdbud
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
    public partial class uddannelseType
    {
        
        private string cOSAformalField;
        
        private string versionField;
        
        private string betegnelseField;
        
        private UddannelsestypeType uddannelsestypeField;
        
        private bool uddannelsestypeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string COSAformal
        {
            get
            {
                return this.cOSAformalField;
            }
            set
            {
                this.cOSAformalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public UddannelsestypeType Uddannelsestype
        {
            get
            {
                return this.uddannelsestypeField;
            }
            set
            {
                this.uddannelsestypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UddannelsestypeSpecified
        {
            get
            {
                return this.uddannelsestypeFieldSpecified;
            }
            set
            {
                this.uddannelsestypeFieldSpecified = value;
            }
        }
    }
}