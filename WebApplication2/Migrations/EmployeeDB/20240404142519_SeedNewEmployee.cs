using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations.EmployeeDB
{
    public partial class SeedNewEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "tt@gmail.com", "Anthonia toni", "+234-989-537" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name", "Phone" },
                values: new object[] { "nnamdosuagwu@gmail.com", "Nnamdi Obi", "+234-989-677" });
        }
    }
}
