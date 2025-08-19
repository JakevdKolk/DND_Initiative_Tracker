namespace DND_Initiative_Tracker.Models
{
    public class Condition
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        public ICollection<CreatureCondition> CreatureConditions { get; set; } = new List<CreatureCondition>();
    }
}
