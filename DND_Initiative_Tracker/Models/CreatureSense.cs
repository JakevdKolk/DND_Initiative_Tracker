namespace DND_Initiative_Tracker.Models
{
    public class CreatureSense
    {
        public int CreatureId { get; set; }
        public Creature Creature { get; set; } = default!;

        public int SenseId { get; set; }
        public Sense Sense { get; set; } = default!;

        public int? Distance { get; set; }
        public string? Notes { get; set; }
    }
}
