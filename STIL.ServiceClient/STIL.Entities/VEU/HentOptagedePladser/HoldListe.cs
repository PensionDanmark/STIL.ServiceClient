namespace STIL.Entities.VEU.HentOptagedePladser
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.veu.stil.dk/hentudbud/webservice/hentoptagedepladser")]
    public class HoldListe {
        
        private string aktiGUIDField;
        
        private HoldPladsType[] holdPladsListeField;
        
        private SkolefagPaHoldType[] skolefagPaHoldListeField;
        
    
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string AktiGUID {
            get => aktiGUIDField;
            set => aktiGUIDField = value;
        }
        
    
        [System.Xml.Serialization.XmlElementAttribute("HoldPladsListe", Order=1)]
        public HoldPladsType[] HoldPladsListe {
            get => holdPladsListeField;
            set => holdPladsListeField = value;
        }
        
    
        [System.Xml.Serialization.XmlElementAttribute("SkolefagPaHoldListe", Order=2)]
        public SkolefagPaHoldType[] SkolefagPaHoldListe {
            get => skolefagPaHoldListeField;
            set => skolefagPaHoldListeField = value;
        }

    }
}