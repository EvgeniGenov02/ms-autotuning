using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ms_autotuning.Infrastructior.Migrations
{
    public partial class AddCompleteOrderEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "CompleteOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MechanicId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompleteOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompleteOrders_Mechanics_MechanicId",
                        column: x => x.MechanicId,
                        principalTable: "Mechanics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompleteOrders_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "BGName", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9dafb968-e0d9-43a3-a73b-56c3ecb69760", "Администратор", "7d2ae690-a9ce-4543-babb-c1df9b98dabf", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4dff12dd-41ef-40e8-86b4-93bee1f8fe82", 0, "9216aa4c-250b-4096-9010-684d743c7f92", "admin@example.com", true, "Администратор", "", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGWAAzfw/oe00gMZ/BHx437HwrT9Bxl1wyoPFjXDUkXqJUjT7kT4erGq5Bp3vJk6Ug==", null, false, "1860a6ad-934d-4309-b344-e066eb347bd3", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9dafb968-e0d9-43a3-a73b-56c3ecb69760", "4dff12dd-41ef-40e8-86b4-93bee1f8fe82" });

            migrationBuilder.CreateIndex(
                name: "IX_CompleteOrders_MechanicId",
                table: "CompleteOrders",
                column: "MechanicId");

            migrationBuilder.CreateIndex(
                name: "IX_CompleteOrders_ServiceId",
                table: "CompleteOrders",
                column: "ServiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompleteOrders");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9dafb968-e0d9-43a3-a73b-56c3ecb69760", "4dff12dd-41ef-40e8-86b4-93bee1f8fe82" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9dafb968-e0d9-43a3-a73b-56c3ecb69760");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4dff12dd-41ef-40e8-86b4-93bee1f8fe82");

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
    }
}
