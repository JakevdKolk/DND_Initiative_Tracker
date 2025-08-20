namespace DND_Initiative_Tracker.Models
{

    public class CreatureSkill
    {
        public int CreatureId { get; set; }
        public Creature Creature { get; set; } = default!;

        public int SkillId { get; set; }
        public Skill Skill { get; set; } = default!;

        public bool? IsProficient { get; set; }   // SQL: is_profienct (typo); fixed here
        public bool? IsExpertise { get; set; }
        public int? BonusOverride { get; set; }
    }
}
