using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeBitsAcademyEFC.Migrations
{
    public partial class adc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "DeptId",
                table: "EmployeesTable");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DepartmentNameDepartmentId",
                table: "EmployeesTable",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeptId",
                table: "EmployeesTable",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

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
    }
}
