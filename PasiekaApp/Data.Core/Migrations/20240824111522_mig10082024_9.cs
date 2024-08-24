using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Core.Migrations
{
    /// <inheritdoc />
    public partial class mig10082024_9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatkaPszczela_Rasas_RasaId",
                table: "MatkaPszczela");

            migrationBuilder.DropForeignKey(
                name: "FK_OpisUlPrzeglad_Przeglad_PrzegladId",
                table: "OpisUlPrzeglad");

            migrationBuilder.DropForeignKey(
                name: "FK_Ul_MatkaPszczela_MatkaPszczelaId",
                table: "Ul");

            migrationBuilder.DropTable(
                name: "Przeglad");

            migrationBuilder.RenameColumn(
                name: "Opis",
                table: "Ul",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Numer",
                table: "Ul",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "MatkaPszczelaId",
                table: "Ul",
                newName: "BeeQueenId");

            migrationBuilder.RenameColumn(
                name: "DataPoddaniaMatki",
                table: "Ul",
                newName: "AddBeeQueenDate");

            migrationBuilder.RenameColumn(
                name: "CzyOdklad",
                table: "Ul",
                newName: "IsNucleus");

            migrationBuilder.RenameIndex(
                name: "IX_Ul_MatkaPszczelaId",
                table: "Ul",
                newName: "IX_Ul_BeeQueenId");

            migrationBuilder.RenameColumn(
                name: "Tresc",
                table: "Opiss",
                newName: "Text");

            migrationBuilder.RenameColumn(
                name: "RasaId",
                table: "MatkaPszczela",
                newName: "RaceId");

            migrationBuilder.RenameColumn(
                name: "Opis",
                table: "MatkaPszczela",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "DataUrodzenia",
                table: "MatkaPszczela",
                newName: "BirthDate");

            migrationBuilder.RenameIndex(
                name: "IX_MatkaPszczela_RasaId",
                table: "MatkaPszczela",
                newName: "IX_MatkaPszczela_RaceId");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeathDate",
                table: "MatkaPszczela",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    PlannedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RealizedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ReviewTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_ReviewTypes_ReviewTypeId",
                        column: x => x.ReviewTypeId,
                        principalTable: "ReviewTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Review_ReviewTypeId",
                table: "Review",
                column: "ReviewTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MatkaPszczela_Rasas_RaceId",
                table: "MatkaPszczela",
                column: "RaceId",
                principalTable: "Rasas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OpisUlPrzeglad_Review_PrzegladId",
                table: "OpisUlPrzeglad",
                column: "PrzegladId",
                principalTable: "Review",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ul_MatkaPszczela_BeeQueenId",
                table: "Ul",
                column: "BeeQueenId",
                principalTable: "MatkaPszczela",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatkaPszczela_Rasas_RaceId",
                table: "MatkaPszczela");

            migrationBuilder.DropForeignKey(
                name: "FK_OpisUlPrzeglad_Review_PrzegladId",
                table: "OpisUlPrzeglad");

            migrationBuilder.DropForeignKey(
                name: "FK_Ul_MatkaPszczela_BeeQueenId",
                table: "Ul");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropColumn(
                name: "DeathDate",
                table: "MatkaPszczela");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Ul",
                newName: "Numer");

            migrationBuilder.RenameColumn(
                name: "IsNucleus",
                table: "Ul",
                newName: "CzyOdklad");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Ul",
                newName: "Opis");

            migrationBuilder.RenameColumn(
                name: "BeeQueenId",
                table: "Ul",
                newName: "MatkaPszczelaId");

            migrationBuilder.RenameColumn(
                name: "AddBeeQueenDate",
                table: "Ul",
                newName: "DataPoddaniaMatki");

            migrationBuilder.RenameIndex(
                name: "IX_Ul_BeeQueenId",
                table: "Ul",
                newName: "IX_Ul_MatkaPszczelaId");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Opiss",
                newName: "Tresc");

            migrationBuilder.RenameColumn(
                name: "RaceId",
                table: "MatkaPszczela",
                newName: "RasaId");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "MatkaPszczela",
                newName: "Opis");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "MatkaPszczela",
                newName: "DataUrodzenia");

            migrationBuilder.RenameIndex(
                name: "IX_MatkaPszczela_RaceId",
                table: "MatkaPszczela",
                newName: "IX_MatkaPszczela_RasaId");

            migrationBuilder.CreateTable(
                name: "Przeglad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ReviewTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    PlannedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RealizedDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Przeglad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Przeglad_ReviewTypes_ReviewTypeId",
                        column: x => x.ReviewTypeId,
                        principalTable: "ReviewTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Przeglad_ReviewTypeId",
                table: "Przeglad",
                column: "ReviewTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MatkaPszczela_Rasas_RasaId",
                table: "MatkaPszczela",
                column: "RasaId",
                principalTable: "Rasas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OpisUlPrzeglad_Przeglad_PrzegladId",
                table: "OpisUlPrzeglad",
                column: "PrzegladId",
                principalTable: "Przeglad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ul_MatkaPszczela_MatkaPszczelaId",
                table: "Ul",
                column: "MatkaPszczelaId",
                principalTable: "MatkaPszczela",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
