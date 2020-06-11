using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeBitsAcademyEFC.Migrations
{
    public partial class departments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DepartmentId",
                table: "EmployeesTable",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesTable_DepartmentId",
                table: "EmployeesTable",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeesTable_DepartmentTable_DepartmentId",
                table: "EmployeesTable",
                column: "DepartmentId",
                principalTable: "DepartmentTable",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeesTable_DepartmentTable_DepartmentId",
                table: "EmployeesTable");

            migrationBuilder.DropIndex(
                name: "IX_EmployeesTable_DepartmentId",
                table: "EmployeesTable");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "EmployeesTable");
        }
    }
}
