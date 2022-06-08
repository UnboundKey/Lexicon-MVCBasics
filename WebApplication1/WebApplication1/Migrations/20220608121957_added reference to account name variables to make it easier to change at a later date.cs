using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class addedreferencetoaccountnamevariablestomakeiteasiertochangeatalaterdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7dc3f3ed-2414-47a6-9d63-fc5c3ea50a55");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5aa58f54-fd43-4f71-88f6-7af74372c1c2", "b0212ae7-a4de-4082-a4e9-b69f99016900" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5aa58f54-fd43-4f71-88f6-7af74372c1c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0212ae7-a4de-4082-a4e9-b69f99016900");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4e99eacd-07d2-47f0-a26c-effba7e67fb6", "7242a4b9-6377-4369-a064-48c00b008a25", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8acd5f9c-578b-4b83-9706-3aa44c0b8d22", "55255462-f971-43c5-9da5-4e9202de6bfd", "Standard", "STANDARD" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e8791187-7e99-44e2-b0df-36d4e84faed4", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "556da964-cf88-47ce-8afd-cc93bb566021", "admin@admin.com", false, null, null, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEISKcuXVO4r2VopL3H4s7GtyCE5bbLM+42/mGzkqffKITPDKAo+tt0w2ypVOyAHZbw==", null, false, "010ec499-c91a-4ceb-b0a7-6aed61ed7a81", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4e99eacd-07d2-47f0-a26c-effba7e67fb6", "e8791187-7e99-44e2-b0df-36d4e84faed4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8acd5f9c-578b-4b83-9706-3aa44c0b8d22");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4e99eacd-07d2-47f0-a26c-effba7e67fb6", "e8791187-7e99-44e2-b0df-36d4e84faed4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e99eacd-07d2-47f0-a26c-effba7e67fb6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8791187-7e99-44e2-b0df-36d4e84faed4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5aa58f54-fd43-4f71-88f6-7af74372c1c2", "2977320d-77f0-40d9-a8a7-e358dfbe337c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7dc3f3ed-2414-47a6-9d63-fc5c3ea50a55", "6c70908c-9c5c-402e-b7ae-51fe9c1b8b3c", "Standard", "STANDARD" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b0212ae7-a4de-4082-a4e9-b69f99016900", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "18bb5705-bf5d-4e0d-beba-1eea2a5561e1", "admin@admin.com", false, null, null, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEHD9rH+4dAuFeUNLbK36TQwRKvGTaQX5Zi7q8qp3+zc976piF7F0eDDNDoyTEvDhrg==", null, false, "01cddd91-3dab-4bfb-9654-ba61810d7df7", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5aa58f54-fd43-4f71-88f6-7af74372c1c2", "b0212ae7-a4de-4082-a4e9-b69f99016900" });
        }
    }
}
