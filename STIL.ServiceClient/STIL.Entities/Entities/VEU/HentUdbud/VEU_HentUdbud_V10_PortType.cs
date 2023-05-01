namespace STIL.Entities.VEU.HentUdbud
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(Name="VEU_HentUdbud_V1.0_PortType", Namespace="http://ipl.stil.dk/services/veu/hentudbud/v1.0", ConfigurationName="STIL.Entities.VEU.HentUdbud.VEU_HentUdbud_V10_PortType")]
    public interface VEU_HentUdbud_V10_PortType
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ipl.stil.dk/services/veu/hentudbud/v1.0/VEU_HentUdbud_V1.0_PortType/PingRe" +
                                                               "quest", ReplyAction="http://ipl.stil.dk/services/veu/hentudbud/v1.0/VEU_HentUdbud_V1.0_PortType/PingRe" +
            "sponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(STIL.Entities.VEU.HentUdbud.ServiceFaultDetailer), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="ServiceFaultDetailer")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<STIL.Entities.VEU.HentUdbud.PingResponse1> PingAsync(STIL.Entities.VEU.HentUdbud.PingRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ipl.stil.dk/services/veu/hentudbud/v1.0/VEU_HentUdbud_V1.0_PortType/HentUd" +
                                                               "budRequest", ReplyAction="http://ipl.stil.dk/services/veu/hentudbud/v1.0/VEU_HentUdbud_V1.0_PortType/HentUd" +
            "budResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(STIL.Entities.VEU.HentUdbud.ServiceFaultDetailer), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="ServiceFaultDetailer")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<STIL.Entities.VEU.HentUdbud.HentUdbudResponse2> HentUdbudAsync(STIL.Entities.VEU.HentUdbud.HentUdbudRequest2 request);
    }
}