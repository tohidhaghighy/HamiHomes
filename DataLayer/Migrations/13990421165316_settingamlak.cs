using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class settingamlak : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Video",
                table: "Magzine",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Magzine",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Visit_Count",
                table: "Magzine",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AmlakDivar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
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
                    Name = table.Column<string>(nullable: true)
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
                    Name = table.Column<string>(nullable: true)
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
                    Name = table.Column<string>(nullable: true)
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
                    Name = table.Column<string>(nullable: true)
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
                    Name = table.Column<string>(nullable: true)
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
                    Name = table.Column<string>(nullable: true)
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
                    Name = table.Column<string>(nullable: true)
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
                    Name = table.Column<string>(nullable: true)
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
                    Name = table.Column<string>(nullable: true)
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
                    Name = table.Column<string>(nullable: true)
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
                    Name = table.Column<string>(nullable: true)
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
                    Name = table.Column<string>(nullable: true)
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
                    Name = table.Column<string>(nullable: true)
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
                    Name = table.Column<string>(nullable: true)
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
                    Name = table.Column<string>(nullable: true)
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
                    Name = table.Column<string>(nullable: true)
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
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmlakWC", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Visit_Count",
                table: "Magzine");

            migrationBuilder.AlterColumn<string>(
                name: "Video",
                table: "Magzine",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Magzine",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true);
        }
    }
}
