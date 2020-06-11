using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeBitsAcademyEFC.Migrations
{
    public partial class adddebt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DepartmentNameDepartmentId",
                table: "EmployeesTable",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesTable_DepartmentNameDepartmentId",
                table: "EmployeesTable",
                column: "DepartmentNameDepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeesTable_DepartmentTable_DepartmentNameDepartmentId",
                table: "EmployeesTable",
                column: "DepartmentNameDepartmentId",
                principalTable: "DepartmentTable",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeesTable_DepartmentTable_DepartmentNameDepartmentId",
                table: "EmployeesTable");

            migrationBuilder.DropIndex(
                name: "IX_EmployeesTable_DepartmentNameDepartmentId",
                table: "EmployeesTable");

            migrationBuilder.DropColumn(
                name: "DepartmentNameDepartmentId",
                table: "EmployeesTable");
        }
    }
}
