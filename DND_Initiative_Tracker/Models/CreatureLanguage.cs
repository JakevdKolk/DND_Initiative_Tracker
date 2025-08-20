namespace DND_Initiative_Tracker.Models
{
    public class CreatureLanguage
    {
        public int CreatureId { get; set; }
        public Creature Creature { get; set; } = default!;

        public int LanguageId { get; set; }
        public Language Language { get; set; } = default!;

        public string? Notes { get; set; }
    }

}
