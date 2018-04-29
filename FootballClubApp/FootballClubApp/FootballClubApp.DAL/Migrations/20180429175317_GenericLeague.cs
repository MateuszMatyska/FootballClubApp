using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FootballClubApp.DAL.Migrations
{
    public partial class GenericLeague : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "League");

            migrationBuilder.CreateTable(
                name: "CountryLeague",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClubName = table.Column<string>(nullable: true),
                    Draws = table.Column<int>(nullable: false),
                    Loses = table.Column<int>(nullable: false),
                    MatchesAmount = table.Column<int>(nullable: false),
                    Place = table.Column<int>(nullable: false),
                    Points = table.Column<int>(nullable: false),
                    SeasonId = table.Column<int>(nullable: false),
                    Wins = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryLeague", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CountryLeague_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CountryLeague_SeasonId",
                table: "CountryLeague",
                column: "SeasonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountryLeague");

            migrationBuilder.CreateTable(
                name: "League",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClubName = table.Column<string>(nullable: true),
                    Draws = table.Column<int>(nullable: false),
                    Loses = table.Column<int>(nullable: false),
                    MatchesAmount = table.Column<int>(nullable: false),
                    Place = table.Column<int>(nullable: false),
                    Points = table.Column<int>(nullable: false),
                    SeasonId = table.Column<int>(nullable: false),
                    Wins = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_League", x => x.Id);
                    table.ForeignKey(
                        name: "FK_League_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_League_SeasonId",
                table: "League",
                column: "SeasonId");
        }
    }
}
