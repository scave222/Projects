using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSeekers.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobSeekersTable",
                columns: table => new
                {
                    JobSeekersID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 20, nullable: false),
                    LastName = table.Column<string>(maxLength: 20, nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    Sex = table.Column<string>(maxLength: 6, nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    HomeAddress = table.Column<string>(maxLength: 50, nullable: false),
                    Qualification = table.Column<string>(maxLength: 30, nullable: false),
                    CourseOfStudy = table.Column<string>(maxLength: 20, nullable: false),
                    YrsOfExp = table.Column<int>(nullable: false),
                    Password = table.Column<string>(maxLength: 10, nullable: false),
                    ConfirmPassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSeekersTable", x => x.JobSeekersID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobSeekersTable");
        }
    }
}
