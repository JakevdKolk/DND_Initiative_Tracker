namespace DND_Initiative_Tracker.Models
{
    public class CreatureCondition
    {
        public int CreatureId { get; set; }
        public Creature Creature { get; set; } = default!;

        public int ConditionId { get; set; }
        public Condition Condition { get; set; } = default!;

        public int? ConditionLength { get; set; }
    }
}
