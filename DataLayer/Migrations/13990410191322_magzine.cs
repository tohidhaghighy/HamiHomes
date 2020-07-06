using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class magzine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MagzineType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Icon = table.Column<string>(maxLength: 500, nullable: true),
                    MagzineTypeId = table.Column<int>(nullable: true)
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
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Text = table.Column<string>(nullable: false),
                    Date = table.Column<string>(maxLength: 100, nullable: false),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Is_Show = table.Column<bool>(nullable: false),
                    Tags = table.Column<string>(maxLength: 500, nullable: true),
                    Video = table.Column<string>(nullable: true),
                    MagzineTypeId = table.Column<int>(nullable: false)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Magzine");

            migrationBuilder.DropTable(
                name: "MagzineType");
        }
    }
}
