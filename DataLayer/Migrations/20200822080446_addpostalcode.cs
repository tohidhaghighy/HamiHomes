using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class addpostalcode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bath",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "Bed",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "BuildYear",
                table: "Home");

            migrationBuilder.AddColumn<string>(
                name: "Postalcode",
                table: "Home",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Bath",
                table: "Apartemans",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Bed",
                table: "Apartemans",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BuildYear",
                table: "Apartemans",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Postalcode",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "Bath",
                table: "Apartemans");

            migrationBuilder.DropColumn(
                name: "Bed",
                table: "Apartemans");

            migrationBuilder.DropColumn(
                name: "BuildYear",
                table: "Apartemans");

            migrationBuilder.AddColumn<int>(
                name: "Bath",
                table: "Home",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Bed",
                table: "Home",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BuildYear",
                table: "Home",
                nullable: false,
                defaultValue: 0);
        }
    }
}
