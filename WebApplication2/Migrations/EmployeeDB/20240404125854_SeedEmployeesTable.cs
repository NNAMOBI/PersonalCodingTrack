using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations.EmployeeDB
{
    public partial class SeedEmployeesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.Sql("INSERT INTO dbo.Employees(Id, Name, Email, Phone) VALUES (1, 'Nnamdi obi', 'nnamdosuagwu@gmail.com', '+234-989-677')");
            //migrationBuilder.Sql("INSERT INTO dbo.Employees(Id, Name, Email, Phone) VALUES (2, 'ikenna obi', 'Ikennaosuagwu@gmail.com', '+234-989-679')");
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
