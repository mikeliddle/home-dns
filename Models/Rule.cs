namespace HomeDNS.Models
{
    public class Rule
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Domain { get; set; } // e.g. "A", "CNAME", etc.
        public RuleType Type { get; set; } = RuleType.Block;
        public List<string> Tags { get; set; } = new List<string>();
        public List<string> Groups { get; set; } = new List<string>();
    }

    public enum RuleType
    {
        Block,
        Allow
    }
}