using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class add0231 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contract_Adviser_AdviserId",
                table: "Contract");

            migrationBuilder.DropForeignKey(
                name: "FK_Contract_Home_HomeId",
                table: "Contract");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contract",
                table: "Contract");

            migrationBuilder.RenameTable(
                name: "Contract",
                newName: "Contractes");

            migrationBuilder.RenameIndex(
                name: "IX_Contract_HomeId",
                table: "Contractes",
                newName: "IX_Contractes_HomeId");

            migrationBuilder.RenameIndex(
                name: "IX_Contract_AdviserId",
                table: "Contractes",
                newName: "IX_Contractes_AdviserId");

            migrationBuilder.AddColumn<string>(
                name: "GharardadNumber",
                table: "Contractes",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SellDate",
                table: "Contractes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contractes",
                table: "Contractes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contractes_Adviser_AdviserId",
                table: "Contractes",
                column: "AdviserId",
                principalTable: "Adviser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Contractes_Adviser_AdviserId",
                table: "Contractes");

            migrationBuilder.DropForeignKey(
                name: "FK_Contractes_Home_HomeId",
                table: "Contractes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contractes",
                table: "Contractes");

            migrationBuilder.DropColumn(
                name: "GharardadNumber",
                table: "Contractes");

            migrationBuilder.DropColumn(
                name: "SellDate",
                table: "Contractes");

            migrationBuilder.RenameTable(
                name: "Contractes",
                newName: "Contract");

            migrationBuilder.RenameIndex(
                name: "IX_Contractes_HomeId",
                table: "Contract",
                newName: "IX_Contract_HomeId");

            migrationBuilder.RenameIndex(
                name: "IX_Contractes_AdviserId",
                table: "Contract",
                newName: "IX_Contract_AdviserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contract",
                table: "Contract",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contract_Adviser_AdviserId",
                table: "Contract",
                column: "AdviserId",
                principalTable: "Adviser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contract_Home_HomeId",
                table: "Contract",
                column: "HomeId",
                principalTable: "Home",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
