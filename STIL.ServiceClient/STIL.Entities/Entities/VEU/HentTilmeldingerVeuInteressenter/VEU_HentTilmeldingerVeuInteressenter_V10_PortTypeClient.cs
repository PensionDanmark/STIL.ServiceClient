namespace STIL.Entities.VEU.HentTilmeldingerVeuInteressenter
{
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class VEU_HentTilmeldingerVeuInteressenter_V10_PortTypeClient : System.ServiceModel.ClientBase<VEU_HentTilmeldingerVeuInteressenter_V10_PortType>, VEU_HentTilmeldingerVeuInteressenter_V10_PortType
    {

        public VEU_HentTilmeldingerVeuInteressenter_V10_PortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PingResponse1> VEU_HentTilmeldingerVeuInteressenter_V10_PortType.PingAsync(PingRequest request)
        {
            return Channel.PingAsync(request);
        }

        public System.Threading.Tasks.Task<PingResponse1> PingAsync(Ping Ping)
        {
            PingRequest inValue = new Entities.HentTilmeldingerVeuInteressenter.PingRequest();
            inValue.Ping = Ping;
            return ((VEU_HentTilmeldingerVeuInteressenter_V10_PortType)this).PingAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HentTilmeldingerResponse2> VEU_HentTilmeldingerVeuInteressenter_V10_PortType.HentTilmeldingerAsync(HentTilmeldingerRequest1 request)
        {
            return Channel.HentTilmeldingerAsync(request);
        }

        public System.Threading.Tasks.Task<HentTilmeldingerResponse2> HentTilmeldingerAsync(HentTilmeldingerRequest HentTilmeldingerRequest)
        {
            HentTilmeldingerRequest1 inValue = new Entities.HentTilmeldingerVeuInteressenter.HentTilmeldingerRequest1();
            inValue.HentTilmeldingerRequest = HentTilmeldingerRequest;
            return ((VEU_HentTilmeldingerVeuInteressenter_V10_PortType)this).HentTilmeldingerAsync(inValue);
        }

        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)this).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)this).EndOpen));
        }

        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)this).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)this).EndClose));
        }
    }
}