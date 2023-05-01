namespace STIL.Entities.VEU.HentTilmeldingerVeuInteressenter
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0")]
    public partial class ServiceFaultDetailer
    {

        private string correlationIDField;

        private System.DateTime timestampField;

        private string errorCodeField;

        private string errorMessageField;

        private string detailsField;

        private SourceSystemErrorType sourceSystemErrorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string CorrelationID
        {
            get
            {
                return correlationIDField;
            }
            set
            {
                correlationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public System.DateTime Timestamp
        {
            get
            {
                return timestampField;
            }
            set
            {
                timestampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string ErrorCode
        {
            get
            {
                return errorCodeField;
            }
            set
            {
                errorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 3)]
        public string ErrorMessage
        {
            get
            {
                return errorMessageField;
            }
            set
            {
                errorMessageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 4)]
        public string Details
        {
            get
            {
                return detailsField;
            }
            set
            {
                detailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 5)]
        public SourceSystemErrorType SourceSystemError
        {
            get
            {
                return sourceSystemErrorField;
            }
            set
            {
                sourceSystemErrorField = value;
            }
        }
    }
}