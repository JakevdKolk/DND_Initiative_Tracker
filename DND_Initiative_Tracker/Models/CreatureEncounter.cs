using DND_Initiative_Tracker.Models.Enums;

namespace DND_Initiative_Tracker.Models
{
    public class CreatureEncounter
    {
        public int CreatureId { get; set; }
        public Creature Creature { get; set; } = default!;

        public int EncounterId { get; set; }
        public Encounter Encounter { get; set; } = default!;

        public int? CurrentHp { get; set; }

        public decimal? Initiative { get; set; } // DECIMAL(5,2)
        public int? TempHp { get; set; }
        public DeathStatus? DeathStatus { get; set; }
    }

}