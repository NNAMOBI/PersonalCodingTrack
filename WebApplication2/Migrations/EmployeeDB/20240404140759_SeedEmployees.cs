using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations.EmployeeDB
{
    public partial class SeedEmployees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "Employees",
               columns: new[] { "Id", "Name", "Email", "Phone" },
               values: new object[] { 1, "Nmamdi obi", "nnamdosuagwu@gmail.com", "+234-989-677" });
        }
    

        protected override void Down(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.DeleteData(
               table: "Employees",
               keyColumn: "Id",
               keyValue: 1);
        }
    }
}
