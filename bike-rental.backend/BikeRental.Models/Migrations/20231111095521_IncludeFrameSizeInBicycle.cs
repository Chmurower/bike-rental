using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BikeRental.Models.Migrations
{
    /// <inheritdoc />
    public partial class IncludeFrameSizeInBicycle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Bicycles_FrameSizeId",
                table: "Bicycles",
                column: "FrameSizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bicycles_FrameSizes_FrameSizeId",
                table: "Bicycles",
                column: "FrameSizeId",
                principalTable: "FrameSizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bicycles_FrameSizes_FrameSizeId",
                table: "Bicycles");

            migrationBuilder.DropIndex(
                name: "IX_Bicycles_FrameSizeId",
                table: "Bicycles");
        }
    }
}
