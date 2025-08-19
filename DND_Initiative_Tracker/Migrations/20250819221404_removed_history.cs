using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DND_Initiative_Tracker.Migrations
{
    /// <inheritdoc />
    public partial class removed_history : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CampaignUsers_Campaigns_CampaignId",
                table: "CampaignUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_CampaignUsers_Users_UserId",
                table: "CampaignUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_CreatureAbilityScores_AbilityScoreTypes_AbilityScoreId",
                table: "CreatureAbilityScores");

            migrationBuilder.DropForeignKey(
                name: "FK_CreatureAbilityScores_Creatures_CreatureId",
                table: "CreatureAbilityScores");

            migrationBuilder.DropForeignKey(
                name: "FK_CreatureActions_Actions_ActionId",
                table: "CreatureActions");

            migrationBuilder.DropForeignKey(
                name: "FK_CreatureActions_Creatures_CreatureId",
                table: "CreatureActions");

            migrationBuilder.DropForeignKey(
                name: "FK_CreatureConditions_Conditions_ConditionId",
                table: "CreatureConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_CreatureConditions_Creatures_CreatureId",
                table: "CreatureConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_CreatureDamageTypes_Creatures_CreatureId",
                table: "CreatureDamageTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_CreatureDamageTypes_DamageTypes_DamageTypeId",
                table: "CreatureDamageTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_CreatureEncounters_Creatures_CreatureId",
                table: "CreatureEncounters");

            migrationBuilder.DropForeignKey(
                name: "FK_CreatureEncounters_Encounters_EncounterId",
                table: "CreatureEncounters");

            migrationBuilder.DropForeignKey(
                name: "FK_CreatureLanguages_Creatures_CreatureId",
                table: "CreatureLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_CreatureLanguages_Languages_LanguageId",
                table: "CreatureLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_Creatures_CreatureTypes_TypeId",
                table: "Creatures");

            migrationBuilder.DropForeignKey(
                name: "FK_Creatures_Users_OwnerUserId",
                table: "Creatures");

            migrationBuilder.DropForeignKey(
                name: "FK_CreatureSenses_Creatures_CreatureId",
                table: "CreatureSenses");

            migrationBuilder.DropForeignKey(
                name: "FK_CreatureSenses_Senses_SenseId",
                table: "CreatureSenses");

            migrationBuilder.DropForeignKey(
                name: "FK_CreatureSkills_Creatures_CreatureId",
                table: "CreatureSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_CreatureSkills_Skills_SkillId",
                table: "CreatureSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_CreatureSpeeds_Creatures_CreatureId",
                table: "CreatureSpeeds");

            migrationBuilder.DropForeignKey(
                name: "FK_CreatureSpeeds_Speeds_SpeedId",
                table: "CreatureSpeeds");

            migrationBuilder.DropForeignKey(
                name: "FK_Encounters_Campaigns_CampaignId",
                table: "Encounters");

            migrationBuilder.DropForeignKey(
                name: "FK_SpellActions_Actions_ActionId",
                table: "SpellActions");

            migrationBuilder.DropForeignKey(
                name: "FK_SpellActions_Spells_SpellId",
                table: "SpellActions");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Spells",
                table: "Spells");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Speeds",
                table: "Speeds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skills",
                table: "Skills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Senses",
                table: "Senses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Languages",
                table: "Languages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Encounters",
                table: "Encounters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Creatures",
                table: "Creatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Conditions",
                table: "Conditions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Campaigns",
                table: "Campaigns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actions",
                table: "Actions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SpellActions",
                table: "SpellActions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DamageTypes",
                table: "DamageTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreatureTypes",
                table: "CreatureTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreatureSpeeds",
                table: "CreatureSpeeds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreatureSkills",
                table: "CreatureSkills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreatureSenses",
                table: "CreatureSenses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreatureLanguages",
                table: "CreatureLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreatureEncounters",
                table: "CreatureEncounters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreatureDamageTypes",
                table: "CreatureDamageTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreatureConditions",
                table: "CreatureConditions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreatureActions",
                table: "CreatureActions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreatureAbilityScores",
                table: "CreatureAbilityScores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CampaignUsers",
                table: "CampaignUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbilityScoreTypes",
                table: "AbilityScoreTypes");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "Spells",
                newName: "spells");

            migrationBuilder.RenameTable(
                name: "Speeds",
                newName: "speeds");

            migrationBuilder.RenameTable(
                name: "Skills",
                newName: "skills");

            migrationBuilder.RenameTable(
                name: "Senses",
                newName: "senses");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "roles");

            migrationBuilder.RenameTable(
                name: "Languages",
                newName: "languages");

            migrationBuilder.RenameTable(
                name: "Encounters",
                newName: "encounters");

            migrationBuilder.RenameTable(
                name: "Creatures",
                newName: "creatures");

            migrationBuilder.RenameTable(
                name: "Conditions",
                newName: "conditions");

            migrationBuilder.RenameTable(
                name: "Campaigns",
                newName: "campaigns");

            migrationBuilder.RenameTable(
                name: "Actions",
                newName: "actions");

            migrationBuilder.RenameTable(
                name: "SpellActions",
                newName: "spell_actions");

            migrationBuilder.RenameTable(
                name: "DamageTypes",
                newName: "damage_types");

            migrationBuilder.RenameTable(
                name: "CreatureTypes",
                newName: "creature_types");

            migrationBuilder.RenameTable(
                name: "CreatureSpeeds",
                newName: "creature_speeds");

            migrationBuilder.RenameTable(
                name: "CreatureSkills",
                newName: "creature_skills");

            migrationBuilder.RenameTable(
                name: "CreatureSenses",
                newName: "creature_senses");

            migrationBuilder.RenameTable(
                name: "CreatureLanguages",
                newName: "creature_languages");

            migrationBuilder.RenameTable(
                name: "CreatureEncounters",
                newName: "creature_encounters");

            migrationBuilder.RenameTable(
                name: "CreatureDamageTypes",
                newName: "creature_damage_types");

            migrationBuilder.RenameTable(
                name: "CreatureConditions",
                newName: "creature_conditions");

            migrationBuilder.RenameTable(
                name: "CreatureActions",
                newName: "creature_actions");

            migrationBuilder.RenameTable(
                name: "CreatureAbilityScores",
                newName: "creature_ability_scores");

            migrationBuilder.RenameTable(
                name: "CampaignUsers",
                newName: "campaign_users");

            migrationBuilder.RenameTable(
                name: "AbilityScoreTypes",
                newName: "ability_score_types");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "users",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "users",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "users",
                newName: "role_id");

            migrationBuilder.RenameIndex(
                name: "IX_Users_RoleId",
                table: "users",
                newName: "ix_users_role_id");

            migrationBuilder.RenameColumn(
                name: "School",
                table: "spells",
                newName: "school");

            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "spells",
                newName: "duration");

            migrationBuilder.RenameColumn(
                name: "Concentration",
                table: "spells",
                newName: "concentration");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "spells",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "speeds",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "speeds",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "speeds",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "skills",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "skills",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "skills",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "SkillType",
                table: "skills",
                newName: "skill_type");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "senses",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "senses",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "senses",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "roles",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "roles",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "languages",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "languages",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "languages",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "encounters",
                newName: "notes");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "encounters",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "encounters",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "TurnCount",
                table: "encounters",
                newName: "turn_count");

            migrationBuilder.RenameColumn(
                name: "CampaignId",
                table: "encounters",
                newName: "campaign_id");

            migrationBuilder.RenameIndex(
                name: "IX_Encounters_CampaignId",
                table: "encounters",
                newName: "ix_encounters_campaign_id");

            migrationBuilder.RenameColumn(
                name: "Size",
                table: "creatures",
                newName: "size");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "creatures",
                newName: "notes");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "creatures",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Hp",
                table: "creatures",
                newName: "hp");

            migrationBuilder.RenameColumn(
                name: "Ac",
                table: "creatures",
                newName: "ac");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "creatures",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "creatures",
                newName: "type_id");

            migrationBuilder.RenameColumn(
                name: "ProficiencyBonus",
                table: "creatures",
                newName: "proficiency_bonus");

            migrationBuilder.RenameColumn(
                name: "OwnerUserId",
                table: "creatures",
                newName: "owner_user_id");

            migrationBuilder.RenameColumn(
                name: "LegendaryActionCharges",
                table: "creatures",
                newName: "legendary_action_charges");

            migrationBuilder.RenameColumn(
                name: "LairInitiative",
                table: "creatures",
                newName: "lair_initiative");

            migrationBuilder.RenameColumn(
                name: "IsNpc",
                table: "creatures",
                newName: "is_npc");

            migrationBuilder.RenameColumn(
                name: "InitiativeBonus",
                table: "creatures",
                newName: "initiative_bonus");

            migrationBuilder.RenameColumn(
                name: "HpDiceSize",
                table: "creatures",
                newName: "hp_dice_size");

            migrationBuilder.RenameColumn(
                name: "HpDiceCount",
                table: "creatures",
                newName: "hp_dice_count");

            migrationBuilder.RenameColumn(
                name: "HpDiceBonus",
                table: "creatures",
                newName: "hp_dice_bonus");

            migrationBuilder.RenameIndex(
                name: "IX_Creatures_TypeId",
                table: "creatures",
                newName: "ix_creatures_type_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "conditions",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "conditions",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "conditions",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "campaigns",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "campaigns",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "campaigns",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "VttLink",
                table: "campaigns",
                newName: "vtt_link");

            migrationBuilder.RenameColumn(
                name: "DriveLink",
                table: "campaigns",
                newName: "drive_link");

            migrationBuilder.RenameColumn(
                name: "Recharge",
                table: "actions",
                newName: "recharge");

            migrationBuilder.RenameColumn(
                name: "Reach",
                table: "actions",
                newName: "reach");

            migrationBuilder.RenameColumn(
                name: "Range",
                table: "actions",
                newName: "range");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "actions",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "actions",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Area",
                table: "actions",
                newName: "area");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "actions",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "SaveDc",
                table: "actions",
                newName: "save_dc");

            migrationBuilder.RenameColumn(
                name: "AttackBonus",
                table: "actions",
                newName: "attack_bonus");

            migrationBuilder.RenameColumn(
                name: "ActionType",
                table: "actions",
                newName: "action_type");

            migrationBuilder.RenameColumn(
                name: "ActionId",
                table: "spell_actions",
                newName: "action_id");

            migrationBuilder.RenameColumn(
                name: "SpellId",
                table: "spell_actions",
                newName: "spell_id");

            migrationBuilder.RenameIndex(
                name: "IX_SpellActions_ActionId",
                table: "spell_actions",
                newName: "ix_spell_actions_action_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "damage_types",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "damage_types",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "creature_types",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "creature_types",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "creature_types",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "SpeedValue",
                table: "creature_speeds",
                newName: "speed_value");

            migrationBuilder.RenameColumn(
                name: "IsHover",
                table: "creature_speeds",
                newName: "is_hover");

            migrationBuilder.RenameColumn(
                name: "SpeedId",
                table: "creature_speeds",
                newName: "speed_id");

            migrationBuilder.RenameColumn(
                name: "CreatureId",
                table: "creature_speeds",
                newName: "creature_id");

            migrationBuilder.RenameIndex(
                name: "IX_CreatureSpeeds_SpeedId",
                table: "creature_speeds",
                newName: "ix_creature_speeds_speed_id");

            migrationBuilder.RenameColumn(
                name: "IsProficient",
                table: "creature_skills",
                newName: "is_proficient");

            migrationBuilder.RenameColumn(
                name: "IsExpertise",
                table: "creature_skills",
                newName: "is_expertise");

            migrationBuilder.RenameColumn(
                name: "BonusOverride",
                table: "creature_skills",
                newName: "bonus_override");

            migrationBuilder.RenameColumn(
                name: "SkillId",
                table: "creature_skills",
                newName: "skill_id");

            migrationBuilder.RenameColumn(
                name: "CreatureId",
                table: "creature_skills",
                newName: "creature_id");

            migrationBuilder.RenameIndex(
                name: "IX_CreatureSkills_SkillId",
                table: "creature_skills",
                newName: "ix_creature_skills_skill_id");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "creature_senses",
                newName: "notes");

            migrationBuilder.RenameColumn(
                name: "Distance",
                table: "creature_senses",
                newName: "distance");

            migrationBuilder.RenameColumn(
                name: "SenseId",
                table: "creature_senses",
                newName: "sense_id");

            migrationBuilder.RenameColumn(
                name: "CreatureId",
                table: "creature_senses",
                newName: "creature_id");

            migrationBuilder.RenameIndex(
                name: "IX_CreatureSenses_SenseId",
                table: "creature_senses",
                newName: "ix_creature_senses_sense_id");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "creature_languages",
                newName: "notes");

            migrationBuilder.RenameColumn(
                name: "LanguageId",
                table: "creature_languages",
                newName: "language_id");

            migrationBuilder.RenameColumn(
                name: "CreatureId",
                table: "creature_languages",
                newName: "creature_id");

            migrationBuilder.RenameIndex(
                name: "IX_CreatureLanguages_LanguageId",
                table: "creature_languages",
                newName: "ix_creature_languages_language_id");

            migrationBuilder.RenameColumn(
                name: "Initiative",
                table: "creature_encounters",
                newName: "initiative");

            migrationBuilder.RenameColumn(
                name: "TempHp",
                table: "creature_encounters",
                newName: "temp_hp");

            migrationBuilder.RenameColumn(
                name: "DeathStatus",
                table: "creature_encounters",
                newName: "death_status");

            migrationBuilder.RenameColumn(
                name: "CurrentHp",
                table: "creature_encounters",
                newName: "current_hp");

            migrationBuilder.RenameColumn(
                name: "EncounterId",
                table: "creature_encounters",
                newName: "encounter_id");

            migrationBuilder.RenameColumn(
                name: "CreatureId",
                table: "creature_encounters",
                newName: "creature_id");

            migrationBuilder.RenameColumn(
                name: "DamageTypeCategory",
                table: "creature_damage_types",
                newName: "damage_type_category");

            migrationBuilder.RenameColumn(
                name: "DamageTypeId",
                table: "creature_damage_types",
                newName: "damage_type_id");

            migrationBuilder.RenameColumn(
                name: "CreatureId",
                table: "creature_damage_types",
                newName: "creature_id");

            migrationBuilder.RenameIndex(
                name: "IX_CreatureDamageTypes_DamageTypeId",
                table: "creature_damage_types",
                newName: "ix_creature_damage_types_damage_type_id");

            migrationBuilder.RenameColumn(
                name: "ConditionLength",
                table: "creature_conditions",
                newName: "condition_length");

            migrationBuilder.RenameColumn(
                name: "ConditionId",
                table: "creature_conditions",
                newName: "condition_id");

            migrationBuilder.RenameColumn(
                name: "CreatureId",
                table: "creature_conditions",
                newName: "creature_id");

            migrationBuilder.RenameIndex(
                name: "IX_CreatureConditions_ConditionId",
                table: "creature_conditions",
                newName: "ix_creature_conditions_condition_id");

            migrationBuilder.RenameColumn(
                name: "SpellPrepared",
                table: "creature_actions",
                newName: "spell_prepared");

            migrationBuilder.RenameColumn(
                name: "ActionId",
                table: "creature_actions",
                newName: "action_id");

            migrationBuilder.RenameColumn(
                name: "CreatureId",
                table: "creature_actions",
                newName: "creature_id");

            migrationBuilder.RenameIndex(
                name: "IX_CreatureActions_ActionId",
                table: "creature_actions",
                newName: "ix_creature_actions_action_id");

            migrationBuilder.RenameColumn(
                name: "Score",
                table: "creature_ability_scores",
                newName: "score");

            migrationBuilder.RenameColumn(
                name: "IsSavingThrowProficient",
                table: "creature_ability_scores",
                newName: "is_saving_throw_proficient");

            migrationBuilder.RenameColumn(
                name: "AbilityScoreId",
                table: "creature_ability_scores",
                newName: "ability_score_id");

            migrationBuilder.RenameColumn(
                name: "CreatureId",
                table: "creature_ability_scores",
                newName: "creature_id");

            migrationBuilder.RenameIndex(
                name: "IX_CreatureAbilityScores_AbilityScoreId",
                table: "creature_ability_scores",
                newName: "ix_creature_ability_scores_ability_score_id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "campaign_users",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "CampaignId",
                table: "campaign_users",
                newName: "campaign_id");

            migrationBuilder.RenameIndex(
                name: "IX_CampaignUsers_UserId",
                table: "campaign_users",
                newName: "ix_campaign_users_user_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ability_score_types",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ability_score_types",
                newName: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_users",
                table: "users",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_spells",
                table: "spells",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_speeds",
                table: "speeds",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_skills",
                table: "skills",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_senses",
                table: "senses",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_roles",
                table: "roles",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_languages",
                table: "languages",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_encounters",
                table: "encounters",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_creatures",
                table: "creatures",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_conditions",
                table: "conditions",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_campaigns",
                table: "campaigns",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_actions",
                table: "actions",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_spell_actions",
                table: "spell_actions",
                columns: new[] { "spell_id", "action_id" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_damage_types",
                table: "damage_types",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_creature_types",
                table: "creature_types",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_creature_speeds",
                table: "creature_speeds",
                columns: new[] { "creature_id", "speed_id" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_creature_skills",
                table: "creature_skills",
                columns: new[] { "creature_id", "skill_id" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_creature_senses",
                table: "creature_senses",
                columns: new[] { "creature_id", "sense_id" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_creature_languages",
                table: "creature_languages",
                columns: new[] { "creature_id", "language_id" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_creature_encounters",
                table: "creature_encounters",
                columns: new[] { "creature_id", "encounter_id" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_creature_damage_types",
                table: "creature_damage_types",
                columns: new[] { "creature_id", "damage_type_id" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_creature_conditions",
                table: "creature_conditions",
                columns: new[] { "creature_id", "condition_id" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_creature_actions",
                table: "creature_actions",
                columns: new[] { "creature_id", "action_id" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_creature_ability_scores",
                table: "creature_ability_scores",
                columns: new[] { "creature_id", "ability_score_id" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_campaign_users",
                table: "campaign_users",
                columns: new[] { "campaign_id", "user_id" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_ability_score_types",
                table: "ability_score_types",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_campaign_users_campaigns_campaign_id",
                table: "campaign_users",
                column: "campaign_id",
                principalTable: "campaigns",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_campaign_users_users_user_id",
                table: "campaign_users",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_creature_ability_scores_ability_score_types_ability_score_id",
                table: "creature_ability_scores",
                column: "ability_score_id",
                principalTable: "ability_score_types",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_creature_ability_scores_creatures_creature_id",
                table: "creature_ability_scores",
                column: "creature_id",
                principalTable: "creatures",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_creature_actions_actions_action_id",
                table: "creature_actions",
                column: "action_id",
                principalTable: "actions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_creature_actions_creatures_creature_id",
                table: "creature_actions",
                column: "creature_id",
                principalTable: "creatures",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_creature_conditions_conditions_condition_id",
                table: "creature_conditions",
                column: "condition_id",
                principalTable: "conditions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_creature_conditions_creatures_creature_id",
                table: "creature_conditions",
                column: "creature_id",
                principalTable: "creatures",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_creature_damage_types_creatures_creature_id",
                table: "creature_damage_types",
                column: "creature_id",
                principalTable: "creatures",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_creature_damage_types_damage_types_damage_type_id",
                table: "creature_damage_types",
                column: "damage_type_id",
                principalTable: "damage_types",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_creature_encounters_creatures_creature_id",
                table: "creature_encounters",
                column: "creature_id",
                principalTable: "creatures",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_creature_encounters_encounters_encounter_id",
                table: "creature_encounters",
                column: "encounter_id",
                principalTable: "encounters",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_creature_languages_creatures_creature_id",
                table: "creature_languages",
                column: "creature_id",
                principalTable: "creatures",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_creature_languages_languages_language_id",
                table: "creature_languages",
                column: "language_id",
                principalTable: "languages",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_creature_senses_creatures_creature_id",
                table: "creature_senses",
                column: "creature_id",
                principalTable: "creatures",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_creature_senses_senses_sense_id",
                table: "creature_senses",
                column: "sense_id",
                principalTable: "senses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_creature_skills_creatures_creature_id",
                table: "creature_skills",
                column: "creature_id",
                principalTable: "creatures",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_creature_skills_skills_skill_id",
                table: "creature_skills",
                column: "skill_id",
                principalTable: "skills",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_creature_speeds_creatures_creature_id",
                table: "creature_speeds",
                column: "creature_id",
                principalTable: "creatures",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_creature_speeds_speeds_speed_id",
                table: "creature_speeds",
                column: "speed_id",
                principalTable: "speeds",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_creatures_creature_types_type_id",
                table: "creatures",
                column: "type_id",
                principalTable: "creature_types",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_creatures_users_owner_user_id",
                table: "creatures",
                column: "owner_user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "fk_encounters_campaigns_campaign_id",
                table: "encounters",
                column: "campaign_id",
                principalTable: "campaigns",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_spell_actions_actions_action_id",
                table: "spell_actions",
                column: "action_id",
                principalTable: "actions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_spell_actions_spells_spell_id",
                table: "spell_actions",
                column: "spell_id",
                principalTable: "spells",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_users_roles_role_id",
                table: "users",
                column: "role_id",
                principalTable: "roles",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_campaign_users_campaigns_campaign_id",
                table: "campaign_users");

            migrationBuilder.DropForeignKey(
                name: "fk_campaign_users_users_user_id",
                table: "campaign_users");

            migrationBuilder.DropForeignKey(
                name: "fk_creature_ability_scores_ability_score_types_ability_score_id",
                table: "creature_ability_scores");

            migrationBuilder.DropForeignKey(
                name: "fk_creature_ability_scores_creatures_creature_id",
                table: "creature_ability_scores");

            migrationBuilder.DropForeignKey(
                name: "fk_creature_actions_actions_action_id",
                table: "creature_actions");

            migrationBuilder.DropForeignKey(
                name: "fk_creature_actions_creatures_creature_id",
                table: "creature_actions");

            migrationBuilder.DropForeignKey(
                name: "fk_creature_conditions_conditions_condition_id",
                table: "creature_conditions");

            migrationBuilder.DropForeignKey(
                name: "fk_creature_conditions_creatures_creature_id",
                table: "creature_conditions");

            migrationBuilder.DropForeignKey(
                name: "fk_creature_damage_types_creatures_creature_id",
                table: "creature_damage_types");

            migrationBuilder.DropForeignKey(
                name: "fk_creature_damage_types_damage_types_damage_type_id",
                table: "creature_damage_types");

            migrationBuilder.DropForeignKey(
                name: "fk_creature_encounters_creatures_creature_id",
                table: "creature_encounters");

            migrationBuilder.DropForeignKey(
                name: "fk_creature_encounters_encounters_encounter_id",
                table: "creature_encounters");

            migrationBuilder.DropForeignKey(
                name: "fk_creature_languages_creatures_creature_id",
                table: "creature_languages");

            migrationBuilder.DropForeignKey(
                name: "fk_creature_languages_languages_language_id",
                table: "creature_languages");

            migrationBuilder.DropForeignKey(
                name: "fk_creature_senses_creatures_creature_id",
                table: "creature_senses");

            migrationBuilder.DropForeignKey(
                name: "fk_creature_senses_senses_sense_id",
                table: "creature_senses");

            migrationBuilder.DropForeignKey(
                name: "fk_creature_skills_creatures_creature_id",
                table: "creature_skills");

            migrationBuilder.DropForeignKey(
                name: "fk_creature_skills_skills_skill_id",
                table: "creature_skills");

            migrationBuilder.DropForeignKey(
                name: "fk_creature_speeds_creatures_creature_id",
                table: "creature_speeds");

            migrationBuilder.DropForeignKey(
                name: "fk_creature_speeds_speeds_speed_id",
                table: "creature_speeds");

            migrationBuilder.DropForeignKey(
                name: "fk_creatures_creature_types_type_id",
                table: "creatures");

            migrationBuilder.DropForeignKey(
                name: "fk_creatures_users_owner_user_id",
                table: "creatures");

            migrationBuilder.DropForeignKey(
                name: "fk_encounters_campaigns_campaign_id",
                table: "encounters");

            migrationBuilder.DropForeignKey(
                name: "fk_spell_actions_actions_action_id",
                table: "spell_actions");

            migrationBuilder.DropForeignKey(
                name: "fk_spell_actions_spells_spell_id",
                table: "spell_actions");

            migrationBuilder.DropForeignKey(
                name: "fk_users_roles_role_id",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "pk_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "pk_spells",
                table: "spells");

            migrationBuilder.DropPrimaryKey(
                name: "pk_speeds",
                table: "speeds");

            migrationBuilder.DropPrimaryKey(
                name: "pk_skills",
                table: "skills");

            migrationBuilder.DropPrimaryKey(
                name: "pk_senses",
                table: "senses");

            migrationBuilder.DropPrimaryKey(
                name: "pk_roles",
                table: "roles");

            migrationBuilder.DropPrimaryKey(
                name: "pk_languages",
                table: "languages");

            migrationBuilder.DropPrimaryKey(
                name: "pk_encounters",
                table: "encounters");

            migrationBuilder.DropPrimaryKey(
                name: "pk_creatures",
                table: "creatures");

            migrationBuilder.DropPrimaryKey(
                name: "pk_conditions",
                table: "conditions");

            migrationBuilder.DropPrimaryKey(
                name: "pk_campaigns",
                table: "campaigns");

            migrationBuilder.DropPrimaryKey(
                name: "pk_actions",
                table: "actions");

            migrationBuilder.DropPrimaryKey(
                name: "pk_spell_actions",
                table: "spell_actions");

            migrationBuilder.DropPrimaryKey(
                name: "pk_damage_types",
                table: "damage_types");

            migrationBuilder.DropPrimaryKey(
                name: "pk_creature_types",
                table: "creature_types");

            migrationBuilder.DropPrimaryKey(
                name: "pk_creature_speeds",
                table: "creature_speeds");

            migrationBuilder.DropPrimaryKey(
                name: "pk_creature_skills",
                table: "creature_skills");

            migrationBuilder.DropPrimaryKey(
                name: "pk_creature_senses",
                table: "creature_senses");

            migrationBuilder.DropPrimaryKey(
                name: "pk_creature_languages",
                table: "creature_languages");

            migrationBuilder.DropPrimaryKey(
                name: "pk_creature_encounters",
                table: "creature_encounters");

            migrationBuilder.DropPrimaryKey(
                name: "pk_creature_damage_types",
                table: "creature_damage_types");

            migrationBuilder.DropPrimaryKey(
                name: "pk_creature_conditions",
                table: "creature_conditions");

            migrationBuilder.DropPrimaryKey(
                name: "pk_creature_actions",
                table: "creature_actions");

            migrationBuilder.DropPrimaryKey(
                name: "pk_creature_ability_scores",
                table: "creature_ability_scores");

            migrationBuilder.DropPrimaryKey(
                name: "pk_campaign_users",
                table: "campaign_users");

            migrationBuilder.DropPrimaryKey(
                name: "pk_ability_score_types",
                table: "ability_score_types");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "spells",
                newName: "Spells");

            migrationBuilder.RenameTable(
                name: "speeds",
                newName: "Speeds");

            migrationBuilder.RenameTable(
                name: "skills",
                newName: "Skills");

            migrationBuilder.RenameTable(
                name: "senses",
                newName: "Senses");

            migrationBuilder.RenameTable(
                name: "roles",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "languages",
                newName: "Languages");

            migrationBuilder.RenameTable(
                name: "encounters",
                newName: "Encounters");

            migrationBuilder.RenameTable(
                name: "creatures",
                newName: "Creatures");

            migrationBuilder.RenameTable(
                name: "conditions",
                newName: "Conditions");

            migrationBuilder.RenameTable(
                name: "campaigns",
                newName: "Campaigns");

            migrationBuilder.RenameTable(
                name: "actions",
                newName: "Actions");

            migrationBuilder.RenameTable(
                name: "spell_actions",
                newName: "SpellActions");

            migrationBuilder.RenameTable(
                name: "damage_types",
                newName: "DamageTypes");

            migrationBuilder.RenameTable(
                name: "creature_types",
                newName: "CreatureTypes");

            migrationBuilder.RenameTable(
                name: "creature_speeds",
                newName: "CreatureSpeeds");

            migrationBuilder.RenameTable(
                name: "creature_skills",
                newName: "CreatureSkills");

            migrationBuilder.RenameTable(
                name: "creature_senses",
                newName: "CreatureSenses");

            migrationBuilder.RenameTable(
                name: "creature_languages",
                newName: "CreatureLanguages");

            migrationBuilder.RenameTable(
                name: "creature_encounters",
                newName: "CreatureEncounters");

            migrationBuilder.RenameTable(
                name: "creature_damage_types",
                newName: "CreatureDamageTypes");

            migrationBuilder.RenameTable(
                name: "creature_conditions",
                newName: "CreatureConditions");

            migrationBuilder.RenameTable(
                name: "creature_actions",
                newName: "CreatureActions");

            migrationBuilder.RenameTable(
                name: "creature_ability_scores",
                newName: "CreatureAbilityScores");

            migrationBuilder.RenameTable(
                name: "campaign_users",
                newName: "CampaignUsers");

            migrationBuilder.RenameTable(
                name: "ability_score_types",
                newName: "AbilityScoreTypes");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "role_id",
                table: "Users",
                newName: "RoleId");

            migrationBuilder.RenameIndex(
                name: "ix_users_role_id",
                table: "Users",
                newName: "IX_Users_RoleId");

            migrationBuilder.RenameColumn(
                name: "school",
                table: "Spells",
                newName: "School");

            migrationBuilder.RenameColumn(
                name: "duration",
                table: "Spells",
                newName: "Duration");

            migrationBuilder.RenameColumn(
                name: "concentration",
                table: "Spells",
                newName: "Concentration");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Spells",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Speeds",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Speeds",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Speeds",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Skills",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Skills",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Skills",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "skill_type",
                table: "Skills",
                newName: "SkillType");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Senses",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Senses",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Senses",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Roles",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Roles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Languages",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Languages",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Languages",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "notes",
                table: "Encounters",
                newName: "Notes");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Encounters",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Encounters",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "turn_count",
                table: "Encounters",
                newName: "TurnCount");

            migrationBuilder.RenameColumn(
                name: "campaign_id",
                table: "Encounters",
                newName: "CampaignId");

            migrationBuilder.RenameIndex(
                name: "ix_encounters_campaign_id",
                table: "Encounters",
                newName: "IX_Encounters_CampaignId");

            migrationBuilder.RenameColumn(
                name: "size",
                table: "Creatures",
                newName: "Size");

            migrationBuilder.RenameColumn(
                name: "notes",
                table: "Creatures",
                newName: "Notes");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Creatures",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "hp",
                table: "Creatures",
                newName: "Hp");

            migrationBuilder.RenameColumn(
                name: "ac",
                table: "Creatures",
                newName: "Ac");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Creatures",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "type_id",
                table: "Creatures",
                newName: "TypeId");

            migrationBuilder.RenameColumn(
                name: "proficiency_bonus",
                table: "Creatures",
                newName: "ProficiencyBonus");

            migrationBuilder.RenameColumn(
                name: "owner_user_id",
                table: "Creatures",
                newName: "OwnerUserId");

            migrationBuilder.RenameColumn(
                name: "legendary_action_charges",
                table: "Creatures",
                newName: "LegendaryActionCharges");

            migrationBuilder.RenameColumn(
                name: "lair_initiative",
                table: "Creatures",
                newName: "LairInitiative");

            migrationBuilder.RenameColumn(
                name: "is_npc",
                table: "Creatures",
                newName: "IsNpc");

            migrationBuilder.RenameColumn(
                name: "initiative_bonus",
                table: "Creatures",
                newName: "InitiativeBonus");

            migrationBuilder.RenameColumn(
                name: "hp_dice_size",
                table: "Creatures",
                newName: "HpDiceSize");

            migrationBuilder.RenameColumn(
                name: "hp_dice_count",
                table: "Creatures",
                newName: "HpDiceCount");

            migrationBuilder.RenameColumn(
                name: "hp_dice_bonus",
                table: "Creatures",
                newName: "HpDiceBonus");

            migrationBuilder.RenameIndex(
                name: "ix_creatures_type_id",
                table: "Creatures",
                newName: "IX_Creatures_TypeId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Conditions",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Conditions",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Conditions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Campaigns",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Campaigns",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Campaigns",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "vtt_link",
                table: "Campaigns",
                newName: "VttLink");

            migrationBuilder.RenameColumn(
                name: "drive_link",
                table: "Campaigns",
                newName: "DriveLink");

            migrationBuilder.RenameColumn(
                name: "recharge",
                table: "Actions",
                newName: "Recharge");

            migrationBuilder.RenameColumn(
                name: "reach",
                table: "Actions",
                newName: "Reach");

            migrationBuilder.RenameColumn(
                name: "range",
                table: "Actions",
                newName: "Range");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Actions",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Actions",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "area",
                table: "Actions",
                newName: "Area");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Actions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "save_dc",
                table: "Actions",
                newName: "SaveDc");

            migrationBuilder.RenameColumn(
                name: "attack_bonus",
                table: "Actions",
                newName: "AttackBonus");

            migrationBuilder.RenameColumn(
                name: "action_type",
                table: "Actions",
                newName: "ActionType");

            migrationBuilder.RenameColumn(
                name: "action_id",
                table: "SpellActions",
                newName: "ActionId");

            migrationBuilder.RenameColumn(
                name: "spell_id",
                table: "SpellActions",
                newName: "SpellId");

            migrationBuilder.RenameIndex(
                name: "ix_spell_actions_action_id",
                table: "SpellActions",
                newName: "IX_SpellActions_ActionId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "DamageTypes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "DamageTypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "CreatureTypes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "CreatureTypes",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CreatureTypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "speed_value",
                table: "CreatureSpeeds",
                newName: "SpeedValue");

            migrationBuilder.RenameColumn(
                name: "is_hover",
                table: "CreatureSpeeds",
                newName: "IsHover");

            migrationBuilder.RenameColumn(
                name: "speed_id",
                table: "CreatureSpeeds",
                newName: "SpeedId");

            migrationBuilder.RenameColumn(
                name: "creature_id",
                table: "CreatureSpeeds",
                newName: "CreatureId");

            migrationBuilder.RenameIndex(
                name: "ix_creature_speeds_speed_id",
                table: "CreatureSpeeds",
                newName: "IX_CreatureSpeeds_SpeedId");

            migrationBuilder.RenameColumn(
                name: "is_proficient",
                table: "CreatureSkills",
                newName: "IsProficient");

            migrationBuilder.RenameColumn(
                name: "is_expertise",
                table: "CreatureSkills",
                newName: "IsExpertise");

            migrationBuilder.RenameColumn(
                name: "bonus_override",
                table: "CreatureSkills",
                newName: "BonusOverride");

            migrationBuilder.RenameColumn(
                name: "skill_id",
                table: "CreatureSkills",
                newName: "SkillId");

            migrationBuilder.RenameColumn(
                name: "creature_id",
                table: "CreatureSkills",
                newName: "CreatureId");

            migrationBuilder.RenameIndex(
                name: "ix_creature_skills_skill_id",
                table: "CreatureSkills",
                newName: "IX_CreatureSkills_SkillId");

            migrationBuilder.RenameColumn(
                name: "notes",
                table: "CreatureSenses",
                newName: "Notes");

            migrationBuilder.RenameColumn(
                name: "distance",
                table: "CreatureSenses",
                newName: "Distance");

            migrationBuilder.RenameColumn(
                name: "sense_id",
                table: "CreatureSenses",
                newName: "SenseId");

            migrationBuilder.RenameColumn(
                name: "creature_id",
                table: "CreatureSenses",
                newName: "CreatureId");

            migrationBuilder.RenameIndex(
                name: "ix_creature_senses_sense_id",
                table: "CreatureSenses",
                newName: "IX_CreatureSenses_SenseId");

            migrationBuilder.RenameColumn(
                name: "notes",
                table: "CreatureLanguages",
                newName: "Notes");

            migrationBuilder.RenameColumn(
                name: "language_id",
                table: "CreatureLanguages",
                newName: "LanguageId");

            migrationBuilder.RenameColumn(
                name: "creature_id",
                table: "CreatureLanguages",
                newName: "CreatureId");

            migrationBuilder.RenameIndex(
                name: "ix_creature_languages_language_id",
                table: "CreatureLanguages",
                newName: "IX_CreatureLanguages_LanguageId");

            migrationBuilder.RenameColumn(
                name: "initiative",
                table: "CreatureEncounters",
                newName: "Initiative");

            migrationBuilder.RenameColumn(
                name: "temp_hp",
                table: "CreatureEncounters",
                newName: "TempHp");

            migrationBuilder.RenameColumn(
                name: "death_status",
                table: "CreatureEncounters",
                newName: "DeathStatus");

            migrationBuilder.RenameColumn(
                name: "current_hp",
                table: "CreatureEncounters",
                newName: "CurrentHp");

            migrationBuilder.RenameColumn(
                name: "encounter_id",
                table: "CreatureEncounters",
                newName: "EncounterId");

            migrationBuilder.RenameColumn(
                name: "creature_id",
                table: "CreatureEncounters",
                newName: "CreatureId");

            migrationBuilder.RenameColumn(
                name: "damage_type_category",
                table: "CreatureDamageTypes",
                newName: "DamageTypeCategory");

            migrationBuilder.RenameColumn(
                name: "damage_type_id",
                table: "CreatureDamageTypes",
                newName: "DamageTypeId");

            migrationBuilder.RenameColumn(
                name: "creature_id",
                table: "CreatureDamageTypes",
                newName: "CreatureId");

            migrationBuilder.RenameIndex(
                name: "ix_creature_damage_types_damage_type_id",
                table: "CreatureDamageTypes",
                newName: "IX_CreatureDamageTypes_DamageTypeId");

            migrationBuilder.RenameColumn(
                name: "condition_length",
                table: "CreatureConditions",
                newName: "ConditionLength");

            migrationBuilder.RenameColumn(
                name: "condition_id",
                table: "CreatureConditions",
                newName: "ConditionId");

            migrationBuilder.RenameColumn(
                name: "creature_id",
                table: "CreatureConditions",
                newName: "CreatureId");

            migrationBuilder.RenameIndex(
                name: "ix_creature_conditions_condition_id",
                table: "CreatureConditions",
                newName: "IX_CreatureConditions_ConditionId");

            migrationBuilder.RenameColumn(
                name: "spell_prepared",
                table: "CreatureActions",
                newName: "SpellPrepared");

            migrationBuilder.RenameColumn(
                name: "action_id",
                table: "CreatureActions",
                newName: "ActionId");

            migrationBuilder.RenameColumn(
                name: "creature_id",
                table: "CreatureActions",
                newName: "CreatureId");

            migrationBuilder.RenameIndex(
                name: "ix_creature_actions_action_id",
                table: "CreatureActions",
                newName: "IX_CreatureActions_ActionId");

            migrationBuilder.RenameColumn(
                name: "score",
                table: "CreatureAbilityScores",
                newName: "Score");

            migrationBuilder.RenameColumn(
                name: "is_saving_throw_proficient",
                table: "CreatureAbilityScores",
                newName: "IsSavingThrowProficient");

            migrationBuilder.RenameColumn(
                name: "ability_score_id",
                table: "CreatureAbilityScores",
                newName: "AbilityScoreId");

            migrationBuilder.RenameColumn(
                name: "creature_id",
                table: "CreatureAbilityScores",
                newName: "CreatureId");

            migrationBuilder.RenameIndex(
                name: "ix_creature_ability_scores_ability_score_id",
                table: "CreatureAbilityScores",
                newName: "IX_CreatureAbilityScores_AbilityScoreId");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "CampaignUsers",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "campaign_id",
                table: "CampaignUsers",
                newName: "CampaignId");

            migrationBuilder.RenameIndex(
                name: "ix_campaign_users_user_id",
                table: "CampaignUsers",
                newName: "IX_CampaignUsers_UserId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "AbilityScoreTypes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "AbilityScoreTypes",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Spells",
                table: "Spells",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Speeds",
                table: "Speeds",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skills",
                table: "Skills",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Senses",
                table: "Senses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Languages",
                table: "Languages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Encounters",
                table: "Encounters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Creatures",
                table: "Creatures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Conditions",
                table: "Conditions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Campaigns",
                table: "Campaigns",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actions",
                table: "Actions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpellActions",
                table: "SpellActions",
                columns: new[] { "SpellId", "ActionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DamageTypes",
                table: "DamageTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreatureTypes",
                table: "CreatureTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreatureSpeeds",
                table: "CreatureSpeeds",
                columns: new[] { "CreatureId", "SpeedId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreatureSkills",
                table: "CreatureSkills",
                columns: new[] { "CreatureId", "SkillId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreatureSenses",
                table: "CreatureSenses",
                columns: new[] { "CreatureId", "SenseId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreatureLanguages",
                table: "CreatureLanguages",
                columns: new[] { "CreatureId", "LanguageId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreatureEncounters",
                table: "CreatureEncounters",
                columns: new[] { "CreatureId", "EncounterId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreatureDamageTypes",
                table: "CreatureDamageTypes",
                columns: new[] { "CreatureId", "DamageTypeId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreatureConditions",
                table: "CreatureConditions",
                columns: new[] { "CreatureId", "ConditionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreatureActions",
                table: "CreatureActions",
                columns: new[] { "CreatureId", "ActionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreatureAbilityScores",
                table: "CreatureAbilityScores",
                columns: new[] { "CreatureId", "AbilityScoreId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CampaignUsers",
                table: "CampaignUsers",
                columns: new[] { "CampaignId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbilityScoreTypes",
                table: "AbilityScoreTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CampaignUsers_Campaigns_CampaignId",
                table: "CampaignUsers",
                column: "CampaignId",
                principalTable: "Campaigns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CampaignUsers_Users_UserId",
                table: "CampaignUsers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreatureAbilityScores_AbilityScoreTypes_AbilityScoreId",
                table: "CreatureAbilityScores",
                column: "AbilityScoreId",
                principalTable: "AbilityScoreTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreatureAbilityScores_Creatures_CreatureId",
                table: "CreatureAbilityScores",
                column: "CreatureId",
                principalTable: "Creatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreatureActions_Actions_ActionId",
                table: "CreatureActions",
                column: "ActionId",
                principalTable: "Actions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreatureActions_Creatures_CreatureId",
                table: "CreatureActions",
                column: "CreatureId",
                principalTable: "Creatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreatureConditions_Conditions_ConditionId",
                table: "CreatureConditions",
                column: "ConditionId",
                principalTable: "Conditions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreatureConditions_Creatures_CreatureId",
                table: "CreatureConditions",
                column: "CreatureId",
                principalTable: "Creatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreatureDamageTypes_Creatures_CreatureId",
                table: "CreatureDamageTypes",
                column: "CreatureId",
                principalTable: "Creatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreatureDamageTypes_DamageTypes_DamageTypeId",
                table: "CreatureDamageTypes",
                column: "DamageTypeId",
                principalTable: "DamageTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreatureEncounters_Creatures_CreatureId",
                table: "CreatureEncounters",
                column: "CreatureId",
                principalTable: "Creatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreatureEncounters_Encounters_EncounterId",
                table: "CreatureEncounters",
                column: "EncounterId",
                principalTable: "Encounters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreatureLanguages_Creatures_CreatureId",
                table: "CreatureLanguages",
                column: "CreatureId",
                principalTable: "Creatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreatureLanguages_Languages_LanguageId",
                table: "CreatureLanguages",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Creatures_CreatureTypes_TypeId",
                table: "Creatures",
                column: "TypeId",
                principalTable: "CreatureTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Creatures_Users_OwnerUserId",
                table: "Creatures",
                column: "OwnerUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_CreatureSenses_Creatures_CreatureId",
                table: "CreatureSenses",
                column: "CreatureId",
                principalTable: "Creatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreatureSenses_Senses_SenseId",
                table: "CreatureSenses",
                column: "SenseId",
                principalTable: "Senses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreatureSkills_Creatures_CreatureId",
                table: "CreatureSkills",
                column: "CreatureId",
                principalTable: "Creatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreatureSkills_Skills_SkillId",
                table: "CreatureSkills",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreatureSpeeds_Creatures_CreatureId",
                table: "CreatureSpeeds",
                column: "CreatureId",
                principalTable: "Creatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CreatureSpeeds_Speeds_SpeedId",
                table: "CreatureSpeeds",
                column: "SpeedId",
                principalTable: "Speeds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Encounters_Campaigns_CampaignId",
                table: "Encounters",
                column: "CampaignId",
                principalTable: "Campaigns",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SpellActions_Actions_ActionId",
                table: "SpellActions",
                column: "ActionId",
                principalTable: "Actions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SpellActions_Spells_SpellId",
                table: "SpellActions",
                column: "SpellId",
                principalTable: "Spells",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
