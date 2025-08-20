using DND_Initiative_Tracker.Models;
using DND_Initiative_Tracker.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using System.Runtime.Intrinsics.X86;

namespace DND_Initiative_Tracker.Data
{

    public class DnDDbContext : DbContext
    {
        public DnDDbContext(DbContextOptions<DnDDbContext> options) : base(options) { }

        // DbSets … (same as I gave you earlier)
        public DbSet<Role> Roles => Set<Role>();
        public DbSet<AppUser> AppUser => Set<AppUser>();
        public DbSet<Campaign> Campaigns => Set<Campaign>();
        public DbSet<CampaignUser> CampaignUsers => Set<CampaignUser>();
        public DbSet<CreatureType> CreatureTypes => Set<CreatureType>();
        public DbSet<Creature> Creatures => Set<Creature>();
        public DbSet<Encounter> Encounters => Set<Encounter>();
        public DbSet<CreatureEncounter> CreatureEncounters => Set<CreatureEncounter>();
        public DbSet<Speed> Speeds => Set<Speed>();
        public DbSet<CreatureSpeed> CreatureSpeeds => Set<CreatureSpeed>();
        public DbSet<AbilityScoreType> AbilityScoreTypes => Set<AbilityScoreType>();
        public DbSet<CreatureAbilityScores> CreatureAbilityScores => Set<CreatureAbilityScores>();
        public DbSet<DamageType> DamageTypes => Set<DamageType>();
        public DbSet<CreatureDamageType> CreatureDamageTypes => Set<CreatureDamageType>();
        public DbSet<Sense> Senses => Set<Sense>();
        public DbSet<CreatureSense> CreatureSenses => Set<CreatureSense>();
        public DbSet<Language> Languages => Set<Language>();
        public DbSet<CreatureLanguage> CreatureLanguages => Set<CreatureLanguage>();
        public DbSet<Skill> Skills => Set<Skill>();
        public DbSet<CreatureSkill> CreatureSkills => Set<CreatureSkill>();
        public DbSet<Condition> Conditions => Set<Condition>();
        public DbSet<CreatureCondition> CreatureConditions => Set<CreatureCondition>();
        public DbSet<Spell> Spells => Set<Spell>();
        public DbSet<ActionEntity> Actions => Set<ActionEntity>();
        public DbSet<SpellAction> SpellActions => Set<SpellAction>();
        public DbSet<CreatureAction> CreatureActions => Set<CreatureAction>();

