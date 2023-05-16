namespace  STIL.Entities.VEU.HentOptagedePladser;


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ipl.stil.dk/services/veu/hentoptagedepladser/v1")]
public class ServiceFaultDetailer {
        
    private string correlationIDField;
        
    private System.DateTime timestampField;
        
    private string errorCodeField;
        
    private string errorMessageField;
        
    private string detailsField;
        
    private SourceSystemErrorType sourceSystemErrorField;
        
    
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string CorrelationID {
        get => correlationIDField;
        set => correlationIDField = value;
    }
        
    
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public System.DateTime Timestamp {
        get => timestampField;
        set => timestampField = value;
    }
        
    
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string ErrorCode {
        get => errorCodeField;
        set => errorCodeField = value;
    }
        
    
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string ErrorMessage {
        get => errorMessageField;
        set => errorMessageField = value;
    }
        
    
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string Details {
        get => detailsField;
        set => detailsField = value;
    }
        
    
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public SourceSystemErrorType SourceSystemError {
        get => sourceSystemErrorField;
        set => sourceSystemErrorField = value;
    }

}

/*
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://ipl.stil.dk/services/veu/hentoptagedepladser/v1", ConfigurationName="STIL.HOP.VEU_HentOptagedePladser_V1_PortType")]
public interface VEU_HentOptagedePladser_V1_PortType {
    
    // CODEGEN: Generating message contract since the operation Ping is neither RPC nor document wrapped.
    [System.ServiceModel.OperationContractAttribute(Action="http://ipl.stil.dk/services/veu/hentoptagedepladser/v1/VEU_HentOptagedePladser_V1" +
        "_PortType/PingRequest", ReplyAction="http://ipl.stil.dk/services/veu/hentoptagedepladser/v1/VEU_HentOptagedePladser_V1" +
        "_PortType/PingResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof( STIL.Entities.Entities.VEU.HentOptagedePladser.ServiceFaultDetailer), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="ServiceFaultDetailer")]
    [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
     STIL.Entities.Entities.VEU.HentOptagedePladser.PingResponse1 Ping( STIL.Entities.Entities.VEU.HentOptagedePladser.PingRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ipl.stil.dk/services/veu/hentoptagedepladser/v1/VEU_HentOptagedePladser_V1" +
        "_PortType/PingRequest", ReplyAction="http://ipl.stil.dk/services/veu/hentoptagedepladser/v1/VEU_HentOptagedePladser_V1" +
        "_PortType/PingResponse")]
    System.Threading.Tasks.Task< STIL.Entities.Entities.VEU.HentOptagedePladser.PingResponse1> PingAsync( STIL.Entities.Entities.VEU.HentOptagedePladser.PingRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://ipl.stil.dk/services/veu/hentoptagedepladser/v1/VEU_HentOptagedePladser_V1" +
        "_PortType/HentOptagedePladserRequest", ReplyAction="http://ipl.stil.dk/services/veu/hentoptagedepladser/v1/VEU_HentOptagedePladser_V1" +
        "_PortType/HentOptagedePladserResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof( STIL.Entities.Entities.VEU.HentOptagedePladser.ServiceFaultDetailer), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="ServiceFaultDetailer")]
    [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
     STIL.Entities.Entities.VEU.HentOptagedePladser.HentOptagedePladserResponse1 HentOptagedePladser( STIL.Entities.Entities.VEU.HentOptagedePladser.HentOptagedePladserRequest1 request);
    
    // CODEGEN: Generating message contract since the operation has multiple return values.
    [System.ServiceModel.OperationContractAttribute(Action="http://ipl.stil.dk/services/veu/hentoptagedepladser/v1/VEU_HentOptagedePladser_V1" +
        "_PortType/HentOptagedePladserRequest", ReplyAction="http://ipl.stil.dk/services/veu/hentoptagedepladser/v1/VEU_HentOptagedePladser_V1" +
        "_PortType/HentOptagedePladserResponse")]
    System.Threading.Tasks.Task< STIL.Entities.Entities.VEU.HentOptagedePladser.HentOptagedePladserResponse1> HentOptagedePladserAsync( STIL.Entities.Entities.VEU.HentOptagedePladser.HentOptagedePladserRequest1 request);
}*/

// [System.Diagnostics.DebuggerStepThroughAttribute()]
// [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
// [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
// [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
// public partial class PingRequest {
//         
//     [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ipl.stil.dk/services/veu/hentoptagedepladser/v1", Order=0)]
//     public  Ping Ping;
//         
//     public PingRequest() {
//     }
//         
//     public PingRequest( Ping Ping) {
//         this.Ping = Ping;
//     }
// }
    
// [System.Diagnostics.DebuggerStepThroughAttribute()]
// [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
// [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
// [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
// public partial class PingResponse1 {
//         
//     [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ipl.stil.dk/services/veu/hentoptagedepladser/v1", Order=0)]
//     public  PingResponse PingResponse;
//         
//     public PingResponse1() {
//     }
//         
//     public PingResponse1( PingResponse PingResponse) {
//         this.PingResponse = PingResponse;
//     }
// }