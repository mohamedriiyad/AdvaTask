using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvaTask.Infra.Data.Migrations
{
    public partial class SeedEmployeeDefaultData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "Name", "Salary" },
                values: new object[] { 1, null, "Manager", 0 });
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
