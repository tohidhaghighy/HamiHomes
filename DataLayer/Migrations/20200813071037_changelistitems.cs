using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class changelistitems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "CostChance",
                table: "VadieSetting",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<long>(
                name: "CostChance",
                table: "EjareSetting",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<long>(
                name: "CostChance",
                table: "CostSetting",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "MelkType",
                table: "AmlakWC",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeHome",
                table: "AmlakWC",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MelkType",
                table: "AmlakTasisatGarmaieshi",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeHome",
                table: "AmlakTasisatGarmaieshi",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MelkType",
                table: "AmlakSanadStatus",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeHome",
                table: "AmlakSanadStatus",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MelkType",
                table: "AmlakSaghf",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeHome",
                table: "AmlakSaghf",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MelkType",
                table: "AmlakPishraftStatus",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeHome",
                table: "AmlakPishraftStatus",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MelkType",
                table: "AmlakParking",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeHome",
                table: "AmlakParking",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MelkType",
                table: "AmlakNoeZamin",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeHome",
                table: "AmlakNoeZamin",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MelkType",
                table: "AmlakNema",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeHome",
                table: "AmlakNema",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MelkType",
                table: "AmlakMoshakhase",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeHome",
                table: "AmlakMoshakhase",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MelkType",
                table: "AmlakMoshaat",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeHome",
                table: "AmlakMoshaat",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MelkType",
                table: "AmlakMogheiatMelk",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeHome",
                table: "AmlakMogheiatMelk",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MelkType",
                table: "AmlakMelkStatus",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeHome",
                table: "AmlakMelkStatus",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MelkType",
                table: "AmlakKitchen",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeHome",
                table: "AmlakKitchen",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MelkType",
                table: "AmlakKaf",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeHome",
                table: "AmlakKaf",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MelkType",
                table: "AmlakJahatVahed",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeHome",
                table: "AmlakJahatVahed",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MelkType",
                table: "AmlakEskeleton",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeHome",
                table: "AmlakEskeleton",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MelkType",
                table: "AmlakEmtiaz",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeHome",
                table: "AmlakEmtiaz",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MelkType",
                table: "AmlakDivar",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeHome",
                table: "AmlakDivar",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MelkType",
                table: "AmlakWC");

            migrationBuilder.DropColumn(
                name: "TypeHome",
                table: "AmlakWC");

            migrationBuilder.DropColumn(
                name: "MelkType",
                table: "AmlakTasisatGarmaieshi");

            migrationBuilder.DropColumn(
                name: "TypeHome",
                table: "AmlakTasisatGarmaieshi");

            migrationBuilder.DropColumn(
                name: "MelkType",
                table: "AmlakSanadStatus");

            migrationBuilder.DropColumn(
                name: "TypeHome",
                table: "AmlakSanadStatus");

            migrationBuilder.DropColumn(
                name: "MelkType",
                table: "AmlakSaghf");

            migrationBuilder.DropColumn(
                name: "TypeHome",
                table: "AmlakSaghf");

            migrationBuilder.DropColumn(
                name: "MelkType",
                table: "AmlakPishraftStatus");

            migrationBuilder.DropColumn(
                name: "TypeHome",
                table: "AmlakPishraftStatus");

            migrationBuilder.DropColumn(
                name: "MelkType",
                table: "AmlakParking");

            migrationBuilder.DropColumn(
                name: "TypeHome",
                table: "AmlakParking");

            migrationBuilder.DropColumn(
                name: "MelkType",
                table: "AmlakNoeZamin");

            migrationBuilder.DropColumn(
                name: "TypeHome",
                table: "AmlakNoeZamin");

            migrationBuilder.DropColumn(
                name: "MelkType",
                table: "AmlakNema");

            migrationBuilder.DropColumn(
                name: "TypeHome",
                table: "AmlakNema");

            migrationBuilder.DropColumn(
                name: "MelkType",
                table: "AmlakMoshakhase");

            migrationBuilder.DropColumn(
                name: "TypeHome",
                table: "AmlakMoshakhase");

            migrationBuilder.DropColumn(
                name: "MelkType",
                table: "AmlakMoshaat");

            migrationBuilder.DropColumn(
                name: "TypeHome",
                table: "AmlakMoshaat");

            migrationBuilder.DropColumn(
                name: "MelkType",
                table: "AmlakMogheiatMelk");

            migrationBuilder.DropColumn(
                name: "TypeHome",
                table: "AmlakMogheiatMelk");

            migrationBuilder.DropColumn(
                name: "MelkType",
                table: "AmlakMelkStatus");

            migrationBuilder.DropColumn(
                name: "TypeHome",
                table: "AmlakMelkStatus");

            migrationBuilder.DropColumn(
                name: "MelkType",
                table: "AmlakKitchen");

            migrationBuilder.DropColumn(
                name: "TypeHome",
                table: "AmlakKitchen");

            migrationBuilder.DropColumn(
                name: "MelkType",
                table: "AmlakKaf");

            migrationBuilder.DropColumn(
                name: "TypeHome",
                table: "AmlakKaf");

            migrationBuilder.DropColumn(
                name: "MelkType",
                table: "AmlakJahatVahed");

            migrationBuilder.DropColumn(
                name: "TypeHome",
                table: "AmlakJahatVahed");

            migrationBuilder.DropColumn(
                name: "MelkType",
                table: "AmlakEskeleton");

            migrationBuilder.DropColumn(
                name: "TypeHome",
                table: "AmlakEskeleton");

            migrationBuilder.DropColumn(
                name: "MelkType",
                table: "AmlakEmtiaz");

            migrationBuilder.DropColumn(
                name: "TypeHome",
                table: "AmlakEmtiaz");

            migrationBuilder.DropColumn(
                name: "MelkType",
                table: "AmlakDivar");

            migrationBuilder.DropColumn(
                name: "TypeHome",
                table: "AmlakDivar");

            migrationBuilder.AlterColumn<int>(
                name: "CostChance",
                table: "VadieSetting",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "CostChance",
                table: "EjareSetting",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "CostChance",
                table: "CostSetting",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
