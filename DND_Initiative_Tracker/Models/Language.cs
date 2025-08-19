namespace DND_Initiative_Tracker.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        public ICollection<CreatureLanguage> CreatureLanguages { get; set; } = new List<CreatureLanguage>();
    }
}
