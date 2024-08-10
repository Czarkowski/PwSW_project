using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Core.Migrations
{
    /// <inheritdoc />
    public partial class mig10082024 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OpisUlPrzeglads_Opiss_OpisId",
                table: "OpisUlPrzeglads");

            migrationBuilder.DropForeignKey(
                name: "FK_OpisUlPrzeglads_Przeglads_PrzegladId",
                table: "OpisUlPrzeglads");

            migrationBuilder.DropForeignKey(
                name: "FK_OpisUlPrzeglads_Ul_UlId",
                table: "OpisUlPrzeglads");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OpisUlPrzeglads",
                table: "OpisUlPrzeglads");

            migrationBuilder.RenameTable(
                name: "OpisUlPrzeglads",
                newName: "OpisUlPrzeglad");

            migrationBuilder.RenameIndex(
                name: "IX_OpisUlPrzeglads_PrzegladId",
                table: "OpisUlPrzeglad",
                newName: "IX_OpisUlPrzeglad_PrzegladId");

            migrationBuilder.RenameIndex(
                name: "IX_OpisUlPrzeglads_OpisId",
                table: "OpisUlPrzeglad",
                newName: "IX_OpisUlPrzeglad_OpisId");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataPoddaniaMatki",
                table: "Ul",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OpisUlPrzeglad",
                table: "OpisUlPrzeglad",
                columns: new[] { "UlId", "PrzegladId" });

            migrationBuilder.AddForeignKey(
                name: "FK_OpisUlPrzeglad_Opiss_OpisId",
                table: "OpisUlPrzeglad",
                column: "OpisId",
                principalTable: "Opiss",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OpisUlPrzeglad_Przeglads_PrzegladId",
                table: "OpisUlPrzeglad",
                column: "PrzegladId",
                principalTable: "Przeglads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OpisUlPrzeglad_Ul_UlId",
                table: "OpisUlPrzeglad",
                column: "UlId",
                principalTable: "Ul",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OpisUlPrzeglad_Opiss_OpisId",
                table: "OpisUlPrzeglad");

            migrationBuilder.DropForeignKey(
                name: "FK_OpisUlPrzeglad_Przeglads_PrzegladId",
                table: "OpisUlPrzeglad");

            migrationBuilder.DropForeignKey(
                name: "FK_OpisUlPrzeglad_Ul_UlId",
                table: "OpisUlPrzeglad");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OpisUlPrzeglad",
                table: "OpisUlPrzeglad");

            migrationBuilder.DropColumn(
                name: "DataPoddaniaMatki",
                table: "Ul");

            migrationBuilder.RenameTable(
                name: "OpisUlPrzeglad",
                newName: "OpisUlPrzeglads");

            migrationBuilder.RenameIndex(
                name: "IX_OpisUlPrzeglad_PrzegladId",
                table: "OpisUlPrzeglads",
                newName: "IX_OpisUlPrzeglads_PrzegladId");

            migrationBuilder.RenameIndex(
                name: "IX_OpisUlPrzeglad_OpisId",
                table: "OpisUlPrzeglads",
                newName: "IX_OpisUlPrzeglads_OpisId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OpisUlPrzeglads",
                table: "OpisUlPrzeglads",
                columns: new[] { "UlId", "PrzegladId" });

            migrationBuilder.AddForeignKey(
                name: "FK_OpisUlPrzeglads_Opiss_OpisId",
                table: "OpisUlPrzeglads",
                column: "OpisId",
                principalTable: "Opiss",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OpisUlPrzeglads_Przeglads_PrzegladId",
                table: "OpisUlPrzeglads",
                column: "PrzegladId",
                principalTable: "Przeglads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OpisUlPrzeglads_Ul_UlId",
                table: "OpisUlPrzeglads",
                column: "UlId",
                principalTable: "Ul",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
