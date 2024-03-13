using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ms_autotuning.Infrastructior.Migrations
{
    public partial class AddUserIdInMechanicsAndReservations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservationsMechanics");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldComment: "User Id");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Reservations",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<int>(
                name: "MechanicId",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Mechanics",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_MechanicId",
                table: "Reservations",
                column: "MechanicId");

            migrationBuilder.CreateIndex(
                name: "IX_Mechanics_UserId",
                table: "Mechanics",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mechanics_AspNetUsers_UserId",
                table: "Mechanics",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Mechanics_MechanicId",
                table: "Reservations",
                column: "MechanicId",
                principalTable: "Mechanics",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mechanics_AspNetUsers_UserId",
                table: "Mechanics");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Mechanics_MechanicId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_MechanicId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Mechanics_UserId",
                table: "Mechanics");

            migrationBuilder.DropColumn(
                name: "MechanicId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Mechanics");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: false,
                comment: "User Id",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Reservations",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.CreateTable(
                name: "ReservationsMechanics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MechanicId = table.Column<int>(type: "int", nullable: false),
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationsMechanics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservationsMechanics_Mechanics_MechanicId",
                        column: x => x.MechanicId,
                        principalTable: "Mechanics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationsMechanics_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservationsMechanics_MechanicId",
                table: "ReservationsMechanics",
                column: "MechanicId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationsMechanics_ReservationId",
                table: "ReservationsMechanics",
                column: "ReservationId");
        }
    }
}
