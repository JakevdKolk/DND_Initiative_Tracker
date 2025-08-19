
namespace DND_Initiative_Tracker.Models
{
    public class CreatureSpeed
    {
        public int CreatureId { get; set; }
        public Creature Creature { get; set; } = default!;

        public int SpeedId { get; set; }
        public Speed Speed { get; set; } = default!;

        public int? SpeedValue { get; set; }
        public bool? IsHover { get; set; }
    }

}