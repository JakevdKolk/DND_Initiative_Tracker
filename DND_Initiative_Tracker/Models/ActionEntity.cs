using DND_Initiative_Tracker.Models.Enums;

namespace DND_Initiative_Tracker.Models
{
    public class ActionEntity // “Action” collides with System.Action; rename type but map table name
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }
        public ActionType? ActionType { get; set; }

        public string? Recharge { get; set; } // SQL: VARCHAR (no length) – we’ll map to text
        public int? Reach { get; set; }
        public int? AttackBonus { get; set; }
        public int? Range { get; set; }
        public int? Area { get; set; }
        public string? SaveDc { get; set; }

        public ICollection<SpellAction> SpellActions { get; set; } = new List<SpellAction>();
        public ICollection<CreatureAction> CreatureActions { get; set; } = new List<CreatureAction>();
    }
}
