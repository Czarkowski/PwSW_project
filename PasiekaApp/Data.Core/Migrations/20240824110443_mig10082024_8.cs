using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Core.Migrations
{
    /// <inheritdoc />
    public partial class mig10082024_8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OpisUlPrzeglad_Przeglads_PrzegladId",
                table: "OpisUlPrzeglad");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Przeglads",
                table: "Przeglads");

            migrationBuilder.RenameTable(
                name: "Przeglads",
                newName: "Przeglad");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Przeglad",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "PlannedDate",
                table: "Przeglad",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "RealizedDate",
                table: "Przeglad",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReviewTypeId",
                table: "Przeglad",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Przeglad",
                table: "Przeglad",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ReviewTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Przeglad_ReviewTypeId",
                table: "Przeglad",
                column: "ReviewTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_OpisUlPrzeglad_Przeglad_PrzegladId",
                table: "OpisUlPrzeglad",
                column: "PrzegladId",
                principalTable: "Przeglad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Przeglad_ReviewTypes_ReviewTypeId",
                table: "Przeglad",
                column: "ReviewTypeId",
                principalTable: "ReviewTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OpisUlPrzeglad_Przeglad_PrzegladId",
                table: "OpisUlPrzeglad");

            migrationBuilder.DropForeignKey(
                name: "FK_Przeglad_ReviewTypes_ReviewTypeId",
                table: "Przeglad");

            migrationBuilder.DropTable(
                name: "ReviewTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Przeglad",
                table: "Przeglad");

            migrationBuilder.DropIndex(
                name: "IX_Przeglad_ReviewTypeId",
                table: "Przeglad");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Przeglad");

            migrationBuilder.DropColumn(
                name: "PlannedDate",
                table: "Przeglad");

            migrationBuilder.DropColumn(
                name: "RealizedDate",
                table: "Przeglad");

            migrationBuilder.DropColumn(
                name: "ReviewTypeId",
                table: "Przeglad");

            migrationBuilder.RenameTable(
                name: "Przeglad",
                newName: "Przeglads");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Przeglads",
                table: "Przeglads",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OpisUlPrzeglad_Przeglads_PrzegladId",
                table: "OpisUlPrzeglad",
                column: "PrzegladId",
                principalTable: "Przeglads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
