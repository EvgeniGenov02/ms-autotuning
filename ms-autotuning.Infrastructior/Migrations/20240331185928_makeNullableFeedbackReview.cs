using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ms_autotuning.Infrastructior.Migrations
{
    public partial class makeNullableFeedbackReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Feedback",
                table: "Reviews",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "BGName", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ba7c396-0d61-4211-aab9-bdde863df48e", "Администратор", "49294bef-63d9-43d1-b0e9-9beec3f95dd3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "31ff7d68-f44c-4f2a-a5cd-7a7b0185204e", 0, "42ac7a36-564c-4492-a3e1-341972a0c096", "admin@example.com", true, "Администратор", "", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAx1OtOFRdpvhBXZPlgnzuTP1Cr4CT7TIZAyHzmRNuDKDMTOjDfV1eC5TLEUkViLfQ==", null, false, "7cb8e74b-0535-485b-9ea3-2df23e3a2f24", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5ba7c396-0d61-4211-aab9-bdde863df48e", "31ff7d68-f44c-4f2a-a5cd-7a7b0185204e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5ba7c396-0d61-4211-aab9-bdde863df48e", "31ff7d68-f44c-4f2a-a5cd-7a7b0185204e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ba7c396-0d61-4211-aab9-bdde863df48e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31ff7d68-f44c-4f2a-a5cd-7a7b0185204e");

            migrationBuilder.AlterColumn<string>(
                name: "Feedback",
                table: "Reviews",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

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
    }
}
