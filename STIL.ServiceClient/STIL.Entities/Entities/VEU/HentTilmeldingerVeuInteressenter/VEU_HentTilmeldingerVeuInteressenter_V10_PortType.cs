namespace STIL.Entities.VEU.HentTilmeldingerVeuInteressenter
{
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContract(Name = "VEU_HentTilmeldingerVeuInteressenter_V1.0_PortType", Namespace = "http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0", ConfigurationName = "STIL.Entities.HentTilmeldingerVeuInteressenter.VEU_HentTilmeldingerVeuInteressent" +
        "er_V10_PortType")]
    public interface VEU_HentTilmeldingerVeuInteressenter_V10_PortType
    {

        [System.ServiceModel.OperationContract(Action = "http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0/VEU_HentTil" +
                                                               "meldingerVeuInteressenter_V1.0_PortType/PingRequest", ReplyAction = "http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0/VEU_HentTil" +
            "meldingerVeuInteressenter_V1.0_PortType/PingResponse")]
        [System.ServiceModel.FaultContract(typeof(ServiceFaultDetailer), Action = "http://www.w3.org/2005/08/addressing/soap/fault", Name = "ServiceFaultDetailer")]
        [System.ServiceModel.XmlSerializerFormat(SupportFaults = true)]
        System.Threading.Tasks.Task<PingResponse1> PingAsync(PingRequest request);

        [System.ServiceModel.OperationContract(Action = "http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0/VEU_HentTil" +
                                                               "meldingerVeuInteressenter_V1.0_PortType/HentTilmeldingerRequest", ReplyAction = "http://ipl.stil.dk/services/veu/henttilmeldingerveuinteressenter/v1.0/VEU_HentTil" +
            "meldingerVeuInteressenter_V1.0_PortType/HentTilmeldingerResponse")]
        [System.ServiceModel.FaultContract(typeof(ServiceFaultDetailer), Action = "http://www.w3.org/2005/08/addressing/soap/fault", Name = "ServiceFaultDetailer")]
        [System.ServiceModel.XmlSerializerFormat(SupportFaults = true)]
        System.Threading.Tasks.Task<HentTilmeldingerResponse2> HentTilmeldingerAsync(HentTilmeldingerRequest1 request);
    }
}