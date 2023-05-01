namespace STIL.Entities.VEU.HentUdbud
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
    public partial class skolefagPaHoldType
    {
        
        private decimal varighedDageField;
        
        private decimal timerPrDagField;
        
        private bool timerPrDagFieldSpecified;
        
        private decimal justeretPrisField;
        
        private decimal fuldprisField;
        
        private bool fuldprisFieldSpecified;
        
        private decimal tillegsprisField;
        
        private bool tillegsprisFieldSpecified;
        
        private string tillegsprisArsagField;
        
        private enumJN primertFagField;
        
        private bool primertFagFieldSpecified;
        
        private enumJN arvesField;
        
        private bool arvesFieldSpecified;
        
        private enumJN foregarUndervisningPaVirkField;
        
        private bool foregarUndervisningPaVirkFieldSpecified;
        
        private enumJN fjernundervisningField;
        
        private bool fjernundervisningFieldSpecified;
        
        private skolefagType skolefagField;
        
        private UVMfagType uVMfagField;
        
        private skoleType godkendtSkoleField;
        
        private skoleType gennemforendeSkoleField;
        
        private skolefagUddannelseType uddannelseField;
        
        private skoleFagPaHoldUdliciteretTil udliciteretTilField;
        
        private fagPeriodeType[] fagPeriodeListeField;
        
        private fagPladsType[] fagPladsListeField;
        
        private tillegsprisType[] tillegsprisListeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public decimal TimerPrDag
        {
            get
            {
                return this.timerPrDagField;
            }
            set
            {
                this.timerPrDagField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimerPrDagSpecified
        {
            get
            {
                return this.timerPrDagFieldSpecified;
            }
            set
            {
                this.timerPrDagFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public decimal JusteretPris
        {
            get
            {
                return this.justeretPrisField;
            }
            set
            {
                this.justeretPrisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public decimal Fuldpris
        {
            get
            {
                return this.fuldprisField;
            }
            set
            {
                this.fuldprisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FuldprisSpecified
        {
            get
            {
                return this.fuldprisFieldSpecified;
            }
            set
            {
                this.fuldprisFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public enumJN PrimertFag
        {
            get
            {
                return this.primertFagField;
            }
            set
            {
                this.primertFagField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrimertFagSpecified
        {
            get
            {
                return this.primertFagFieldSpecified;
            }
            set
            {
                this.primertFagFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public enumJN Arves
        {
            get
            {
                return this.arvesField;
            }
            set
            {
                this.arvesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArvesSpecified
        {
            get
            {
                return this.arvesFieldSpecified;
            }
            set
            {
                this.arvesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public skolefagType Skolefag
        {
            get
            {
                return this.skolefagField;
            }
            set
            {
                this.skolefagField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public UVMfagType UVMfag
        {
            get
            {
                return this.uVMfagField;
            }
            set
            {
                this.uVMfagField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public skoleType GodkendtSkole
        {
            get
            {
                return this.godkendtSkoleField;
            }
            set
            {
                this.godkendtSkoleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public skoleType GennemforendeSkole
        {
            get
            {
                return this.gennemforendeSkoleField;
            }
            set
            {
                this.gennemforendeSkoleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public skolefagUddannelseType Uddannelse
        {
            get
            {
                return this.uddannelseField;
            }
            set
            {
                this.uddannelseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public skoleFagPaHoldUdliciteretTil UdliciteretTil
        {
            get
            {
                return this.udliciteretTilField;
            }
            set
            {
                this.udliciteretTilField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FagPeriodeListe", Order=16)]
        public fagPeriodeType[] FagPeriodeListe
        {
            get
            {
                return this.fagPeriodeListeField;
            }
            set
            {
                this.fagPeriodeListeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FagPladsListe", Order=17)]
        public fagPladsType[] FagPladsListe
        {
            get
            {
                return this.fagPladsListeField;
            }
            set
            {
                this.fagPladsListeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TillegsprisListe", Order=18)]
        public tillegsprisType[] TillegsprisListe
        {
            get
            {
                return this.tillegsprisListeField;
            }
            set
            {
                this.tillegsprisListeField = value;
            }
        }
    }
}