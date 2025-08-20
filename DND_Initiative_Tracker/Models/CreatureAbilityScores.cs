namespace DND_Initiative_Tracker.Models
{
    public class CreatureAbilityScores
    {
        public int CreatureId { get; set; }
        public Creature Creature { get; set; } = default!;

        public int AbilityScoreId { get; set; }
        public AbilityScoreType AbilityScoreType { get; set; } = default!;

        public int? Score { get; set; }
        public bool? IsSavingThrowProficient { get; set; }
    }
}
