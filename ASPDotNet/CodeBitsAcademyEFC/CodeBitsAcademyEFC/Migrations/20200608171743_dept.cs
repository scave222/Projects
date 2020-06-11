using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeBitsAcademyEFC.Migrations
{
    public partial class dept : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "DepartmentTable",
                columns: table => new
                {
                    DepartmentId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentTable", x => x.DepartmentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentTable");

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
    }
}
