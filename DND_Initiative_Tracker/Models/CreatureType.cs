using DND_Initiative_Tracker.Models;

namespace DND_Initiative_Tracker.Models
{
    public class CreatureType
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        public ICollection<Creature> Creatures { get; set; } = new List<Creature>();
    }
}