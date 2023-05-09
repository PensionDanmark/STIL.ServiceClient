namespace STIL.ServiceClient
{
    public interface IStilServiceClient
    {
        string Version { get; set; }
        StilServiceClient.VeuClient VEU { get; }
    }
}