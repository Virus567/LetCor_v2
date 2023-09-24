using Microsoft.EntityFrameworkCore.Migrations;

namespace TouristСenterLibrary.Migrations
{
    public partial class fixTransportAddSeatCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SeatCount",
                table: "Transport",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Transport",
                keyColumn: "ID",
                keyValue: 1,
                column: "SeatCount",
                value: 35);

            migrationBuilder.UpdateData(
                table: "Transport",
                keyColumn: "ID",
                keyValue: 2,
                column: "SeatCount",
                value: 34);

            migrationBuilder.UpdateData(
                table: "Transport",
                keyColumn: "ID",
                keyValue: 3,
                column: "SeatCount",
                value: 32);

            migrationBuilder.UpdateData(
                table: "Transport",
                keyColumn: "ID",
                keyValue: 4,
                column: "SeatCount",
                value: 35);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeatCount",
                table: "Transport");
        }
    }
}
