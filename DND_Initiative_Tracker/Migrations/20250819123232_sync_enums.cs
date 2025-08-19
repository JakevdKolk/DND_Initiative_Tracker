using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DND_Initiative_Tracker.Migrations
{
    /// <inheritdoc />
    public partial class sync_enums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:public.action_type", "action,bonus_action,reaction,trait,legendary_action,lair_action,mythical_action")
                .Annotation("Npgsql:Enum:public.damage_type_category", "resistant,vulnerable,immune,none")
                .Annotation("Npgsql:Enum:public.death_status", "stable,alive,dying,dead")
                .Annotation("Npgsql:Enum:public.size", "Tiny,Small,Medium,Large,Huge,Gargantuan")
                .Annotation("Npgsql:Enum:public.skill_type", "skill,tool,instrument");

            migrationBuilder.CreateTable(
                name: "encounter",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    turn_count = table.Column<int>(type: "integer", nullable: false),
                    campaign_id = table.Column<int>(type: "integer", nullable: false),
                    notes = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_encounter", x => x.id);
                    table.ForeignKey(
                        name: "FK_encounter_campaign_campaign_id",
                        column: x => x.campaign_id,
                        principalTable: "campaign",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "creature_encounter",
                columns: table => new
                {
                    creature_id = table.Column<int>(type: "integer", nullable: false),
                    encounter_id = table.Column<int>(type: "integer", nullable: false),
                    current_hp = table.Column<int>(type: "integer", nullable: false),
                    temp_hp = table.Column<int>(type: "integer", nullable: false),
                    initiative = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_creature_encounter", x => new { x.creature_id, x.encounter_id });
                    table.ForeignKey(
                        name: "FK_creature_encounter_creature_creature_id",
                        column: x => x.creature_id,
                        principalTable: "creature",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_creature_encounter_encounter_encounter_id",
                        column: x => x.encounter_id,
                        principalTable: "encounter",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_creature_encounter_encounter_id",
                table: "creature_encounter",
                column: "encounter_id");

            migrationBuilder.CreateIndex(
                name: "IX_encounter_campaign_id",
                table: "encounter",
                column: "campaign_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "creature_encounter");

            migrationBuilder.DropTable(
                name: "encounter");

            migrationBuilder.AlterDatabase()
                .OldAnnotation("Npgsql:Enum:public.action_type", "action,bonus_action,reaction,trait,legendary_action,lair_action,mythical_action")
                .OldAnnotation("Npgsql:Enum:public.damage_type_category", "resistant,vulnerable,immune,none")
                .OldAnnotation("Npgsql:Enum:public.death_status", "stable,alive,dying,dead")
                .OldAnnotation("Npgsql:Enum:public.size", "Tiny,Small,Medium,Large,Huge,Gargantuan")
                .OldAnnotation("Npgsql:Enum:public.skill_type", "skill,tool,instrument");
        }
    }
}
