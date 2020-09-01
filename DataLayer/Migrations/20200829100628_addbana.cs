using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class addbana : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Bana",
                table: "Home",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Parking",
                table: "Home",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Arzegozar",
                table: "Anbars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Arzemelk",
                table: "Anbars",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bana",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "Parking",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "Arzegozar",
                table: "Anbars");

            migrationBuilder.DropColumn(
                name: "Arzemelk",
                table: "Anbars");
        }
    }
}
