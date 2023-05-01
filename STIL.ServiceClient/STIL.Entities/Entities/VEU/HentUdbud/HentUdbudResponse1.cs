namespace STIL.Entities.VEU.HentUdbud
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
    public partial class HentUdbudResponse1 : ResponseType
    {
        
        private System.DateTime behandlingstidspunktField;
        
        private Opdatering[] opdateringListeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.DateTime Behandlingstidspunkt
        {
            get
            {
                return this.behandlingstidspunktField;
            }
            set
            {
                this.behandlingstidspunktField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OpdateringListe", Order=1)]
        public Opdatering[] OpdateringListe
        {
            get
            {
                return this.opdateringListeField;
            }
            set
            {
                this.opdateringListeField = value;
            }
        }
    }
}