        protected override void OnModelCreating(ModelBuilder model)
        {
            // --- Create & map PostgreSQL enums from your C# enums ---
            model.HasPostgresEnum<Size>("public", "size");
            model.HasPostgresEnum<DeathStatus>("public", "death_status");
            model.HasPostgresEnum<DamageTypeCategory>("public", "damage_type_category");
            model.HasPostgresEnum<SkillType>("public", "skill_type");
            model.HasPostgresEnum<ActionType>("public", "action_type");

            // --- Composite keys (join tables) ---
            model.Entity<CampaignUser>().HasKey(x => new { x.CampaignId, x.UserId });
            model.Entity<CreatureEncounter>().HasKey(x => new { x.CreatureId, x.EncounterId });
            model.Entity<CreatureSpeed>().HasKey(x => new { x.CreatureId, x.SpeedId });
            model.Entity<CreatureAbilityScores>().HasKey(x => new { x.CreatureId, x.AbilityScoreId });
            model.Entity<CreatureDamageType>().HasKey(x => new { x.CreatureId, x.DamageTypeId });
            model.Entity<CreatureSense>().HasKey(x => new { x.CreatureId, x.SenseId });
            model.Entity<CreatureLanguage>().HasKey(x => new { x.CreatureId, x.LanguageId });
            model.Entity<CreatureSkill>().HasKey(x => new { x.CreatureId, x.SkillId });
            model.Entity<CreatureCondition>().HasKey(x => new { x.CreatureId, x.ConditionId });
            model.Entity<SpellAction>().HasKey(x => new { x.SpellId, x.ActionId });
            model.Entity<CreatureAction>().HasKey(x => new { x.CreatureId, x.ActionId });

            // --- Relationships (FKs) ---
            model.Entity<AppUser>()
                .HasOne(u => u.Role)
                .WithMany(r => r.AppUsers)
                .HasForeignKey(u => u.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

            model.Entity<CampaignUser>()
                .HasOne(cu => cu.Campaign).WithMany(c => c.CampaignUsers).HasForeignKey(cu => cu.CampaignId);
            model.Entity<CampaignUser>()
                .HasOne(cu => cu.User).WithMany(u => u.CampaignUsers).HasForeignKey(cu => cu.UserId);

            model.Entity<Creature>()
                .HasOne(c => c.Type).WithMany(t => t.Creatures).HasForeignKey(c => c.TypeId).OnDelete(DeleteBehavior.Restrict);
            model.Entity<Creature>()
                .HasOne(c => c.OwnerUser).WithMany(u => u.OwnedCreatures).HasForeignKey(c => c.OwnerUserId).OnDelete(DeleteBehavior.SetNull);

            model.Entity<CreatureEncounter>()
                .HasOne(ce => ce.Creature).WithMany(c => c.CreatureEncounters).HasForeignKey(ce => ce.CreatureId);
            model.Entity<CreatureEncounter>()
                .HasOne(ce => ce.Encounter).WithMany(e => e.CreatureEncounters).HasForeignKey(ce => ce.EncounterId);

            model.Entity<CreatureSpeed>()
                .HasOne(cs => cs.Creature).WithMany(c => c.Speeds).HasForeignKey(cs => cs.CreatureId);
            model.Entity<CreatureSpeed>()
                .HasOne(cs => cs.Speed).WithMany(s => s.CreatureSpeeds).HasForeignKey(cs => cs.SpeedId);

            model.Entity<CreatureAbilityScores>()
                .HasOne(ca => ca.Creature).WithMany(c => c.AbilityScores).HasForeignKey(ca => ca.CreatureId);
            model.Entity<CreatureAbilityScores>()
                .HasOne(ca => ca.AbilityScoreType).WithMany(a => a.CreatureScores).HasForeignKey(ca => ca.AbilityScoreId);

            model.Entity<CreatureDamageType>()
                .HasOne(cd => cd.Creature).WithMany(c => c.DamageTypes).HasForeignKey(cd => cd.CreatureId);
            model.Entity<CreatureDamageType>()
                .HasOne(cd => cd.DamageType).WithMany(d => d.CreatureDamageTypes).HasForeignKey(cd => cd.DamageTypeId);

            model.Entity<CreatureSense>()
                .HasOne(cs => cs.Creature).WithMany(c => c.Senses).HasForeignKey(cs => cs.CreatureId);
            model.Entity<CreatureSense>()
                .HasOne(cs => cs.Sense).WithMany(s => s.CreatureSenses).HasForeignKey(cs => cs.SenseId);

            model.Entity<CreatureLanguage>()
                .HasOne(cl => cl.Creature).WithMany(c => c.Languages).HasForeignKey(cl => cl.CreatureId);
            model.Entity<CreatureLanguage>()
                .HasOne(cl => cl.Language).WithMany(l => l.CreatureLanguages).HasForeignKey(cl => cl.LanguageId);

            model.Entity<CreatureSkill>()
                .HasOne(cs => cs.Creature).WithMany(c => c.Skills).HasForeignKey(cs => cs.CreatureId);
            model.Entity<CreatureSkill>()
                .HasOne(cs => cs.Skill).WithMany(s => s.CreatureSkills).HasForeignKey(cs => cs.SkillId);

            model.Entity<CreatureCondition>()
                .HasOne(cc => cc.Creature).WithMany(c => c.Conditions).HasForeignKey(cc => cc.CreatureId);
            model.Entity<CreatureCondition>()
                .HasOne(cc => cc.Condition).WithMany(c => c.CreatureConditions).HasForeignKey(cc => cc.ConditionId);

            model.Entity<SpellAction>()
                .HasOne(sa => sa.Spell).WithMany(s => s.SpellActions).HasForeignKey(sa => sa.SpellId);
            model.Entity<SpellAction>()
                .HasOne(sa => sa.Action).WithMany(a => a.SpellActions).HasForeignKey(sa => sa.ActionId);

            model.Entity<CreatureAction>()
                .HasOne(ca => ca.Creature).WithMany(c => c.Actions).HasForeignKey(ca => ca.CreatureId);
            model.Entity<CreatureAction>()
                .HasOne(ca => ca.Action).WithMany(a => a.CreatureActions).HasForeignKey(ca => ca.ActionId);

            // --- Column specifics ---
            model.Entity<CreatureEncounter>()
                .Property(p => p.Initiative)
                .HasPrecision(5, 2); // DECIMAL(5,2)

            model.Entity<ActionEntity>()
                .Property(p => p.Recharge)
                .HasColumnType("text"); // your SQL had VARCHAR (no length) → use text

            // --- Indexes (matches your CREATE INDEX statements) ---
            model.Entity<ActionEntity>()
                .HasIndex(a => a.ActionType)
                .HasDatabaseName("idx_action_type");

            model.Entity<Creature>()
                .HasIndex(c => c.OwnerUserId)
                .HasDatabaseName("idx_user_owner_creature");

            model.Entity<CreatureEncounter>()
                .HasIndex(ce => ce.DeathStatus)
                .HasDatabaseName("idx_encounter_death_status");

            model.Entity<CreatureDamageType>()
                .HasIndex(cd => cd.DamageTypeCategory)
                .HasDatabaseName("idx_damage_type_category");

            model.Entity<Skill>()
                .HasIndex(s => s.SkillType)
                .HasDatabaseName("idx_skill_type");

            // encounter_id ASC, initiative DESC
            model.Entity<CreatureEncounter>()
                .HasIndex(ce => new { ce.EncounterId, ce.Initiative })
                .HasDatabaseName("idx_initiative")
#if NET8_0_OR_GREATER
                .IsDescending(false, true);
#endif
        }
    }

}