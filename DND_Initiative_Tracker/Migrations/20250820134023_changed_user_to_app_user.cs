using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DND_Initiative_Tracker.Migrations
{
    /// <inheritdoc />
    public partial class changed_user_to_app_user : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_campaign_users_users_user_id",
                table: "campaign_users");

            migrationBuilder.DropForeignKey(
                name: "fk_creatures_users_owner_user_id",
                table: "creatures");

            migrationBuilder.DropForeignKey(
                name: "fk_users_roles_role_id",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "pk_users",
                table: "users");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "app_user");

            migrationBuilder.RenameIndex(
                name: "ix_users_role_id",
                table: "app_user",
                newName: "ix_app_user_role_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_app_user",
                table: "app_user",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_app_user_roles_role_id",
                table: "app_user",
                column: "role_id",
                principalTable: "roles",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_campaign_users_app_user_user_id",
                table: "campaign_users",
                column: "user_id",
                principalTable: "app_user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_creatures_app_user_owner_user_id",
                table: "creatures",
                column: "owner_user_id",
                principalTable: "app_user",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_app_user_roles_role_id",
                table: "app_user");

            migrationBuilder.DropForeignKey(
                name: "fk_campaign_users_app_user_user_id",
                table: "campaign_users");

            migrationBuilder.DropForeignKey(
                name: "fk_creatures_app_user_owner_user_id",
                table: "creatures");

            migrationBuilder.DropPrimaryKey(
                name: "pk_app_user",
                table: "app_user");

            migrationBuilder.RenameTable(
                name: "app_user",
                newName: "users");

            migrationBuilder.RenameIndex(
                name: "ix_app_user_role_id",
                table: "users",
                newName: "ix_users_role_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_users",
                table: "users",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_campaign_users_users_user_id",
                table: "campaign_users",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_creatures_users_owner_user_id",
                table: "creatures",
                column: "owner_user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "fk_users_roles_role_id",
                table: "users",
                column: "role_id",
                principalTable: "roles",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
