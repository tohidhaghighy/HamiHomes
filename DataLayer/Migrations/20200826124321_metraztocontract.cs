using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class metraztocontract : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Metraz",
                table: "Contractes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contractes_HomeId",
                table: "Contractes",
                column: "HomeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contractes_Home_HomeId",
                table: "Contractes",
                column: "HomeId",
                principalTable: "Home",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contractes_Home_HomeId",
                table: "Contractes");

            migrationBuilder.DropIndex(
                name: "IX_Contractes_HomeId",
                table: "Contractes");

            migrationBuilder.DropColumn(
                name: "Metraz",
                table: "Contractes");
        }
    }
}
