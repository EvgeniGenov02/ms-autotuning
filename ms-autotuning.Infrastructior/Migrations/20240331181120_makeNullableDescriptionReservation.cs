using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ms_autotuning.Infrastructior.Migrations
{
    public partial class makeNullableDescriptionReservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e1d2a368-dff9-413a-a6b6-6d36c0cb0bb2", "a2208630-1f25-4193-bb8c-5225fa300f0d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1d2a368-dff9-413a-a6b6-6d36c0cb0bb2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2208630-1f25-4193-bb8c-5225fa300f0d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "BGName", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "972a5d94-f0eb-44b9-bc23-fb71eab7246b", "Администратор", "b3c9fa2a-2858-4f37-bfb6-4cea9dfdd15f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5c38e460-f6aa-4bc4-9534-070279296a05", 0, "3e9642a5-30f0-4730-84be-472691bc836f", "admin@example.com", true, "Администратор", "", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAECGEOUt6lU1yixdgxGcW/inRTjHyYL6MhBvDJm4FYwUyE0ujryt6ySeHzScxYOPmIQ==", null, false, "658ea6f3-079f-4c1f-bbc5-e5171546571b", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "972a5d94-f0eb-44b9-bc23-fb71eab7246b", "5c38e460-f6aa-4bc4-9534-070279296a05" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "972a5d94-f0eb-44b9-bc23-fb71eab7246b", "5c38e460-f6aa-4bc4-9534-070279296a05" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "972a5d94-f0eb-44b9-bc23-fb71eab7246b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c38e460-f6aa-4bc4-9534-070279296a05");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "BGName", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e1d2a368-dff9-413a-a6b6-6d36c0cb0bb2", "Администратор", "fb43044b-3957-4929-8827-4a94f185274c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a2208630-1f25-4193-bb8c-5225fa300f0d", 0, "120d6c52-11f2-43d6-9fab-50fd41a102d0", "admin@example.com", true, "Администратор", "", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEkruKS+DbJYWGcDttsGk8QeQ3wLETadNjzCeK8U3wEVRQGRtAMcD2jdF1tNmHAzLg==", null, false, "46517ab0-79db-499e-8097-0d547bb3b9fd", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e1d2a368-dff9-413a-a6b6-6d36c0cb0bb2", "a2208630-1f25-4193-bb8c-5225fa300f0d" });
        }
    }
}
