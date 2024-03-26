using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ms_autotuning.Infrastructior.Migrations
{
    public partial class removeAdministratorEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrators");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "BGName", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bd803448-902e-4382-989a-2e8c51a668d2", "Администратор", "4aacb094-9e75-48f4-aa42-33bcd47f6f08", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "73f397ea-df57-45d6-a73d-232e83fefc68", 0, "f3f209fa-51ea-4ff4-82b9-9c18dd2cb8c8", "admin@example.com", true, "Администратор", "", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEAs02gcyPp2oUIw6NAYFS+L57Yv4qTkT/RzKG0vYVXtAqCpH+Vw3MUsgqwPhOnQtnA==", null, false, "94005b99-f6f9-4fbd-a955-a4fb02531114", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bd803448-902e-4382-989a-2e8c51a668d2", "73f397ea-df57-45d6-a73d-232e83fefc68" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd803448-902e-4382-989a-2e8c51a668d2", "73f397ea-df57-45d6-a73d-232e83fefc68" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd803448-902e-4382-989a-2e8c51a668d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73f397ea-df57-45d6-a73d-232e83fefc68");

            migrationBuilder.CreateTable(
                name: "Administrators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Administrators_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Administrators_UserId",
                table: "Administrators",
                column: "UserId");
        }
    }
}
