namespace HomeDNS.Models
{
    public class Client
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? IpAddress { get; set; }
        public string? MacAddress { get; set; }
        public string? Hostname { get; set; }
    }
}