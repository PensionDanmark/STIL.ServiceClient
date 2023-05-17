namespace STIL.Entities.VEU.HentOptagedePladser
{
    [System.SerializableAttribute]
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ipl.stil.dk/services/veu/hentoptagedepladser/v1")]
    public class SourceSystemErrorType
    {
        private string sourceSystemNameField;
        private string errorCodeField;
        private string detailsField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string SourceSystemName
        {
            get => sourceSystemNameField;
            set => sourceSystemNameField = value;
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string ErrorCode
        {
            get => errorCodeField;
            set => errorCodeField = value;
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Details
        {
            get => detailsField;
            set => detailsField = value;
        }
    }
}