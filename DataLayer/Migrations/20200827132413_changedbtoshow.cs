using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class changedbtoshow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HometypeId",
                table: "Home",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdviserId",
                table: "Contractes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeFacilities",
                table: "Apartemans",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MoghiateMelk",
                table: "Anbars",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SanadStatus",
                table: "Anbars",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contractes_AdviserId",
                table: "Contractes",
                column: "AdviserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contractes_Adviser_AdviserId",
                table: "Contractes",
                column: "AdviserId",
                principalTable: "Adviser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contractes_Adviser_AdviserId",
                table: "Contractes");

            migrationBuilder.DropIndex(
                name: "IX_Contractes_AdviserId",
                table: "Contractes");

            migrationBuilder.DropColumn(
                name: "HometypeId",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "AdviserId",
                table: "Contractes");

            migrationBuilder.DropColumn(
                name: "HomeFacilities",
                table: "Apartemans");

            migrationBuilder.DropColumn(
                name: "MoghiateMelk",
                table: "Anbars");

            migrationBuilder.DropColumn(
                name: "SanadStatus",
                table: "Anbars");
        }
    }
}
