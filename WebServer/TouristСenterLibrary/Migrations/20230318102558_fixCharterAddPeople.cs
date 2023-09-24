using Microsoft.EntityFrameworkCore.Migrations;

namespace TouristСenterLibrary.Migrations
{
    public partial class fixCharterAddPeople : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Charter_CharterID",
                table: "People");

            migrationBuilder.AlterColumn<int>(
                name: "CharterID",
                table: "People",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Charter_CharterID",
                table: "People",
                column: "CharterID",
                principalTable: "Charter",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Charter_CharterID",
                table: "People");

            migrationBuilder.AlterColumn<int>(
                name: "CharterID",
                table: "People",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Charter_CharterID",
                table: "People",
                column: "CharterID",
                principalTable: "Charter",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
