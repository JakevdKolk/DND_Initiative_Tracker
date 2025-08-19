namespace DND_Initiative_Tracker.Models
{
    public class Spell
    {
        public int Id { get; set; }
        public string? School { get; set; }
        public bool? Concentration { get; set; }
        public int? Duration { get; set; }

        public ICollection<SpellAction> SpellActions { get; set; } = new List<SpellAction>();
    }
}
