using Microsoft.EntityFrameworkCore.Migrations;

namespace TouristСenterLibrary.Migrations
{
    public partial class fixPathCharter2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContractFilePath",
                table: "Charter",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PeopleFilePath",
                table: "Charter",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RouteProgramFilePath",
                table: "Charter",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContractFilePath",
                table: "Charter");

            migrationBuilder.DropColumn(
                name: "PeopleFilePath",
                table: "Charter");

            migrationBuilder.DropColumn(
                name: "RouteProgramFilePath",
                table: "Charter");
        }
    }
}
