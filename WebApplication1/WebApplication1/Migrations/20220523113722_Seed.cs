using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 17, "Gondor", "A", 555213345 },
                    { 18, "Gondor", "B", 555213345 },
                    { 19, "Gondor", "C", 555213345 },
                    { 20, "Gondor", "D", 555213345 },
                    { 21, "Gondor", "E", 555213345 },
                    { 22, "Gondor", "F", 555213345 },
                    { 23, "Gondor", "G", 555213345 },
                    { 24, "Gondor", "H", 555213345 },
                    { 25, "Gondor", "I", 555213345 },
                    { 26, "Gondor", "J", 555213345 },
                    { 27, "Gondor", "K", 555213345 },
                    { 28, "Gondor", "L", 555213345 },
                    { 29, "Gondor", "M", 555213345 },
                    { 30, "Gondor", "N", 555213345 },
                    { 31, "Gondor", "O", 555213345 },
                    { 32, "Gondor", "P", 555213345 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
