namespace HomeDNS.Models
{
    public class Group
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<Client> Clients { get; set; } = new List<Client>();
    }
}