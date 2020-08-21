using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class checkdbchange1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Nahie",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Selected",
                table: "HomeFacility",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Selected",
                table: "AmlakWC",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Selected",
                table: "AmlakTasisatGarmaieshi",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Selected",
                table: "AmlakSanadStatus",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Selected",
                table: "AmlakSaghf",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Selected",
                table: "AmlakPishraftStatus",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Selected",
                table: "AmlakParking",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Selected",
                table: "AmlakNoeZamin",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Selected",
                table: "AmlakNema",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Selected",
                table: "AmlakMoshakhase",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Selected",
                table: "AmlakMoshaat",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Selected",
                table: "AmlakMogheiatMelk",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Selected",
                table: "AmlakMelkStatus",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Selected",
                table: "AmlakKitchen",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Selected",
                table: "AmlakKaf",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Selected",
                table: "AmlakJahatVahed",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Selected",
                table: "AmlakEskeleton",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Selected",
                table: "AmlakEmtiaz",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Selected",
                table: "AmlakDivar",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "BackgroundImage",
                table: "Adviser",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Adviser",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Adviser",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExperienceYear",
                table: "Adviser",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Adviser",
                maxLength: 500,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Anbars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MetrazhBena = table.Column<int>(nullable: false),
                    Metrazhzamin = table.Column<int>(nullable: false),
                    NegahbaniName = table.Column<string>(maxLength: 500, nullable: true),
                    NegahbaniPhone = table.Column<string>(maxLength: 500, nullable: true),
                    HomeEmtiaz = table.Column<string>(maxLength: 1000, nullable: true),
                    HomeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anbars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Apartemans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ghadroalsahm = table.Column<string>(maxLength: 500, nullable: true),
                    MetrazhBena = table.Column<int>(nullable: false),
                    Metrazhzamin = table.Column<int>(nullable: false),
                    Tabaghe = table.Column<int>(nullable: false),
                    Tedadkoltabaghat = table.Column<int>(nullable: false),
                    Tedadkolvahedha = table.Column<int>(nullable: false),
                    Tedadvaheddartabaghe = table.Column<int>(nullable: false),
                    NegahbaniName = table.Column<string>(maxLength: 500, nullable: true),
                    NegahbaniPhone = table.Column<string>(maxLength: 500, nullable: true),
                    Homemogheiat = table.Column<string>(maxLength: 1000, nullable: true),
                    Homejahatevahed = table.Column<string>(maxLength: 1000, nullable: true),
                    Homemoshakhase = table.Column<string>(maxLength: 1000, nullable: true),
                    Homenema = table.Column<string>(maxLength: 1000, nullable: true),
                    Homemoshaat = table.Column<string>(maxLength: 1000, nullable: true),
                    Hometasisat = table.Column<string>(maxLength: 1000, nullable: true),
                    Homekaf = table.Column<string>(maxLength: 1000, nullable: true),
                    Homekitchen = table.Column<string>(maxLength: 1000, nullable: true),
                    Homewc = table.Column<string>(maxLength: 1000, nullable: true),
                    Homedivar = table.Column<string>(maxLength: 1000, nullable: true),
                    Homeparking = table.Column<string>(maxLength: 1000, nullable: true),
                    Homevaziate = table.Column<string>(maxLength: 1000, nullable: true),
                    HomeEmtiaz = table.Column<string>(maxLength: 1000, nullable: true),
                    Homesanad = table.Column<string>(maxLength: 1000, nullable: true),
                    HomeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartemans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Edaries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MetrazhBena = table.Column<int>(nullable: false),
                    Tabaghe = table.Column<int>(nullable: false),
                    TedadOtagh = table.Column<int>(nullable: false),
                    Tedadkoltabaghat = table.Column<int>(nullable: false),
                    Tedadkolvahedha = table.Column<int>(nullable: false),
                    Tedadvaheddartabaghe = table.Column<int>(nullable: false),
                    NegahbaniName = table.Column<string>(maxLength: 500, nullable: true),
                    NegahbaniPhone = table.Column<string>(maxLength: 500, nullable: true),
                    Homemogheiat = table.Column<string>(maxLength: 1000, nullable: true),
                    Homenema = table.Column<string>(maxLength: 1000, nullable: true),
                    Hometasisat = table.Column<string>(maxLength: 1000, nullable: true),
                    Homekaf = table.Column<string>(maxLength: 1000, nullable: true),
                    Homewc = table.Column<string>(maxLength: 1000, nullable: true),
                    Homeparking = table.Column<string>(maxLength: 1000, nullable: true),
                    Homevaziate = table.Column<string>(maxLength: 1000, nullable: true),
                    HomeEmtiaz = table.Column<string>(maxLength: 1000, nullable: true),
                    Homesanad = table.Column<string>(maxLength: 1000, nullable: true),
                    HomeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Edaries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gardenes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Metrazhzamin = table.Column<int>(nullable: false),
                    NegahbaniName = table.Column<string>(maxLength: 500, nullable: true),
                    NegahbaniPhone = table.Column<string>(maxLength: 500, nullable: true),
                    HomeEmtiaz = table.Column<string>(maxLength: 1000, nullable: true),
                    HomeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gardenes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "gardenWithVilas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ghadroalsahm = table.Column<string>(maxLength: 500, nullable: true),
                    MetrazhBena = table.Column<int>(nullable: false),
                    Metrazhzamin = table.Column<int>(nullable: false),
                    Tabaghe = table.Column<int>(nullable: false),
                    TedadOtagh = table.Column<int>(nullable: false),
                    Tedadkoltabaghat = table.Column<int>(nullable: false),
                    NegahbaniName = table.Column<string>(maxLength: 500, nullable: true),
                    NegahbaniPhone = table.Column<string>(maxLength: 500, nullable: true),
                    Homemogheiat = table.Column<string>(maxLength: 1000, nullable: true),
                    Homemoshakhase = table.Column<string>(maxLength: 1000, nullable: true),
                    Homenema = table.Column<string>(maxLength: 1000, nullable: true),
                    Homemoshaat = table.Column<string>(maxLength: 1000, nullable: true),
                    Hometasisat = table.Column<string>(maxLength: 1000, nullable: true),
                    Homekaf = table.Column<string>(maxLength: 1000, nullable: true),
                    Homekitchen = table.Column<string>(maxLength: 1000, nullable: true),
                    Homewc = table.Column<string>(maxLength: 1000, nullable: true),
                    Homedivar = table.Column<string>(maxLength: 1000, nullable: true),
                    Homeparking = table.Column<string>(maxLength: 1000, nullable: true),
                    Homevaziate = table.Column<string>(maxLength: 1000, nullable: true),
                    HomeEmtiaz = table.Column<string>(maxLength: 1000, nullable: true),
                    Homesanad = table.Column<string>(maxLength: 1000, nullable: true),
                    HomeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gardenWithVilas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Home",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Address = table.Column<string>(maxLength: 500, nullable: false),
                    Title = table.Column<string>(nullable: true),
                    BuildYear = table.Column<int>(nullable: false),
                    Bed = table.Column<int>(nullable: false),
                    Bath = table.Column<int>(nullable: false),
                    HomeMapImage = table.Column<string>(maxLength: 500, nullable: true),
                    ThreeDView = table.Column<string>(maxLength: 500, nullable: true),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    IsShow = table.Column<bool>(nullable: false),
                    Gpsx = table.Column<string>(maxLength: 50, nullable: false),
                    Gpsy = table.Column<string>(maxLength: 50, nullable: false),
                    OwnerName = table.Column<string>(maxLength: 200, nullable: false),
                    Phone = table.Column<string>(maxLength: 100, nullable: true),
                    Mobile = table.Column<string>(maxLength: 100, nullable: false),
                    Image = table.Column<string>(maxLength: 1000, nullable: true),
                    IsPrivate = table.Column<bool>(nullable: false),
                    AdvisorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Home", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomewithGardens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MetrazhBena = table.Column<int>(nullable: false),
                    Metrazhzamin = table.Column<int>(nullable: false),
                    Arzegozar = table.Column<int>(nullable: false),
                    Arzemelk = table.Column<int>(nullable: false),
                    Tedadkoltabaghat = table.Column<int>(nullable: false),
                    Homemogheiat = table.Column<string>(maxLength: 1000, nullable: true),
                    Homemoshakhase = table.Column<string>(maxLength: 1000, nullable: true),
                    Homenema = table.Column<string>(maxLength: 1000, nullable: true),
                    Hometasisat = table.Column<string>(maxLength: 1000, nullable: true),
                    Homekaf = table.Column<string>(maxLength: 1000, nullable: true),
                    Homekitchen = table.Column<string>(maxLength: 1000, nullable: true),
                    Homewc = table.Column<string>(maxLength: 1000, nullable: true),
                    Homedivar = table.Column<string>(maxLength: 1000, nullable: true),
                    Homeparking = table.Column<string>(maxLength: 1000, nullable: true),
                    Homevaziate = table.Column<string>(maxLength: 1000, nullable: true),
                    HomeEmtiaz = table.Column<string>(maxLength: 1000, nullable: true),
                    Homesanad = table.Column<string>(maxLength: 1000, nullable: true),
                    HomeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomewithGardens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kolangis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Metrazhbena = table.Column<int>(nullable: false),
                    Metrazhzamin = table.Column<int>(nullable: false),
                    Arzegozar = table.Column<int>(nullable: false),
                    Arzemelk = table.Column<int>(nullable: false),
                    NegahbaniName = table.Column<string>(maxLength: 500, nullable: true),
                    NegahbaniPhone = table.Column<string>(maxLength: 500, nullable: true),
                    Homemogheiat = table.Column<string>(maxLength: 1000, nullable: true),
                    Homemoshakhase = table.Column<string>(maxLength: 1000, nullable: true),
                    Homevaziate = table.Column<string>(maxLength: 1000, nullable: true),
                    HomeEmtiaz = table.Column<string>(maxLength: 1000, nullable: true),
                    Homesanad = table.Column<string>(maxLength: 1000, nullable: true),
                    HomeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kolangis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Maghazes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MetrazhKafMaghaze = table.Column<int>(nullable: false),
                    DahaneMaghaze = table.Column<int>(nullable: false),
                    Tabaghe = table.Column<int>(nullable: false),
                    Metrazhbalkon = table.Column<int>(nullable: false),
                    Metrazhanbar = table.Column<int>(nullable: false),
                    NegahbaniName = table.Column<string>(maxLength: 500, nullable: true),
                    NegahbaniPhone = table.Column<string>(maxLength: 500, nullable: true),
                    Homemogheiat = table.Column<string>(maxLength: 1000, nullable: true),
                    Homemoshakhase = table.Column<string>(maxLength: 1000, nullable: true),
                    Homewc = table.Column<string>(maxLength: 1000, nullable: true),
                    Homedivar = table.Column<string>(maxLength: 1000, nullable: true),
                    Homeparking = table.Column<string>(maxLength: 1000, nullable: true),
                    Homevaziatemelk = table.Column<string>(maxLength: 1000, nullable: true),
                    HomeEmtiaz = table.Column<string>(maxLength: 1000, nullable: true),
                    Homesanad = table.Column<string>(maxLength: 1000, nullable: true),
                    HomeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maghazes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Moshtghelats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ghadroalsahm = table.Column<string>(maxLength: 500, nullable: true),
                    MetrazhBena = table.Column<int>(nullable: false),
                    Metrazhzamin = table.Column<int>(nullable: false),
                    Tabaghe = table.Column<int>(nullable: false),
                    Tedadkoltabaghat = table.Column<int>(nullable: false),
                    Tedadkolvahedha = table.Column<int>(nullable: false),
                    Tedadvaheddartabaghe = table.Column<int>(nullable: false),
                    Arzegozar = table.Column<int>(nullable: false),
                    Arzemelk = table.Column<int>(nullable: false),
                    NegahbaniName = table.Column<string>(maxLength: 500, nullable: true),
                    NegahbaniPhone = table.Column<string>(maxLength: 500, nullable: true),
                    Homemogheiat = table.Column<string>(maxLength: 1000, nullable: true),
                    Homemoshakhase = table.Column<string>(maxLength: 1000, nullable: true),
                    Homenema = table.Column<string>(maxLength: 1000, nullable: true),
                    Homemoshaat = table.Column<string>(maxLength: 1000, nullable: true),
                    Hometasisat = table.Column<string>(maxLength: 1000, nullable: true),
                    Homekaf = table.Column<string>(maxLength: 1000, nullable: true),
                    Homekitchen = table.Column<string>(maxLength: 1000, nullable: true),
                    Homewc = table.Column<string>(maxLength: 1000, nullable: true),
                    Homedivar = table.Column<string>(maxLength: 1000, nullable: true),
                    Homeparking = table.Column<string>(maxLength: 1000, nullable: true),
                    Homevaziate = table.Column<string>(maxLength: 1000, nullable: true),
                    HomeEmtiaz = table.Column<string>(maxLength: 1000, nullable: true),
                    Homesanad = table.Column<string>(maxLength: 1000, nullable: true),
                    HomeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moshtghelats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vilas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MetrazhBena = table.Column<int>(nullable: false),
                    Metrazhzamin = table.Column<int>(nullable: false),
                    Tedadkoltabaghat = table.Column<int>(nullable: false),
                    NegahbaniName = table.Column<string>(maxLength: 500, nullable: true),
                    NegahbaniPhone = table.Column<string>(maxLength: 500, nullable: true),
                    Homemogheiat = table.Column<string>(maxLength: 1000, nullable: true),
                    Homemoshakhase = table.Column<string>(maxLength: 1000, nullable: true),
                    Homenema = table.Column<string>(maxLength: 1000, nullable: true),
                    Homemoshaat = table.Column<string>(maxLength: 1000, nullable: true),
                    Hometasisat = table.Column<string>(maxLength: 1000, nullable: true),
                    Homekaf = table.Column<string>(maxLength: 1000, nullable: true),
                    Homekitchen = table.Column<string>(maxLength: 1000, nullable: true),
                    Homewc = table.Column<string>(maxLength: 1000, nullable: true),
                    Homedivar = table.Column<string>(maxLength: 1000, nullable: true),
                    Homeparking = table.Column<string>(maxLength: 1000, nullable: true),
                    Homevaziate = table.Column<string>(maxLength: 1000, nullable: true),
                    HomeEmtiaz = table.Column<string>(maxLength: 1000, nullable: true),
                    Homesanad = table.Column<string>(maxLength: 1000, nullable: true),
                    HomeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vilas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zamins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Metrazhzamin = table.Column<int>(nullable: false),
                    Arzegozar = table.Column<int>(nullable: false),
                    Arzemelk = table.Column<int>(nullable: false),
                    NegahbaniName = table.Column<string>(maxLength: 500, nullable: true),
                    NegahbaniPhone = table.Column<string>(maxLength: 500, nullable: true),
                    Homemogheiat = table.Column<string>(maxLength: 1000, nullable: true),
                    Homevaziate = table.Column<string>(maxLength: 1000, nullable: true),
                    HomeEmtiaz = table.Column<string>(maxLength: 1000, nullable: true),
                    Homesanad = table.Column<string>(maxLength: 1000, nullable: true),
                    HomeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zamins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeGallery",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Url = table.Column<string>(nullable: true),
                    HomeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeGallery", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomeGallery_Home_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Home",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HomeGallery_HomeId",
                table: "HomeGallery",
                column: "HomeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anbars");

            migrationBuilder.DropTable(
                name: "Apartemans");

            migrationBuilder.DropTable(
                name: "Edaries");

            migrationBuilder.DropTable(
                name: "Gardenes");

            migrationBuilder.DropTable(
                name: "gardenWithVilas");

            migrationBuilder.DropTable(
                name: "HomeGallery");

            migrationBuilder.DropTable(
                name: "HomewithGardens");

            migrationBuilder.DropTable(
                name: "Kolangis");

            migrationBuilder.DropTable(
                name: "Maghazes");

            migrationBuilder.DropTable(
                name: "Moshtghelats");

            migrationBuilder.DropTable(
                name: "Vilas");

            migrationBuilder.DropTable(
                name: "Zamins");

            migrationBuilder.DropTable(
                name: "Home");

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Nahie");

            migrationBuilder.DropColumn(
                name: "Selected",
                table: "HomeFacility");

            migrationBuilder.DropColumn(
                name: "Selected",
                table: "AmlakWC");

            migrationBuilder.DropColumn(
                name: "Selected",
                table: "AmlakTasisatGarmaieshi");

            migrationBuilder.DropColumn(
                name: "Selected",
                table: "AmlakSanadStatus");

            migrationBuilder.DropColumn(
                name: "Selected",
                table: "AmlakSaghf");

            migrationBuilder.DropColumn(
                name: "Selected",
                table: "AmlakPishraftStatus");

            migrationBuilder.DropColumn(
                name: "Selected",
                table: "AmlakParking");

            migrationBuilder.DropColumn(
                name: "Selected",
                table: "AmlakNoeZamin");

            migrationBuilder.DropColumn(
                name: "Selected",
                table: "AmlakNema");

            migrationBuilder.DropColumn(
                name: "Selected",
                table: "AmlakMoshakhase");

            migrationBuilder.DropColumn(
                name: "Selected",
                table: "AmlakMoshaat");

            migrationBuilder.DropColumn(
                name: "Selected",
                table: "AmlakMogheiatMelk");

            migrationBuilder.DropColumn(
                name: "Selected",
                table: "AmlakMelkStatus");

            migrationBuilder.DropColumn(
                name: "Selected",
                table: "AmlakKitchen");

            migrationBuilder.DropColumn(
                name: "Selected",
                table: "AmlakKaf");

            migrationBuilder.DropColumn(
                name: "Selected",
                table: "AmlakJahatVahed");

            migrationBuilder.DropColumn(
                name: "Selected",
                table: "AmlakEskeleton");

            migrationBuilder.DropColumn(
                name: "Selected",
                table: "AmlakEmtiaz");

            migrationBuilder.DropColumn(
                name: "Selected",
                table: "AmlakDivar");

            migrationBuilder.DropColumn(
                name: "BackgroundImage",
                table: "Adviser");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Adviser");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Adviser");

            migrationBuilder.DropColumn(
                name: "ExperienceYear",
                table: "Adviser");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Adviser");
        }
    }
}
