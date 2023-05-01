namespace STIL.Entities.VEU.HentUdbud
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class VEU_HentUdbud_V10_PortTypeClient : System.ServiceModel.ClientBase<STIL.Entities.VEU.HentUdbud.VEU_HentUdbud_V10_PortType>, STIL.Entities.VEU.HentUdbud.VEU_HentUdbud_V10_PortType
    {
        
        public VEU_HentUdbud_V10_PortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<STIL.Entities.VEU.HentUdbud.PingResponse1> STIL.Entities.VEU.HentUdbud.VEU_HentUdbud_V10_PortType.PingAsync(STIL.Entities.VEU.HentUdbud.PingRequest request)
        {
            return base.Channel.PingAsync(request);
        }
        
        public System.Threading.Tasks.Task<STIL.Entities.VEU.HentUdbud.PingResponse1> PingAsync(STIL.Entities.VEU.HentUdbud.Ping Ping)
        {
            STIL.Entities.VEU.HentUdbud.PingRequest inValue = new STIL.Entities.VEU.HentUdbud.PingRequest();
            inValue.Ping = Ping;
            return ((STIL.Entities.VEU.HentUdbud.VEU_HentUdbud_V10_PortType)(this)).PingAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<STIL.Entities.VEU.HentUdbud.HentUdbudResponse2> STIL.Entities.VEU.HentUdbud.VEU_HentUdbud_V10_PortType.HentUdbudAsync(STIL.Entities.VEU.HentUdbud.HentUdbudRequest2 request)
        {
            return base.Channel.HentUdbudAsync(request);
        }
        
        public System.Threading.Tasks.Task<STIL.Entities.VEU.HentUdbud.HentUdbudResponse2> HentUdbudAsync(STIL.Entities.VEU.HentUdbud.HentUdbudRequest HentUdbudRequest)
        {
            STIL.Entities.VEU.HentUdbud.HentUdbudRequest2 inValue = new STIL.Entities.VEU.HentUdbud.HentUdbudRequest2();
            inValue.HentUdbudRequest = HentUdbudRequest;
            return ((STIL.Entities.VEU.HentUdbud.VEU_HentUdbud_V10_PortType)(this)).HentUdbudAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
    }
}