using Microsoft.EntityFrameworkCore.Migrations;

namespace TouristСenterLibrary.Migrations
{
    public partial class fixSeatCountBus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Transport",
                keyColumn: "ID",
                keyValue: 2,
                column: "SeatCount",
                value: 53);

            migrationBuilder.UpdateData(
                table: "Transport",
                keyColumn: "ID",
                keyValue: 3,
                column: "SeatCount",
                value: 34);

            migrationBuilder.UpdateData(
                table: "Transport",
                keyColumn: "ID",
                keyValue: 4,
                column: "SeatCount",
                value: 51);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
