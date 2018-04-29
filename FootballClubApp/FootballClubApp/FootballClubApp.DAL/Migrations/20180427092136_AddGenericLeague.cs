using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FootballClubApp.DAL.Migrations
{
    public partial class AddGenericLeague : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EuropeLeague");

            migrationBuilder.RenameColumn(
                name: "Wins",
                table: "League",
                newName: "EuropeLeague_Wins");

            migrationBuilder.RenameColumn(
                name: "Points",
                table: "League",
                newName: "EuropeLeague_Points");

            migrationBuilder.RenameColumn(
                name: "Place",
                table: "League",
                newName: "EuropeLeague_Place");

            migrationBuilder.RenameColumn(
                name: "MatchesAmount",
                table: "League",
                newName: "EuropeLeague_MatchesAmount");

            migrationBuilder.RenameColumn(
                name: "Loses",
                table: "League",
                newName: "EuropeLeague_Loses");

            migrationBuilder.RenameColumn(
                name: "Draws",
                table: "League",
                newName: "EuropeLeague_Draws");

            migrationBuilder.RenameColumn(
                name: "ClubName",
                table: "League",
                newName: "EuropeLeague_ClubName");

            migrationBuilder.AlterColumn<int>(
                name: "EuropeLeague_Wins",
                table: "League",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EuropeLeague_Points",
                table: "League",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EuropeLeague_Place",
                table: "League",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EuropeLeague_MatchesAmount",
                table: "League",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EuropeLeague_Loses",
                table: "League",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EuropeLeague_Draws",
                table: "League",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "ClubName",
                table: "League",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Draws",
                table: "League",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Loses",
                table: "League",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MatchesAmount",
                table: "League",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Place",
                table: "League",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "League",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Wins",
                table: "League",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameOfCompetition",
                table: "League",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeasonsId",
                table: "League",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "League",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_League_SeasonsId",
                table: "League",
                column: "SeasonsId");

            migrationBuilder.AddForeignKey(
                name: "FK_League_Seasons_SeasonsId",
                table: "League",
                column: "SeasonsId",
                principalTable: "Seasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_League_Seasons_SeasonsId",
                table: "League");

            migrationBuilder.DropIndex(
                name: "IX_League_SeasonsId",
                table: "League");

            migrationBuilder.DropColumn(
                name: "ClubName",
                table: "League");

            migrationBuilder.DropColumn(
                name: "Draws",
                table: "League");

            migrationBuilder.DropColumn(
                name: "Loses",
                table: "League");

            migrationBuilder.DropColumn(
                name: "MatchesAmount",
                table: "League");

            migrationBuilder.DropColumn(
                name: "Place",
                table: "League");

            migrationBuilder.DropColumn(
                name: "Points",
                table: "League");

            migrationBuilder.DropColumn(
                name: "Wins",
                table: "League");

            migrationBuilder.DropColumn(
                name: "NameOfCompetition",
                table: "League");

            migrationBuilder.DropColumn(
                name: "SeasonsId",
                table: "League");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "League");

            migrationBuilder.RenameColumn(
                name: "EuropeLeague_Wins",
                table: "League",
                newName: "Wins");

            migrationBuilder.RenameColumn(
                name: "EuropeLeague_Points",
                table: "League",
                newName: "Points");

            migrationBuilder.RenameColumn(
                name: "EuropeLeague_Place",
                table: "League",
                newName: "Place");

            migrationBuilder.RenameColumn(
                name: "EuropeLeague_MatchesAmount",
                table: "League",
                newName: "MatchesAmount");

            migrationBuilder.RenameColumn(
                name: "EuropeLeague_Loses",
                table: "League",
                newName: "Loses");

            migrationBuilder.RenameColumn(
                name: "EuropeLeague_Draws",
                table: "League",
                newName: "Draws");

            migrationBuilder.RenameColumn(
                name: "EuropeLeague_ClubName",
                table: "League",
                newName: "ClubName");

            migrationBuilder.AlterColumn<int>(
                name: "Wins",
                table: "League",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Points",
                table: "League",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Place",
                table: "League",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MatchesAmount",
                table: "League",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Loses",
                table: "League",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Draws",
                table: "League",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_EuropeLeague_SeasonId",
                table: "EuropeLeague",
                column: "SeasonId");
        }
    }
}
