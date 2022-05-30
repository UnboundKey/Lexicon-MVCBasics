using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class Initialwithlanguage2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Languages_LanguageId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_LanguageId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "People");

            migrationBuilder.CreateTable(
                name: "LanguagePerson",
                columns: table => new
                {
                    PeopleId = table.Column<int>(type: "int", nullable: false),
                    PersonLanguagesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguagePerson", x => new { x.PeopleId, x.PersonLanguagesId });
                    table.ForeignKey(
                        name: "FK_LanguagePerson_Languages_PersonLanguagesId",
                        column: x => x.PersonLanguagesId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguagePerson_People_PeopleId",
                        column: x => x.PeopleId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LanguagePerson_PersonLanguagesId",
                table: "LanguagePerson",
                column: "PersonLanguagesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LanguagePerson");

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "People",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_People_LanguageId",
                table: "People",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Languages_LanguageId",
                table: "People",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id");
        }
    }
}
