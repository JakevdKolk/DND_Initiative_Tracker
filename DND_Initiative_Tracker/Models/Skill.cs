using DND_Initiative_Tracker.Models.Enums;

namespace DND_Initiative_Tracker.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public SkillType? SkillType { get; set; }
        public string? Description { get; set; }

        public ICollection<CreatureSkill> CreatureSkills { get; set; } = new List<CreatureSkill>();
    }
}
