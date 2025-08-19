namespace DND_Initiative_Tracker.Models
{
    public class Sense
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        public ICollection<CreatureSense> CreatureSenses { get; set; } = new List<CreatureSense>();
    }
}
