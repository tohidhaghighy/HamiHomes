using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class addejare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cost",
                table: "VadieSetting",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CostChance",
                table: "VadieSetting",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MetrazChance",
                table: "MetrazSetting",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Cost",
                table: "EjareSetting",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CostChance",
                table: "EjareSetting",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CostChance",
                table: "CostSetting",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CostChance",
                table: "VadieSetting");

            migrationBuilder.DropColumn(
                name: "MetrazChance",
                table: "MetrazSetting");

            migrationBuilder.DropColumn(
                name: "CostChance",
                table: "EjareSetting");

            migrationBuilder.DropColumn(
                name: "CostChance",
                table: "CostSetting");

            migrationBuilder.AlterColumn<int>(
                name: "Cost",
                table: "VadieSetting",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Cost",
                table: "EjareSetting",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
