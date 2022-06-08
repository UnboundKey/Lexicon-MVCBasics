using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class addingstuff3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00512e01-4be1-41f7-8d2d-7e46d8345bd7");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "170482d8-1cb2-4d58-a9fb-48848918f8c6", "3a85ca0c-68ed-4085-a18f-762cd866fe14" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "170482d8-1cb2-4d58-a9fb-48848918f8c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a85ca0c-68ed-4085-a18f-762cd866fe14");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "00512e01-4be1-41f7-8d2d-7e46d8345bd7", "95a979a1-497d-402d-bc8e-fcdef89c02e8", "Standard", "STANDARD" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "170482d8-1cb2-4d58-a9fb-48848918f8c6", "d81db6a5-36ad-4c3c-b807-f1e6e5bfdd7a", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3a85ca0c-68ed-4085-a18f-762cd866fe14", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4f98200e-ea5e-4a1a-b9a3-c3b57b64c3ac", "admin@localhost.local", false, null, null, false, null, "ADMIN@LOCALHOST.LOCAL", null, "AQAAAAEAACcQAAAAEJbLrWPS/d8KiQYjNqv9VRzd8KDRwbJ/1VfkWvF3elkdUBS8k7ccxzztoGNcAOEfOA==", null, false, "69094c8d-effb-4532-a73b-af75f1d123c6", false, "admin@localhost.local" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "170482d8-1cb2-4d58-a9fb-48848918f8c6", "3a85ca0c-68ed-4085-a18f-762cd866fe14" });
        }
    }
}
