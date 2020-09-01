using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class test01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BuyTakhasos",
                table: "Adviser",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RentTakhasos",
                table: "Adviser",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuyTakhasos",
                table: "Adviser");

            migrationBuilder.DropColumn(
                name: "RentTakhasos",
                table: "Adviser");
        }
    }
}
