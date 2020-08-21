using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class addnahie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Magzine");

            migrationBuilder.DropTable(
                name: "MagzineType");

            migrationBuilder.AlterColumn<string>(
                name: "LogView",
                table: "Log",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LogText",
                table: "Log",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LogController",
                table: "Log",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "MagazinGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    ParentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagazinGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nahie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Gpsx = table.Column<string>(maxLength: 50, nullable: false),
                    Gpsy = table.Column<string>(maxLength: 50, nullable: false),
                    CityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nahie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nahie_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Magazin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Image = table.Column<string>(maxLength: 500, nullable: true),
                    Text = table.Column<string>(nullable: false),
                    Tags = table.Column<string>(maxLength: 500, nullable: true),
                    ViewerCount = table.Column<int>(nullable: false),
                    UrlTour360 = table.Column<string>(maxLength: 500, nullable: true),
                    MagazinGroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Magazin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Magazin_MagazinGroup_MagazinGroupId",
                        column: x => x.MagazinGroupId,
                        principalTable: "MagazinGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mahale",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Gpsx = table.Column<string>(maxLength: 50, nullable: false),
                    Gpsy = table.Column<string>(maxLength: 50, nullable: false),
                    NahieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mahale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mahale_Nahie_NahieId",
                        column: x => x.NahieId,
                        principalTable: "Nahie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Magazin_MagazinGroupId",
                table: "Magazin",
                column: "MagazinGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Mahale_NahieId",
                table: "Mahale",
                column: "NahieId");

            migrationBuilder.CreateIndex(
                name: "IX_Nahie_CityId",
                table: "Nahie",
                column: "CityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Magazin");

            migrationBuilder.DropTable(
                name: "Mahale");

            migrationBuilder.DropTable(
                name: "MagazinGroup");

            migrationBuilder.DropTable(
                name: "Nahie");

            migrationBuilder.AlterColumn<string>(
                name: "LogView",
                table: "Log",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LogText",
                table: "Log",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LogController",
                table: "Log",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateTable(
                name: "MagzineType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Icon = table.Column<string>(maxLength: 500, nullable: true),
                    MagzineTypeId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagzineType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Magzine",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<string>(maxLength: 100, nullable: false),
                    Image = table.Column<string>(maxLength: 500, nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    Is_Show = table.Column<bool>(nullable: false),
                    MagzineTypeId = table.Column<int>(nullable: false),
                    Tags = table.Column<string>(maxLength: 500, nullable: true),
                    Text = table.Column<string>(nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Video = table.Column<string>(maxLength: 500, nullable: true),
                    Visit_Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Magzine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Magzine_MagzineType_MagzineTypeId",
                        column: x => x.MagzineTypeId,
                        principalTable: "MagzineType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Magzine_MagzineTypeId",
                table: "Magzine",
                column: "MagzineTypeId");
        }
    }
}
