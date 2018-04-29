using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FootballClubApp.DAL.Migrations
{
    public partial class AddSeasons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Season = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coaches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    SeasonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coaches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coaches_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EuropeEliminations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AwayResult = table.Column<string>(nullable: true),
                    HomeResult = table.Column<string>(nullable: true),
                    NameOfCompetition = table.Column<string>(nullable: true),
                    NameOfStage = table.Column<string>(nullable: true),
                    Round = table.Column<int>(nullable: false),
                    SeasonId = table.Column<int>(nullable: false),
                    Team = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EuropeEliminations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EuropeEliminations_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EuropeLeague",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClubName = table.Column<string>(nullable: true),
                    Draws = table.Column<int>(nullable: false),
                    Loses = table.Column<int>(nullable: false),
                    MatchesAmount = table.Column<int>(nullable: false),
                    NameOfCompetition = table.Column<string>(nullable: true),
                    Place = table.Column<int>(nullable: false),
                    Points = table.Column<int>(nullable: false),
                    SeasonId = table.Column<int>(nullable: false),
                    Wins = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EuropeLeague", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EuropeLeague_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_Coaches_SeasonId",
                table: "Coaches",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_EuropeEliminations_SeasonId",
                table: "EuropeEliminations",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_EuropeLeague_SeasonId",
                table: "EuropeLeague",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_League_SeasonId",
                table: "League",
                column: "SeasonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coaches");

            migrationBuilder.DropTable(
                name: "EuropeEliminations");

            migrationBuilder.DropTable(
                name: "EuropeLeague");

            migrationBuilder.DropTable(
                name: "League");

            migrationBuilder.DropTable(
                name: "Seasons");
        }
    }
}
