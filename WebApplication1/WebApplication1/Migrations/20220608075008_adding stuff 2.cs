using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class addingstuff2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
