using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class addconnectivity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contractes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TypContract = table.Column<int>(nullable: false),
                    SellCOst = table.Column<long>(nullable: false),
                    RentCOst = table.Column<long>(nullable: false),
                    Vadie = table.Column<long>(nullable: false),
                    HomeId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    SelledOrRented = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contractes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zamins_HomeId",
                table: "Zamins",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vilas_HomeId",
                table: "Vilas",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Moshtghelats_HomeId",
                table: "Moshtghelats",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Maghazes_HomeId",
                table: "Maghazes",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Kolangis_HomeId",
                table: "Kolangis",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_HomewithGardens_HomeId",
                table: "HomewithGardens",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_gardenWithVilas_HomeId",
                table: "gardenWithVilas",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Gardenes_HomeId",
                table: "Gardenes",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Edaries_HomeId",
                table: "Edaries",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartemans_HomeId",
                table: "Apartemans",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Anbars_HomeId",
                table: "Anbars",
                column: "HomeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Anbars_Home_HomeId",
                table: "Anbars",
                column: "HomeId",
                principalTable: "Home",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Apartemans_Home_HomeId",
                table: "Apartemans",
                column: "HomeId",
                principalTable: "Home",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Edaries_Home_HomeId",
                table: "Edaries",
                column: "HomeId",
                principalTable: "Home",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gardenes_Home_HomeId",
                table: "Gardenes",
                column: "HomeId",
                principalTable: "Home",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_gardenWithVilas_Home_HomeId",
                table: "gardenWithVilas",
                column: "HomeId",
                principalTable: "Home",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomewithGardens_Home_HomeId",
                table: "HomewithGardens",
                column: "HomeId",
                principalTable: "Home",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kolangis_Home_HomeId",
                table: "Kolangis",
                column: "HomeId",
                principalTable: "Home",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Maghazes_Home_HomeId",
                table: "Maghazes",
                column: "HomeId",
                principalTable: "Home",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Moshtghelats_Home_HomeId",
                table: "Moshtghelats",
                column: "HomeId",
                principalTable: "Home",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vilas_Home_HomeId",
                table: "Vilas",
                column: "HomeId",
                principalTable: "Home",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Zamins_Home_HomeId",
                table: "Zamins",
                column: "HomeId",
                principalTable: "Home",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anbars_Home_HomeId",
                table: "Anbars");

            migrationBuilder.DropForeignKey(
                name: "FK_Apartemans_Home_HomeId",
                table: "Apartemans");

            migrationBuilder.DropForeignKey(
                name: "FK_Edaries_Home_HomeId",
                table: "Edaries");

            migrationBuilder.DropForeignKey(
                name: "FK_Gardenes_Home_HomeId",
                table: "Gardenes");

            migrationBuilder.DropForeignKey(
                name: "FK_gardenWithVilas_Home_HomeId",
                table: "gardenWithVilas");

            migrationBuilder.DropForeignKey(
                name: "FK_HomewithGardens_Home_HomeId",
                table: "HomewithGardens");

            migrationBuilder.DropForeignKey(
                name: "FK_Kolangis_Home_HomeId",
                table: "Kolangis");

            migrationBuilder.DropForeignKey(
                name: "FK_Maghazes_Home_HomeId",
                table: "Maghazes");

            migrationBuilder.DropForeignKey(
                name: "FK_Moshtghelats_Home_HomeId",
                table: "Moshtghelats");

            migrationBuilder.DropForeignKey(
                name: "FK_Vilas_Home_HomeId",
                table: "Vilas");

            migrationBuilder.DropForeignKey(
                name: "FK_Zamins_Home_HomeId",
                table: "Zamins");

            migrationBuilder.DropTable(
                name: "Contractes");

            migrationBuilder.DropIndex(
                name: "IX_Zamins_HomeId",
                table: "Zamins");

            migrationBuilder.DropIndex(
                name: "IX_Vilas_HomeId",
                table: "Vilas");

            migrationBuilder.DropIndex(
                name: "IX_Moshtghelats_HomeId",
                table: "Moshtghelats");

            migrationBuilder.DropIndex(
                name: "IX_Maghazes_HomeId",
                table: "Maghazes");

            migrationBuilder.DropIndex(
                name: "IX_Kolangis_HomeId",
                table: "Kolangis");

            migrationBuilder.DropIndex(
                name: "IX_HomewithGardens_HomeId",
                table: "HomewithGardens");

            migrationBuilder.DropIndex(
                name: "IX_gardenWithVilas_HomeId",
                table: "gardenWithVilas");

            migrationBuilder.DropIndex(
                name: "IX_Gardenes_HomeId",
                table: "Gardenes");

            migrationBuilder.DropIndex(
                name: "IX_Edaries_HomeId",
                table: "Edaries");

            migrationBuilder.DropIndex(
                name: "IX_Apartemans_HomeId",
                table: "Apartemans");

            migrationBuilder.DropIndex(
                name: "IX_Anbars_HomeId",
                table: "Anbars");
        }
    }
}
