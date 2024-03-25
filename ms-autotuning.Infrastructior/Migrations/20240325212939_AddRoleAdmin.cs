using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ms_autotuning.Infrastructior.Migrations
{
    public partial class AddRoleAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BGName",
                table: "AspNetRoles",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "BGName", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c8be4cb7-d645-450c-9b0c-6f5f15a06868", "Администратор", "f7451978-adab-4f4d-ace0-3916a6e4b1a6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "509a10c9-2be2-497e-9c95-2ab11ce961ac", 0, "830ae5c2-703f-42bc-bd47-5a00abde979c", "admin@example.com", true, "Администратор", "", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGJnIMYHWTgKtmVnjTCuTPq6NPMqqGSyI+0OdJtqDKKd15oykkr2JLMYS3v4EBbvvw==", null, false, "3f58641d-04fd-4ac1-b8c5-3ace9ce3e012", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c8be4cb7-d645-450c-9b0c-6f5f15a06868", "509a10c9-2be2-497e-9c95-2ab11ce961ac" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c8be4cb7-d645-450c-9b0c-6f5f15a06868", "509a10c9-2be2-497e-9c95-2ab11ce961ac" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8be4cb7-d645-450c-9b0c-6f5f15a06868");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "509a10c9-2be2-497e-9c95-2ab11ce961ac");

            migrationBuilder.DropColumn(
                name: "BGName",
                table: "AspNetRoles");
        }
    }
}
