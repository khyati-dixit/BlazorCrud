using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employes",
                columns: table => new
                {
                    EmpolyeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employes", x => x.EmpolyeeId);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "HR" },
                    { 3, "Payroll" },
                    { 4, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Employes",
                columns: new[] { "EmpolyeeId", "DateOfBirth", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[,]
                {
                    { 1, new DateTime(1998, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "joHNN@gmail.com", "John", 0, "HASH", "images/imp1.jpg" },
                    { 2, new DateTime(1998, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "sammjguhj@gmail.com", "Sam", 0, "Sharma", "images/imp2.jpg" },
                    { 3, new DateTime(1998, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "neha@gmail.com", "Neha", 1, "Sharma", "images/imp3.jpg" },
                    { 4, new DateTime(1998, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "neha@gmail.com", "Neha", 1, "Sharma", "images/imp4.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employes");
        }
    }
}
