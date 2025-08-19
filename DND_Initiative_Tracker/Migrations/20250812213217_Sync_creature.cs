using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DND_Initiative_Tracker.Migrations
{
    /// <inheritdoc />
    public partial class Sync_creature : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "creature_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_creature_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "creature",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    type_id = table.Column<int>(type: "integer", nullable: false),
                    ac = table.Column<int>(type: "integer", nullable: false),
                    hp = table.Column<int>(type: "integer", nullable: false),
                    hp_dice_count = table.Column<int>(type: "integer", nullable: false),
                    hp_dice_size = table.Column<int>(type: "integer", nullable: false),
                    hp_dice_bonus = table.Column<int>(type: "integer", nullable: false),
                    legendary_action_charges = table.Column<int>(type: "integer", nullable: false),
                    profiency_bonus = table.Column<int>(type: "integer", nullable: false),
                    is_npc = table.Column<bool>(type: "boolean", nullable: false),
                    lair_initiative = table.Column<int>(type: "integer", nullable: false),
                    initiative_bonus = table.Column<int>(type: "integer", nullable: false),
                    notes = table.Column<string>(type: "text", nullable: false),
                    owner_user_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_creature", x => x.id);
                    table.ForeignKey(
                        name: "FK_creature_app_user_owner_user_id",
                        column: x => x.owner_user_id,
                        principalTable: "app_user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_creature_creature_type_type_id",
                        column: x => x.type_id,
                        principalTable: "creature_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_creature_owner_user_id",
                table: "creature",
                column: "owner_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_creature_type_id",
                table: "creature",
                column: "type_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "creature");

            migrationBuilder.DropTable(
                name: "creature_type");
        }
    }
}
