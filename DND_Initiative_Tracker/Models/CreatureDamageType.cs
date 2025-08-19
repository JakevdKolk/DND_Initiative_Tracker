using DND_Initiative_Tracker.Models.Enums;

namespace DND_Initiative_Tracker.Models
{
    public class CreatureDamageType
    {
        public int CreatureId { get; set; }
        public Creature Creature { get; set; } = default!;

        public int DamageTypeId { get; set; }
        public DamageType DamageType { get; set; } = default!;

        public DamageTypeCategory? DamageTypeCategory { get; set; }
    }
}
