using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WineCatalogApp.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Wines",
                columns: table => new
                {
                    WineIDNumber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WineName = table.Column<string>(maxLength: 100, nullable: false),
                    WineryName = table.Column<string>(maxLength: 100, nullable: false),
                    Vintange = table.Column<int>(nullable: false),
                    WineScore = table.Column<int>(nullable: false),
                    WineVarietals = table.Column<string>(nullable: true),
                    WineRegion = table.Column<string>(nullable: false),
                    WinePrice = table.Column<double>(maxLength: 10, nullable: false),
                    SampledDate = table.Column<string>(nullable: false),
                    RecordedDate = table.Column<DateTime>(nullable: false),
                    WineNotes = table.Column<string>(nullable: false),
                    CommentsEmail = table.Column<string>(nullable: true),
                    WineComments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wines", x => x.WineIDNumber);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Wines");
        }
    }
}
