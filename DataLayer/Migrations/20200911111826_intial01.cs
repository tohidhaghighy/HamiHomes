using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class intial01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Family = table.Column<string>(maxLength: 50, nullable: false),
                    Username = table.Column<string>(maxLength: 100, nullable: false),
                    Password = table.Column<string>(maxLength: 500, nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    AdminType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Adviser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Family = table.Column<string>(maxLength: 50, nullable: false),
                    Username = table.Column<string>(maxLength: 100, nullable: false),
                    Password = table.Column<string>(maxLength: 500, nullable: false),
                    Mobile = table.Column<string>(maxLength: 20, nullable: false),
                    Image = table.Column<string>(maxLength: 500, nullable: true),
                    BackgroundImage = table.Column<string>(maxLength: 500, nullable: true),
                    ExperienceYear = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    BuyTakhasos = table.Column<string>(nullable: true),
                    RentTakhasos = table.Column<string>(nullable: true),
                    Manategh = table.Column<string>(nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CanAdd = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adviser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmlakDivar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TypeHome = table.Column<int>(nullable: false),
                    MelkType = table.Column<int>(nullable: false),
                    Selected = table.Column<bool>(nullable: false),
                    ShowinSearch = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmlakDivar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmlakEmtiaz",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TypeHome = table.Column<int>(nullable: false),
                    MelkType = table.Column<int>(nullable: false),
                    Selected = table.Column<bool>(nullable: false),
                    ShowinSearch = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmlakEmtiaz", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmlakEskeleton",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TypeHome = table.Column<int>(nullable: false),
                    MelkType = table.Column<int>(nullable: false),
                    Selected = table.Column<bool>(nullable: false),
                    ShowinSearch = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmlakEskeleton", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmlakJahatVahed",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TypeHome = table.Column<int>(nullable: false),
                    MelkType = table.Column<int>(nullable: false),
                    Selected = table.Column<bool>(nullable: false),
                    ShowinSearch = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmlakJahatVahed", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmlakKaf",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TypeHome = table.Column<int>(nullable: false),
                    MelkType = table.Column<int>(nullable: false),
                    Selected = table.Column<bool>(nullable: false),
                    ShowinSearch = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmlakKaf", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmlakKitchen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TypeHome = table.Column<int>(nullable: false),
                    MelkType = table.Column<int>(nullable: false),
                    Selected = table.Column<bool>(nullable: false),
                    ShowinSearch = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmlakKitchen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmlakMelkStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TypeHome = table.Column<int>(nullable: false),
                    MelkType = table.Column<int>(nullable: false),
                    Selected = table.Column<bool>(nullable: false),
                    ShowinSearch = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmlakMelkStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmlakMogheiatMelk",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TypeHome = table.Column<int>(nullable: false),
                    MelkType = table.Column<int>(nullable: false),
                    Selected = table.Column<bool>(nullable: false),
                    ShowinSearch = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmlakMogheiatMelk", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmlakMoshaat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TypeHome = table.Column<int>(nullable: false),
                    MelkType = table.Column<int>(nullable: false),
                    Selected = table.Column<bool>(nullable: false),
                    ShowinSearch = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmlakMoshaat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmlakMoshakhase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TypeHome = table.Column<int>(nullable: false),
                    MelkType = table.Column<int>(nullable: false),
                    Selected = table.Column<bool>(nullable: false),
                    ShowinSearch = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmlakMoshakhase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmlakNema",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TypeHome = table.Column<int>(nullable: false),
                    MelkType = table.Column<int>(nullable: false),
                    Selected = table.Column<bool>(nullable: false),
                    ShowinSearch = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmlakNema", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmlakNoeZamin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TypeHome = table.Column<int>(nullable: false),
                    MelkType = table.Column<int>(nullable: false),
                    Selected = table.Column<bool>(nullable: false),
                    ShowinSearch = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmlakNoeZamin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmlakParking",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TypeHome = table.Column<int>(nullable: false),
                    MelkType = table.Column<int>(nullable: false),
                    Selected = table.Column<bool>(nullable: false),
                    ShowinSearch = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmlakParking", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmlakPishraftStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TypeHome = table.Column<int>(nullable: false),
                    MelkType = table.Column<int>(nullable: false),
                    Selected = table.Column<bool>(nullable: false),
                    ShowinSearch = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmlakPishraftStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmlakSaghf",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TypeHome = table.Column<int>(nullable: false),
                    MelkType = table.Column<int>(nullable: false),
                    Selected = table.Column<bool>(nullable: false),
                    ShowinSearch = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmlakSaghf", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmlakSanadStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TypeHome = table.Column<int>(nullable: false),
                    MelkType = table.Column<int>(nullable: false),
                    Selected = table.Column<bool>(nullable: false),
                    ShowinSearch = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmlakSanadStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmlakTasisatGarmaieshi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TypeHome = table.Column<int>(nullable: false),
                    MelkType = table.Column<int>(nullable: false),
                    Selected = table.Column<bool>(nullable: false),
                    ShowinSearch = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmlakTasisatGarmaieshi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmlakWC",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TypeHome = table.Column<int>(nullable: false),
                    MelkType = table.Column<int>(nullable: false),
                    Selected = table.Column<bool>(nullable: false),
                    ShowinSearch = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmlakWC", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CostSetting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cost = table.Column<string>(nullable: true),
                    CostChance = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Family = table.Column<string>(nullable: false),
                    Number = table.Column<string>(nullable: false),
                    Fathername = table.Column<string>(nullable: false),
                    Shenasname = table.Column<string>(nullable: false),
                    Sadere = table.Column<string>(nullable: false),
                    Birthdate = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EjareSetting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cost = table.Column<string>(nullable: true),
                    CostChance = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EjareSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Home",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Address = table.Column<string>(maxLength: 500, nullable: false),
                    Postalcode = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    HomeMapImage = table.Column<string>(maxLength: 500, nullable: true),
                    ThreeDView = table.Column<string>(maxLength: 500, nullable: true),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    BuildYear = table.Column<int>(nullable: false),
                    Bed = table.Column<int>(nullable: false),
                    Bath = table.Column<int>(nullable: false),
                    Parking = table.Column<int>(nullable: false),
                    Bana = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    IsShow = table.Column<bool>(nullable: false),
                    Gpsx = table.Column<string>(maxLength: 50, nullable: false),
                    Gpsy = table.Column<string>(maxLength: 50, nullable: false),
                    OwnerName = table.Column<string>(maxLength: 200, nullable: false),
                    Phone = table.Column<string>(maxLength: 100, nullable: true),
                    Mobile = table.Column<string>(maxLength: 100, nullable: false),
                    Image = table.Column<string>(maxLength: 1000, nullable: true),
                    IsPrivate = table.Column<bool>(nullable: false),
                    AdvisorId = table.Column<int>(nullable: true),
                    Hometype = table.Column<int>(nullable: false),
                    HometypeId = table.Column<int>(nullable: false),
                    Usertype = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Home", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeFacility",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Icon = table.Column<string>(maxLength: 500, nullable: true),
                    TypeHome = table.Column<int>(nullable: false),
                    MelkType = table.Column<int>(nullable: false),
                    Selected = table.Column<bool>(nullable: false),
                    ShowinSearch = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeFacility", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Icon = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LogText = table.Column<string>(nullable: false),
                    LogController = table.Column<string>(nullable: false),
                    LogView = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.Id);
                });

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
                name: "MetrazSetting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Metraz = table.Column<string>(nullable: true),
                    MetrazChance = table.Column<int>(nullable: false),
                    TypeMetraz = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetrazSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Gpsx = table.Column<string>(maxLength: 50, nullable: false),
                    Gpsy = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Instagram = table.Column<string>(maxLength: 500, nullable: true),
                    Twitter = table.Column<string>(maxLength: 500, nullable: true),
                    Telegram = table.Column<string>(maxLength: 500, nullable: true),
                    Googleplus = table.Column<string>(maxLength: 500, nullable: true),
                    Aparat = table.Column<string>(maxLength: 500, nullable: true),
                    Youtube = table.Column<string>(maxLength: 500, nullable: true),
                    Icon = table.Column<string>(maxLength: 500, nullable: true),
                    Title = table.Column<string>(maxLength: 500, nullable: true),
                    Keys = table.Column<string>(maxLength: 1000, nullable: true),
                    Author = table.Column<string>(maxLength: 500, nullable: true),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    Phone = table.Column<string>(maxLength: 100, nullable: true),
                    Mobile = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Family = table.Column<string>(maxLength: 50, nullable: false),
                    Username = table.Column<string>(maxLength: 100, nullable: false),
                    Password = table.Column<string>(maxLength: 500, nullable: false),
                    Mobile = table.Column<string>(maxLength: 20, nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Activecode = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VadieSetting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cost = table.Column<string>(nullable: true),
                    CostChance = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VadieSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Anbars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MetrazhBena = table.Column<int>(nullable: false),
                    Metrazhzamin = table.Column<int>(nullable: false),
                    Arzegozar = table.Column<int>(nullable: false),
                    Arzemelk = table.Column<int>(nullable: false),
                    NegahbaniName = table.Column<string>(maxLength: 500, nullable: true),
                    NegahbaniPhone = table.Column<string>(maxLength: 500, nullable: true),
                    HomeEmtiaz = table.Column<string>(maxLength: 1000, nullable: true),
                    SanadStatus = table.Column<string>(nullable: true),
                    MoghiateMelk = table.Column<string>(nullable: true),
                    HomeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anbars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Anbars_Home_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Home",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    HomeFacilities = table.Column<string>(nullable: true),
                    HomeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartemans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apartemans_Home_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Home",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contract",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TypContract = table.Column<int>(nullable: false),
                    BuyCost = table.Column<long>(nullable: false),
                    RentCOst = table.Column<long>(nullable: false),
                    Vadie = table.Column<long>(nullable: false),
                    Metraz = table.Column<int>(nullable: false),
                    MetrazZamin = table.Column<int>(nullable: false),
                    HomeId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    FinalCost1 = table.Column<long>(nullable: true),
                    FinalCost2 = table.Column<long>(nullable: true),
                    FinalCost3 = table.Column<long>(nullable: true),
                    SelledOrRented = table.Column<bool>(nullable: false),
                    AdviserId = table.Column<int>(nullable: true),
                    CostumerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contract", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contract_Adviser_AdviserId",
                        column: x => x.AdviserId,
                        principalTable: "Adviser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contract_Home_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Home",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_Edaries_Home_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Home",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_Gardenes_Home_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Home",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_gardenWithVilas_Home_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Home",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_HomewithGardens_Home_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Home",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_Kolangis_Home_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Home",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_Maghazes_Home_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Home",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_Moshtghelats_Home_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Home",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_Vilas_Home_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Home",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_Zamins_Home_HomeId",
                        column: x => x.HomeId,
                        principalTable: "Home",
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
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    RegionId = table.Column<int>(nullable: false),
                    CityPhoneCode = table.Column<string>(nullable: true),
                    Gpsx = table.Column<string>(maxLength: 50, nullable: false),
                    Gpsy = table.Column<string>(maxLength: 50, nullable: false),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_Region_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Region",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Icon = table.Column<string>(maxLength: 1000, nullable: false),
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
                name: "IX_Anbars_HomeId",
                table: "Anbars",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartemans_HomeId",
                table: "Apartemans",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_City_RegionId",
                table: "City",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_AdviserId",
                table: "Contract",
                column: "AdviserId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_HomeId",
                table: "Contract",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Edaries_HomeId",
                table: "Edaries",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Gardenes_HomeId",
                table: "Gardenes",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_gardenWithVilas_HomeId",
                table: "gardenWithVilas",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeGallery_HomeId",
                table: "HomeGallery",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_HomewithGardens_HomeId",
                table: "HomewithGardens",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Kolangis_HomeId",
                table: "Kolangis",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Magazin_MagazinGroupId",
                table: "Magazin",
                column: "MagazinGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Maghazes_HomeId",
                table: "Maghazes",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Mahale_NahieId",
                table: "Mahale",
                column: "NahieId");

            migrationBuilder.CreateIndex(
                name: "IX_Moshtghelats_HomeId",
                table: "Moshtghelats",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Nahie_CityId",
                table: "Nahie",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Vilas_HomeId",
                table: "Vilas",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Zamins_HomeId",
                table: "Zamins",
                column: "HomeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "AmlakDivar");

            migrationBuilder.DropTable(
                name: "AmlakEmtiaz");

            migrationBuilder.DropTable(
                name: "AmlakEskeleton");

            migrationBuilder.DropTable(
                name: "AmlakJahatVahed");

            migrationBuilder.DropTable(
                name: "AmlakKaf");

            migrationBuilder.DropTable(
                name: "AmlakKitchen");

            migrationBuilder.DropTable(
                name: "AmlakMelkStatus");

            migrationBuilder.DropTable(
                name: "AmlakMogheiatMelk");

            migrationBuilder.DropTable(
                name: "AmlakMoshaat");

            migrationBuilder.DropTable(
                name: "AmlakMoshakhase");

            migrationBuilder.DropTable(
                name: "AmlakNema");

            migrationBuilder.DropTable(
                name: "AmlakNoeZamin");

            migrationBuilder.DropTable(
                name: "AmlakParking");

            migrationBuilder.DropTable(
                name: "AmlakPishraftStatus");

            migrationBuilder.DropTable(
                name: "AmlakSaghf");

            migrationBuilder.DropTable(
                name: "AmlakSanadStatus");

            migrationBuilder.DropTable(
                name: "AmlakTasisatGarmaieshi");

            migrationBuilder.DropTable(
                name: "AmlakWC");

            migrationBuilder.DropTable(
                name: "Anbars");

            migrationBuilder.DropTable(
                name: "Apartemans");

            migrationBuilder.DropTable(
                name: "Contract");

            migrationBuilder.DropTable(
                name: "CostSetting");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Edaries");

            migrationBuilder.DropTable(
                name: "EjareSetting");

            migrationBuilder.DropTable(
                name: "Gardenes");

            migrationBuilder.DropTable(
                name: "gardenWithVilas");

            migrationBuilder.DropTable(
                name: "HomeFacility");

            migrationBuilder.DropTable(
                name: "HomeGallery");

            migrationBuilder.DropTable(
                name: "HomeGroup");

            migrationBuilder.DropTable(
                name: "HomewithGardens");

            migrationBuilder.DropTable(
                name: "Kolangis");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "Magazin");

            migrationBuilder.DropTable(
                name: "Maghazes");

            migrationBuilder.DropTable(
                name: "Mahale");

            migrationBuilder.DropTable(
                name: "MetrazSetting");

            migrationBuilder.DropTable(
                name: "Moshtghelats");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "VadieSetting");

            migrationBuilder.DropTable(
                name: "Vilas");

            migrationBuilder.DropTable(
                name: "Zamins");

            migrationBuilder.DropTable(
                name: "Adviser");

            migrationBuilder.DropTable(
                name: "MagazinGroup");

            migrationBuilder.DropTable(
                name: "Nahie");

            migrationBuilder.DropTable(
                name: "Home");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Region");
        }
    }
}
