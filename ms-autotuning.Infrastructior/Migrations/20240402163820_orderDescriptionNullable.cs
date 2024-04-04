using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ms_autotuning.Infrastructior.Migrations
{
    public partial class orderDescriptionNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Description",
                table: "Promotions",
                type: "nvarchar(1500)",
                maxLength: 1500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Orders",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "BGName", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ee4206a-d120-49ef-9cc6-da9694510c37", "Администратор", "fb8de327-a169-428a-b920-03865002a2e1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2d2aab17-2ec0-4aa1-a637-87a67c1431d6", 0, "0dee221f-85c1-4dcb-ae0a-84a5900826b2", "admin@example.com", true, "Администратор", "", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHaI5FF7sHRB+afgW9474z+h2Adcox7nDHZcOmU8yDmBJ7o+zpk1IAHs5+0f9GwS/A==", null, false, "5a626c0c-8b3f-4002-9e1e-f64222df1ee1", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8ee4206a-d120-49ef-9cc6-da9694510c37", "2d2aab17-2ec0-4aa1-a637-87a67c1431d6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8ee4206a-d120-49ef-9cc6-da9694510c37", "2d2aab17-2ec0-4aa1-a637-87a67c1431d6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ee4206a-d120-49ef-9cc6-da9694510c37");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d2aab17-2ec0-4aa1-a637-87a67c1431d6");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Promotions",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1500)",
                oldMaxLength: 1500);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Orders",
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
    }
}
