 namespace DND_Initiative_Tracker.Models
{
    public class AbilityScoreType
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<CreatureAbilityScores> CreatureScores { get; set; } = new List<CreatureAbilityScores>();
    }

}
