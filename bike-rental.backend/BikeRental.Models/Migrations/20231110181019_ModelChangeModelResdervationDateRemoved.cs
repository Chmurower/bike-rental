using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BikeRental.Models.Migrations
{
    /// <inheritdoc />
    public partial class ModelChangeModelResdervationDateRemoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservationDates");

            migrationBuilder.DropColumn(
                name: "ReservationDateId",
                table: "ReservationTickets");

            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "ReservationTickets",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "ReservationTickets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdSerial",
                table: "ReservationTickets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReservationDate",
                table: "ReservationTickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsRent",
                table: "Bicycles",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "ReservationTickets");

            migrationBuilder.DropColumn(
                name: "IdSerial",
                table: "ReservationTickets");

            migrationBuilder.DropColumn(
                name: "ReservationDate",
                table: "ReservationTickets");

            migrationBuilder.DropColumn(
                name: "IsRent",
                table: "Bicycles");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "ReservationTickets",
                newName: "CustomerName");

            migrationBuilder.AddColumn<int>(
                name: "ReservationDateId",
                table: "ReservationTickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ReservationDates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BicycleId = table.Column<int>(type: "int", nullable: false),
                    EndReservation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartReservation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservationDates_Bicycles_BicycleId",
                        column: x => x.BicycleId,
                        principalTable: "Bicycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservationDates_BicycleId",
                table: "ReservationDates",
                column: "BicycleId");
        }
    }
}
