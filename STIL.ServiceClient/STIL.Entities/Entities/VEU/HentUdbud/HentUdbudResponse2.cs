namespace STIL.Entities.VEU.HentUdbud
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HentUdbudResponse2
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ipl.stil.dk/services/veu/hentudbud/v1.0", Order=0)]
        public STIL.Entities.VEU.HentUdbud.HentUdbudResponse HentUdbudResponse;
        
        public HentUdbudResponse2()
        {
        }
        
        public HentUdbudResponse2(STIL.Entities.VEU.HentUdbud.HentUdbudResponse HentUdbudResponse)
        {
            this.HentUdbudResponse = HentUdbudResponse;
        }
    }
}