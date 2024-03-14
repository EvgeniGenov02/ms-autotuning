using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ms_autotuning.Infrastructior.Migrations
{
    public partial class EditAdministratorAndMechanic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Mechanics");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Administrators");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Mechanics",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Administrators",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Mechanics");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Administrators");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Mechanics",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Administrators",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
