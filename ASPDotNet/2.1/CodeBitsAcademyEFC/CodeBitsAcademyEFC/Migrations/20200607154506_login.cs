using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeBitsAcademyEFC.Migrations
{
    public partial class login : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SystemUsersTable",
                table: "SystemUsersTable");

            migrationBuilder.RenameTable(
                name: "SystemUsersTable",
                newName: "SystemUsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SystemUsers",
                table: "SystemUsers",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SystemUsers",
                table: "SystemUsers");

            migrationBuilder.RenameTable(
                name: "SystemUsers",
                newName: "SystemUsersTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SystemUsersTable",
                table: "SystemUsersTable",
                column: "Id");
        }
    }
}
