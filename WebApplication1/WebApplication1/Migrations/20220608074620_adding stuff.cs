using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class addingstuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c23630d7-bd82-4a35-9078-7c2025a6e707");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2d7aaec5-e1f8-4a39-98ec-78e53d78c1ba", "ea428d45-f6ef-4e8e-809e-7c8a274055ae" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d7aaec5-e1f8-4a39-98ec-78e53d78c1ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea428d45-f6ef-4e8e-809e-7c8a274055ae");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "69a9f8bc-3cfc-436e-b478-efecd2dab966", "dbb7638c-61af-4cb7-8131-3b054744b749", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e425f79-ac26-41ed-b895-cfce95a79e69", "b643a6da-e108-49bf-98a3-85bad80ab507", "Standard", "STANDARD" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8dd76934-ee0e-4db5-a76a-5520e488362f", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fdbabd0d-0277-4fa9-bda4-e1c4c6fbf6d5", "admin@localhost.local", false, null, null, false, null, "ADMIN@LOCALHOST.LOCAL", null, "AQAAAAEAACcQAAAAEIeUo1mKrbYRE9Y3r+XIgxDaqkEEYHYAlFf4swF5icym+H0Cu0AcD8sovYitfRJqkw==", null, false, "d94b1080-50c8-434a-a777-3f126ce83408", false, "admin@localhost.local" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "69a9f8bc-3cfc-436e-b478-efecd2dab966", "8dd76934-ee0e-4db5-a76a-5520e488362f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e425f79-ac26-41ed-b895-cfce95a79e69");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "69a9f8bc-3cfc-436e-b478-efecd2dab966", "8dd76934-ee0e-4db5-a76a-5520e488362f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69a9f8bc-3cfc-436e-b478-efecd2dab966");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8dd76934-ee0e-4db5-a76a-5520e488362f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2d7aaec5-e1f8-4a39-98ec-78e53d78c1ba", "a0f4cfd5-222b-42a2-9005-198b822863b2", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c23630d7-bd82-4a35-9078-7c2025a6e707", "a1009c18-8642-48a3-b8f5-1297f089c235", "Standard", "STANDARD" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ea428d45-f6ef-4e8e-809e-7c8a274055ae", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a431c558-3c14-45d4-b89b-8c75078d48a7", "admin@localhost.local", false, null, null, false, null, "ADMIN@LOCALHOST.LOCAL", null, "AQAAAAEAACcQAAAAEJH8Hd1gNPXJzrn+KdxzlQybTETd5epZgONo/6MWmphlTJMgtJX/nbpCirbEwGLcQw==", null, false, "ed2b0dbe-1ec6-4b70-aa2d-89e05c3686cc", false, "admin@localhost.local" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2d7aaec5-e1f8-4a39-98ec-78e53d78c1ba", "ea428d45-f6ef-4e8e-809e-7c8a274055ae" });
        }
    }
}
