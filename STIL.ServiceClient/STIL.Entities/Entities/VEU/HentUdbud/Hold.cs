namespace STIL.Entities.VEU.HentUdbud
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.veu.stil.dk/hentudbud/webservice/hentudbud")]
    public partial class Hold
    {
        
        private string aktiGuidField;
        
        private System.DateTime startdatoField;
        
        private System.DateTime slutdatoField;
        
        private string kortBetegnelseField;
        
        private string betegnelseField;
        
        private string beskrivelseField;
        
        private string uGNavnField;
        
        private decimal antalPladserField;
        
        private bool antalPladserFieldSpecified;
        
        private decimal elevLektionerField;
        
        private bool elevLektionerFieldSpecified;
        
        private enumJN aflystField;
        
        private System.DateTime aflystPrdatoField;
        
        private bool aflystPrdatoFieldSpecified;
        
        private string undervisningstidField;
        
        private UndervisningsformType undervisningsformField;
        
        private bool undervisningsformFieldSpecified;
        
        private System.DateTime tilmeldingsfristField;
        
        private IndberetningsprincipType indberetningsprincipField;
        
        private enumJN lastField;
        
        private string forudsaetningerField;
        
        private string kviknrField;
        
        private string kontaktpersonField;
        
        private string kontaktTelefonnrField;
        
        private string emailField;
        
        private string hjemmesideField;
        
        private string aktivitetsafdelingField;
        
        private string projektomradeField;
        
        private string ansvarsomradeField;
        
        private decimal minimumAntalTilmeldteField;
        
        private bool minimumAntalTilmeldteFieldSpecified;
        
        private enumJN kontraktuddannelseField;
        
        private enumJN garantiKursusField;
        
        private decimal deltagerPrisBeloebField;
        
        private bool deltagerPrisBeloebFieldSpecified;
        
        private skoleType skoleField;
        
        private lokationType lokationField;
        
        private uddannelseType uddannelseField;
        
        private holdPladsType[] holdPladsListeField;
        
        private tillegsprisType[] tillegsprisListeField;
        
        private skolefagPaHoldType[] skolefagPaHoldListeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime Startdato
        {
            get
            {
                return this.startdatoField;
            }
            set
            {
                this.startdatoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=2)]
        public System.DateTime Slutdato
        {
            get
            {
                return this.slutdatoField;
            }
            set
            {
                this.slutdatoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string KortBetegnelse
        {
            get
            {
                return this.kortBetegnelseField;
            }
            set
            {
                this.kortBetegnelseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Beskrivelse
        {
            get
            {
                return this.beskrivelseField;
            }
            set
            {
                this.beskrivelseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string UGNavn
        {
            get
            {
                return this.uGNavnField;
            }
            set
            {
                this.uGNavnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public decimal ElevLektioner
        {
            get
            {
                return this.elevLektionerField;
            }
            set
            {
                this.elevLektionerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ElevLektionerSpecified
        {
            get
            {
                return this.elevLektionerFieldSpecified;
            }
            set
            {
                this.elevLektionerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public enumJN Aflyst
        {
            get
            {
                return this.aflystField;
            }
            set
            {
                this.aflystField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=10)]
        public System.DateTime AflystPrdato
        {
            get
            {
                return this.aflystPrdatoField;
            }
            set
            {
                this.aflystPrdatoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AflystPrdatoSpecified
        {
            get
            {
                return this.aflystPrdatoFieldSpecified;
            }
            set
            {
                this.aflystPrdatoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string Undervisningstid
        {
            get
            {
                return this.undervisningstidField;
            }
            set
            {
                this.undervisningstidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public UndervisningsformType Undervisningsform
        {
            get
            {
                return this.undervisningsformField;
            }
            set
            {
                this.undervisningsformField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UndervisningsformSpecified
        {
            get
            {
                return this.undervisningsformFieldSpecified;
            }
            set
            {
                this.undervisningsformFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=13)]
        public System.DateTime Tilmeldingsfrist
        {
            get
            {
                return this.tilmeldingsfristField;
            }
            set
            {
                this.tilmeldingsfristField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public IndberetningsprincipType Indberetningsprincip
        {
            get
            {
                return this.indberetningsprincipField;
            }
            set
            {
                this.indberetningsprincipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public enumJN Last
        {
            get
            {
                return this.lastField;
            }
            set
            {
                this.lastField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public string Forudsaetninger
        {
            get
            {
                return this.forudsaetningerField;
            }
            set
            {
                this.forudsaetningerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public string Kviknr
        {
            get
            {
                return this.kviknrField;
            }
            set
            {
                this.kviknrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public string Kontaktperson
        {
            get
            {
                return this.kontaktpersonField;
            }
            set
            {
                this.kontaktpersonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
        public string KontaktTelefonnr
        {
            get
            {
                return this.kontaktTelefonnrField;
            }
            set
            {
                this.kontaktTelefonnrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=20)]
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=21)]
        public string Hjemmeside
        {
            get
            {
                return this.hjemmesideField;
            }
            set
            {
                this.hjemmesideField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=22)]
        public string Aktivitetsafdeling
        {
            get
            {
                return this.aktivitetsafdelingField;
            }
            set
            {
                this.aktivitetsafdelingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=23)]
        public string Projektomrade
        {
            get
            {
                return this.projektomradeField;
            }
            set
            {
                this.projektomradeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=24)]
        public string Ansvarsomrade
        {
            get
            {
                return this.ansvarsomradeField;
            }
            set
            {
                this.ansvarsomradeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=25)]
        public decimal MinimumAntalTilmeldte
        {
            get
            {
                return this.minimumAntalTilmeldteField;
            }
            set
            {
                this.minimumAntalTilmeldteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinimumAntalTilmeldteSpecified
        {
            get
            {
                return this.minimumAntalTilmeldteFieldSpecified;
            }
            set
            {
                this.minimumAntalTilmeldteFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=26)]
        public enumJN Kontraktuddannelse
        {
            get
            {
                return this.kontraktuddannelseField;
            }
            set
            {
                this.kontraktuddannelseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=27)]
        public enumJN GarantiKursus
        {
            get
            {
                return this.garantiKursusField;
            }
            set
            {
                this.garantiKursusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=28)]
        public decimal DeltagerPrisBeloeb
        {
            get
            {
                return this.deltagerPrisBeloebField;
            }
            set
            {
                this.deltagerPrisBeloebField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeltagerPrisBeloebSpecified
        {
            get
            {
                return this.deltagerPrisBeloebFieldSpecified;
            }
            set
            {
                this.deltagerPrisBeloebFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=29)]
        public skoleType Skole
        {
            get
            {
                return this.skoleField;
            }
            set
            {
                this.skoleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=30)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=31)]
        public uddannelseType Uddannelse
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
        [System.Xml.Serialization.XmlElementAttribute("HoldPladsListe", Order=32)]
        public holdPladsType[] HoldPladsListe
        {
            get
            {
                return this.holdPladsListeField;
            }
            set
            {
                this.holdPladsListeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TillegsprisListe", Order=33)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SkolefagPaHoldListe", Order=34)]
        public skolefagPaHoldType[] SkolefagPaHoldListe
        {
            get
            {
                return this.skolefagPaHoldListeField;
            }
            set
            {
                this.skolefagPaHoldListeField = value;
            }
        }
    }
}