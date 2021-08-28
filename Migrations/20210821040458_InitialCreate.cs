using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Statdrop.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Solutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatePlayed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Team = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rival = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RivalScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solutions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Solutions",
                columns: new[] { "Id", "DatePlayed", "Rival", "RivalScore", "Team", "TeamScore", "Title" },
                values: new object[] { 1, new DateTime(2021, 8, 20, 21, 4, 57, 875, DateTimeKind.Local).AddTicks(2721), "Ballers", 23m, "Unicorns n Rainbows", 30m, "Scrims" });

            migrationBuilder.InsertData(
                table: "Solutions",
                columns: new[] { "Id", "DatePlayed", "Rival", "RivalScore", "Team", "TeamScore", "Title" },
                values: new object[] { 2, new DateTime(2021, 8, 20, 21, 4, 57, 877, DateTimeKind.Local).AddTicks(6941), "Peons", 32m, "GrayJoy", 29m, "Scrims2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Solutions");
        }
    }
}
