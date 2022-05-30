using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class Willitwork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "PeopleId", "PersonLanguagesId" },
                values: new object[] { 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "PeopleId", "PersonLanguagesId" },
                keyValues: new object[] { 1, 1 });
        }
    }
}
