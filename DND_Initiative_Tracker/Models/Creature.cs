using DND_Initiative_Tracker.Models;
using DND_Initiative_Tracker.Models.Enums;

namespace DND_Initiative_Tracker.Models
{
    public class Creature
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public Size? Size { get; set; }

        public int? TypeId { get; set; }
        public CreatureType? Type { get; set; }

        public int? Ac { get; set; }
        public int? Hp { get; set; }

        public int? HpDiceCount { get; set; }
        public int? HpDiceSize { get; set; }
        public int? HpDiceBonus { get; set; }

        public int? LegendaryActionCharges { get; set; }
        public int? ProficiencyBonus { get; set; } // (your SQL had “profiency_bonus” – corrected spelling here)

        public string? Notes { get; set; }
        public bool? IsNpc { get; set; }

        public int? LairInitiative { get; set; }
        public int? InitiativeBonus { get; set; }

        public int? OwnerUserId { get; set; }
        public AppUser? OwnerUser { get; set; }

        public ICollection<CreatureEncounter> CreatureEncounters { get; set; } = new List<CreatureEncounter>();
        public ICollection<CreatureSpeed> Speeds { get; set; } = new List<CreatureSpeed>();
        public ICollection<CreatureAbilityScores> AbilityScores { get; set; } = new List<CreatureAbilityScores>();
        public ICollection<CreatureDamageType> DamageTypes { get; set; } = new List<CreatureDamageType>();
        public ICollection<CreatureSense> Senses { get; set; } = new List<CreatureSense>();
        public ICollection<CreatureLanguage> Languages { get; set; } = new List<CreatureLanguage>();
        public ICollection<CreatureSkill> Skills { get; set; } = new List<CreatureSkill>();
        public ICollection<CreatureCondition> Conditions { get; set; } = new List<CreatureCondition>();
        public ICollection<CreatureAction> Actions { get; set; } = new List<CreatureAction>();
    }
}