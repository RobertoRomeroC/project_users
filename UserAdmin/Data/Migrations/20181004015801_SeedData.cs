using Microsoft.EntityFrameworkCore.Migrations;

namespace UserAdmin.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Mail", "Password", "Sex", "Status", "Users" },
                values: new object[] { 2, "hey@gmail.com", "Ey1234567890!", "Male", true, "Fulanito Ramirez" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
