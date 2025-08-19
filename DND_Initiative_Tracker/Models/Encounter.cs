using DND_Initiative_Tracker.Models;

namespace DND_Initiative_Tracker.Models
{
    public class Encounter
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int? TurnCount { get; set; }

        public int? CampaignId { get; set; }
        public Campaign? Campaign { get; set; }

        public string? Notes { get; set; }

        public ICollection<CreatureEncounter> CreatureEncounters { get; set; } = new List<CreatureEncounter>();
    }
}