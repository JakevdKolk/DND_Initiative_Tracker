using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DND_Initiative_Tracker.Migrations
{
    /// <inheritdoc />
    public partial class added_enums_and_migrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_campaign_user_app_user_user_id",
                table: "campaign_user");

            migrationBuilder.DropForeignKey(
                name: "FK_campaign_user_campaign_campaign_id",
                table: "campaign_user");

            migrationBuilder.DropForeignKey(
                name: "FK_creature_app_user_owner_user_id",
                table: "creature");

            migrationBuilder.DropForeignKey(
                name: "FK_creature_creature_type_type_id",
                table: "creature");

            migrationBuilder.DropForeignKey(
                name: "FK_creature_encounter_creature_creature_id",
                table: "creature_encounter");

            migrationBuilder.DropForeignKey(
                name: "FK_creature_encounter_encounter_encounter_id",
                table: "creature_encounter");

            migrationBuilder.DropForeignKey(
                name: "FK_encounter_campaign_campaign_id",
                table: "encounter");

            migrationBuilder.DropTable(
                name: "app_user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_role",
                table: "role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_encounter",
                table: "encounter");

            migrationBuilder.DropIndex(
                name: "IX_encounter_campaign_id",
                table: "encounter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_creature_type",
                table: "creature_type");

            migrationBuilder.DropPrimaryKey(
                name: "PK_creature_encounter",
                table: "creature_encounter");

            migrationBuilder.DropIndex(
                name: "IX_creature_encounter_encounter_id",
                table: "creature_encounter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_creature",
                table: "creature");

            migrationBuilder.DropIndex(
                name: "IX_creature_owner_user_id",
                table: "creature");

            migrationBuilder.DropIndex(
                name: "IX_creature_type_id",
                table: "creature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_campaign_user",
                table: "campaign_user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_campaign",
                table: "campaign");

            migrationBuilder.DropColumn(
                name: "campaign_id",
                table: "encounter");

            migrationBuilder.DropColumn(
                name: "turn_count",
                table: "encounter");

            migrationBuilder.DropColumn(
                name: "creature_id",
                table: "creature_encounter");

            migrationBuilder.DropColumn(
                name: "encounter_id",
                table: "creature_encounter");

            migrationBuilder.DropColumn(
                name: "hp_dice_bonus",
                table: "creature");

            migrationBuilder.DropColumn(
                name: "hp_dice_count",
                table: "creature");

            migrationBuilder.DropColumn(
                name: "hp_dice_size",
                table: "creature");

            migrationBuilder.DropColumn(
                name: "initiative_bonus",
                table: "creature");

            migrationBuilder.DropColumn(
                name: "is_npc",
                table: "creature");

            migrationBuilder.DropColumn(
                name: "lair_initiative",
                table: "creature");

            migrationBuilder.DropColumn(
                name: "legendary_action_charges",
                table: "creature");

            migrationBuilder.DropColumn(
                name: "owner_user_id",
                table: "creature");

            migrationBuilder.DropColumn(
                name: "profiency_bonus",
                table: "creature");

            migrationBuilder.DropColumn(
                name: "type_id",
                table: "creature");

            migrationBuilder.DropColumn(
                name: "Drive_Link",
                table: "campaign");

            migrationBuilder.DropColumn(
                name: "Vtt_link",
                table: "campaign");

            migrationBuilder.RenameTable(
                name: "role",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "encounter",
                newName: "Encounters");

            migrationBuilder.RenameTable(
                name: "creature_type",
                newName: "CreatureTypes");

            migrationBuilder.RenameTable(
                name: "creature_encounter",
                newName: "CreatureEncounters");

            migrationBuilder.RenameTable(
                name: "creature",
                newName: "Creatures");

            migrationBuilder.RenameTable(
                name: "campaign_user",
                newName: "CampaignUsers");

            migrationBuilder.RenameTable(
                name: "campaign",
                newName: "Campaigns");

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
                name: "initiative",
                table: "CreatureEncounters",
                newName: "Initiative");

            migrationBuilder.RenameColumn(
                name: "temp_hp",
                table: "CreatureEncounters",
                newName: "EncounterId");

            migrationBuilder.RenameColumn(
                name: "current_hp",
                table: "CreatureEncounters",
                newName: "CreatureId");

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
                name: "user_id",
                table: "CampaignUsers",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "campaign_id",
                table: "CampaignUsers",
                newName: "CampaignId");

            migrationBuilder.RenameIndex(
                name: "IX_campaign_user_user_id",
                table: "CampaignUsers",
                newName: "IX_CampaignUsers_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Roles",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Encounters",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Encounters",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "CampaignId",
                table: "Encounters",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TurnCount",
                table: "Encounters",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CreatureTypes",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CreatureTypes",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<decimal>(
                name: "Initiative",
                table: "CreatureEncounters",
                type: "numeric(5,2)",
                precision: 5,
                scale: 2,
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AddColumn<int>(
                name: "CurrentHp",
                table: "CreatureEncounters",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeathStatus",
                table: "CreatureEncounters",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TempHp",
                table: "CreatureEncounters",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Creatures",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Creatures",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "Hp",
                table: "Creatures",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "Ac",
                table: "Creatures",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "HpDiceBonus",
                table: "Creatures",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HpDiceCount",
                table: "Creatures",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HpDiceSize",
                table: "Creatures",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InitiativeBonus",
                table: "Creatures",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsNpc",
                table: "Creatures",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LairInitiative",
                table: "Creatures",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LegendaryActionCharges",
                table: "Creatures",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnerUserId",
                table: "Creatures",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProficiencyBonus",
                table: "Creatures",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "Creatures",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Creatures",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Campaigns",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Campaigns",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "DriveLink",
                table: "Campaigns",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VttLink",
                table: "Campaigns",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Encounters",
                table: "Encounters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreatureTypes",
                table: "CreatureTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreatureEncounters",
                table: "CreatureEncounters",
                columns: new[] { "CreatureId", "EncounterId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Creatures",
                table: "Creatures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CampaignUsers",
                table: "CampaignUsers",
                columns: new[] { "CampaignId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Campaigns",
                table: "Campaigns",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AbilityScoreTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityScoreTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Actions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ActionType = table.Column<int>(type: "integer", nullable: true),
                    Recharge = table.Column<string>(type: "text", nullable: true),
                    Reach = table.Column<int>(type: "integer", nullable: true),
                    AttackBonus = table.Column<int>(type: "integer", nullable: true),
                    Range = table.Column<int>(type: "integer", nullable: true),
                    Area = table.Column<int>(type: "integer", nullable: true),
                    SaveDc = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DamageTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Senses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Senses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SkillType = table.Column<int>(type: "integer", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Speeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speeds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    School = table.Column<string>(type: "text", nullable: true),
                    Concentration = table.Column<bool>(type: "boolean", nullable: true),
                    Duration = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CreatureAbilityScores",
                columns: table => new
                {
                    CreatureId = table.Column<int>(type: "integer", nullable: false),
                    AbilityScoreId = table.Column<int>(type: "integer", nullable: false),
                    Score = table.Column<int>(type: "integer", nullable: true),
                    IsSavingThrowProficient = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureAbilityScores", x => new { x.CreatureId, x.AbilityScoreId });
                    table.ForeignKey(
                        name: "FK_CreatureAbilityScores_AbilityScoreTypes_AbilityScoreId",
                        column: x => x.AbilityScoreId,
                        principalTable: "AbilityScoreTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreatureAbilityScores_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreatureActions",
                columns: table => new
                {
                    CreatureId = table.Column<int>(type: "integer", nullable: false),
                    ActionId = table.Column<int>(type: "integer", nullable: false),
                    SpellPrepared = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureActions", x => new { x.CreatureId, x.ActionId });
                    table.ForeignKey(
                        name: "FK_CreatureActions_Actions_ActionId",
                        column: x => x.ActionId,
                        principalTable: "Actions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreatureActions_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreatureConditions",
                columns: table => new
                {
                    CreatureId = table.Column<int>(type: "integer", nullable: false),
                    ConditionId = table.Column<int>(type: "integer", nullable: false),
                    ConditionLength = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureConditions", x => new { x.CreatureId, x.ConditionId });
                    table.ForeignKey(
                        name: "FK_CreatureConditions_Conditions_ConditionId",
                        column: x => x.ConditionId,
                        principalTable: "Conditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreatureConditions_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreatureDamageTypes",
                columns: table => new
                {
                    CreatureId = table.Column<int>(type: "integer", nullable: false),
                    DamageTypeId = table.Column<int>(type: "integer", nullable: false),
                    DamageTypeCategory = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureDamageTypes", x => new { x.CreatureId, x.DamageTypeId });
                    table.ForeignKey(
                        name: "FK_CreatureDamageTypes_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreatureDamageTypes_DamageTypes_DamageTypeId",
                        column: x => x.DamageTypeId,
                        principalTable: "DamageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreatureLanguages",
                columns: table => new
                {
                    CreatureId = table.Column<int>(type: "integer", nullable: false),
                    LanguageId = table.Column<int>(type: "integer", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureLanguages", x => new { x.CreatureId, x.LanguageId });
                    table.ForeignKey(
                        name: "FK_CreatureLanguages_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreatureLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreatureSenses",
                columns: table => new
                {
                    CreatureId = table.Column<int>(type: "integer", nullable: false),
                    SenseId = table.Column<int>(type: "integer", nullable: false),
                    Distance = table.Column<int>(type: "integer", nullable: true),
                    Notes = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureSenses", x => new { x.CreatureId, x.SenseId });
                    table.ForeignKey(
                        name: "FK_CreatureSenses_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreatureSenses_Senses_SenseId",
                        column: x => x.SenseId,
                        principalTable: "Senses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreatureSkills",
                columns: table => new
                {
                    CreatureId = table.Column<int>(type: "integer", nullable: false),
                    SkillId = table.Column<int>(type: "integer", nullable: false),
                    IsProficient = table.Column<bool>(type: "boolean", nullable: true),
                    IsExpertise = table.Column<bool>(type: "boolean", nullable: true),
                    BonusOverride = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureSkills", x => new { x.CreatureId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_CreatureSkills_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreatureSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreatureSpeeds",
                columns: table => new
                {
                    CreatureId = table.Column<int>(type: "integer", nullable: false),
                    SpeedId = table.Column<int>(type: "integer", nullable: false),
                    SpeedValue = table.Column<int>(type: "integer", nullable: true),
                    IsHover = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureSpeeds", x => new { x.CreatureId, x.SpeedId });
                    table.ForeignKey(
                        name: "FK_CreatureSpeeds_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreatureSpeeds_Speeds_SpeedId",
                        column: x => x.SpeedId,
                        principalTable: "Speeds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpellActions",
                columns: table => new
                {
                    SpellId = table.Column<int>(type: "integer", nullable: false),
                    ActionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellActions", x => new { x.SpellId, x.ActionId });
                    table.ForeignKey(
                        name: "FK_SpellActions_Actions_ActionId",
                        column: x => x.ActionId,
                        principalTable: "Actions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpellActions_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Encounters_CampaignId",
                table: "Encounters",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "idx_encounter_death_status",
                table: "CreatureEncounters",
                column: "DeathStatus");

            migrationBuilder.CreateIndex(
                name: "idx_initiative",
                table: "CreatureEncounters",
                columns: new[] { "EncounterId", "Initiative" },
                descending: new[] { false, true });

            migrationBuilder.CreateIndex(
                name: "idx_user_owner_creature",
                table: "Creatures",
                column: "OwnerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Creatures_TypeId",
                table: "Creatures",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "idx_action_type",
                table: "Actions",
                column: "ActionType");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureAbilityScores_AbilityScoreId",
                table: "CreatureAbilityScores",
                column: "AbilityScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureActions_ActionId",
                table: "CreatureActions",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureConditions_ConditionId",
                table: "CreatureConditions",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "idx_damage_type_category",
                table: "CreatureDamageTypes",
                column: "DamageTypeCategory");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureDamageTypes_DamageTypeId",
                table: "CreatureDamageTypes",
                column: "DamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureLanguages_LanguageId",
                table: "CreatureLanguages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureSenses_SenseId",
                table: "CreatureSenses",
                column: "SenseId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureSkills_SkillId",
                table: "CreatureSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureSpeeds_SpeedId",
                table: "CreatureSpeeds",
                column: "SpeedId");

            migrationBuilder.CreateIndex(
                name: "idx_skill_type",
                table: "Skills",
                column: "SkillType");

            migrationBuilder.CreateIndex(
                name: "IX_SpellActions_ActionId",
                table: "SpellActions",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

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
                name: "FK_Encounters_Campaigns_CampaignId",
                table: "Encounters",
                column: "CampaignId",
                principalTable: "Campaigns",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CampaignUsers_Campaigns_CampaignId",
                table: "CampaignUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_CampaignUsers_Users_UserId",
                table: "CampaignUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_CreatureEncounters_Creatures_CreatureId",
                table: "CreatureEncounters");

            migrationBuilder.DropForeignKey(
                name: "FK_CreatureEncounters_Encounters_EncounterId",
                table: "CreatureEncounters");

            migrationBuilder.DropForeignKey(
                name: "FK_Creatures_CreatureTypes_TypeId",
                table: "Creatures");

            migrationBuilder.DropForeignKey(
                name: "FK_Creatures_Users_OwnerUserId",
                table: "Creatures");

            migrationBuilder.DropForeignKey(
                name: "FK_Encounters_Campaigns_CampaignId",
                table: "Encounters");

            migrationBuilder.DropTable(
                name: "CreatureAbilityScores");

            migrationBuilder.DropTable(
                name: "CreatureActions");

            migrationBuilder.DropTable(
                name: "CreatureConditions");

            migrationBuilder.DropTable(
                name: "CreatureDamageTypes");

            migrationBuilder.DropTable(
                name: "CreatureLanguages");

            migrationBuilder.DropTable(
                name: "CreatureSenses");

            migrationBuilder.DropTable(
                name: "CreatureSkills");

            migrationBuilder.DropTable(
                name: "CreatureSpeeds");

            migrationBuilder.DropTable(
                name: "SpellActions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "AbilityScoreTypes");

            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DropTable(
                name: "DamageTypes");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Senses");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Speeds");

            migrationBuilder.DropTable(
                name: "Actions");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Encounters",
                table: "Encounters");

            migrationBuilder.DropIndex(
                name: "IX_Encounters_CampaignId",
                table: "Encounters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreatureTypes",
                table: "CreatureTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Creatures",
                table: "Creatures");

            migrationBuilder.DropIndex(
                name: "idx_user_owner_creature",
                table: "Creatures");

            migrationBuilder.DropIndex(
                name: "IX_Creatures_TypeId",
                table: "Creatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreatureEncounters",
                table: "CreatureEncounters");

            migrationBuilder.DropIndex(
                name: "idx_encounter_death_status",
                table: "CreatureEncounters");

            migrationBuilder.DropIndex(
                name: "idx_initiative",
                table: "CreatureEncounters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CampaignUsers",
                table: "CampaignUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Campaigns",
                table: "Campaigns");

            migrationBuilder.DropColumn(
                name: "CampaignId",
                table: "Encounters");

            migrationBuilder.DropColumn(
                name: "TurnCount",
                table: "Encounters");

            migrationBuilder.DropColumn(
                name: "HpDiceBonus",
                table: "Creatures");

            migrationBuilder.DropColumn(
                name: "HpDiceCount",
                table: "Creatures");

            migrationBuilder.DropColumn(
                name: "HpDiceSize",
                table: "Creatures");

            migrationBuilder.DropColumn(
                name: "InitiativeBonus",
                table: "Creatures");

            migrationBuilder.DropColumn(
                name: "IsNpc",
                table: "Creatures");

            migrationBuilder.DropColumn(
                name: "LairInitiative",
                table: "Creatures");

            migrationBuilder.DropColumn(
                name: "LegendaryActionCharges",
                table: "Creatures");

            migrationBuilder.DropColumn(
                name: "OwnerUserId",
                table: "Creatures");

            migrationBuilder.DropColumn(
                name: "ProficiencyBonus",
                table: "Creatures");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Creatures");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Creatures");

            migrationBuilder.DropColumn(
                name: "CurrentHp",
                table: "CreatureEncounters");

            migrationBuilder.DropColumn(
                name: "DeathStatus",
                table: "CreatureEncounters");

            migrationBuilder.DropColumn(
                name: "TempHp",
                table: "CreatureEncounters");

            migrationBuilder.DropColumn(
                name: "DriveLink",
                table: "Campaigns");

            migrationBuilder.DropColumn(
                name: "VttLink",
                table: "Campaigns");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "role");

            migrationBuilder.RenameTable(
                name: "Encounters",
                newName: "encounter");

            migrationBuilder.RenameTable(
                name: "CreatureTypes",
                newName: "creature_type");

            migrationBuilder.RenameTable(
                name: "Creatures",
                newName: "creature");

            migrationBuilder.RenameTable(
                name: "CreatureEncounters",
                newName: "creature_encounter");

            migrationBuilder.RenameTable(
                name: "CampaignUsers",
                newName: "campaign_user");

            migrationBuilder.RenameTable(
                name: "Campaigns",
                newName: "campaign");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "encounter",
                newName: "notes");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "encounter",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "encounter",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "creature_type",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "creature_type",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "creature_type",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "creature",
                newName: "notes");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "creature",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Hp",
                table: "creature",
                newName: "hp");

            migrationBuilder.RenameColumn(
                name: "Ac",
                table: "creature",
                newName: "ac");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "creature",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Initiative",
                table: "creature_encounter",
                newName: "initiative");

            migrationBuilder.RenameColumn(
                name: "EncounterId",
                table: "creature_encounter",
                newName: "temp_hp");

            migrationBuilder.RenameColumn(
                name: "CreatureId",
                table: "creature_encounter",
                newName: "current_hp");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "campaign_user",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "CampaignId",
                table: "campaign_user",
                newName: "campaign_id");

            migrationBuilder.RenameIndex(
                name: "IX_CampaignUsers_UserId",
                table: "campaign_user",
                newName: "IX_campaign_user_user_id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "role",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "notes",
                table: "encounter",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "encounter",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "campaign_id",
                table: "encounter",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "turn_count",
                table: "encounter",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "creature_type",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "creature_type",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "notes",
                table: "creature",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "creature",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "hp",
                table: "creature",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ac",
                table: "creature",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "hp_dice_bonus",
                table: "creature",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "hp_dice_count",
                table: "creature",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "hp_dice_size",
                table: "creature",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "initiative_bonus",
                table: "creature",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "is_npc",
                table: "creature",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "lair_initiative",
                table: "creature",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "legendary_action_charges",
                table: "creature",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "owner_user_id",
                table: "creature",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "profiency_bonus",
                table: "creature",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "type_id",
                table: "creature",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "initiative",
                table: "creature_encounter",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(decimal),
                oldType: "numeric(5,2)",
                oldPrecision: 5,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "creature_id",
                table: "creature_encounter",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "encounter_id",
                table: "creature_encounter",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "campaign",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "campaign",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Drive_Link",
                table: "campaign",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Vtt_link",
                table: "campaign",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_role",
                table: "role",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_encounter",
                table: "encounter",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_creature_type",
                table: "creature_type",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_creature",
                table: "creature",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_creature_encounter",
                table: "creature_encounter",
                columns: new[] { "creature_id", "encounter_id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_campaign_user",
                table: "campaign_user",
                columns: new[] { "campaign_id", "user_id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_campaign",
                table: "campaign",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "app_user",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    role_id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_app_user", x => x.id);
                    table.ForeignKey(
                        name: "FK_app_user_role_role_id",
                        column: x => x.role_id,
                        principalTable: "role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_encounter_campaign_id",
                table: "encounter",
                column: "campaign_id");

            migrationBuilder.CreateIndex(
                name: "IX_creature_owner_user_id",
                table: "creature",
                column: "owner_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_creature_type_id",
                table: "creature",
                column: "type_id");

            migrationBuilder.CreateIndex(
                name: "IX_creature_encounter_encounter_id",
                table: "creature_encounter",
                column: "encounter_id");

            migrationBuilder.CreateIndex(
                name: "IX_app_user_role_id",
                table: "app_user",
                column: "role_id");

            migrationBuilder.AddForeignKey(
                name: "FK_campaign_user_app_user_user_id",
                table: "campaign_user",
                column: "user_id",
                principalTable: "app_user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_campaign_user_campaign_campaign_id",
                table: "campaign_user",
                column: "campaign_id",
                principalTable: "campaign",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_creature_app_user_owner_user_id",
                table: "creature",
                column: "owner_user_id",
                principalTable: "app_user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_creature_creature_type_type_id",
                table: "creature",
                column: "type_id",
                principalTable: "creature_type",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_creature_encounter_creature_creature_id",
                table: "creature_encounter",
                column: "creature_id",
                principalTable: "creature",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_creature_encounter_encounter_encounter_id",
                table: "creature_encounter",
                column: "encounter_id",
                principalTable: "encounter",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_encounter_campaign_campaign_id",
                table: "encounter",
                column: "campaign_id",
                principalTable: "campaign",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
