using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Core.Migrations
{
    /// <inheritdoc />
    public partial class mig10082024_22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductionTypes_ProductionTypes_ProductionTypeId",
                table: "ProductionTypes");

            migrationBuilder.DropIndex(
                name: "IX_ProductionTypes_ProductionTypeId",
                table: "ProductionTypes");

            migrationBuilder.DropColumn(
                name: "ProductionTypeId",
                table: "ProductionTypes");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Productions",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Unit",
                table: "Productions",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Value",
                table: "Productions",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Productions");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Productions");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Productions");

            migrationBuilder.AddColumn<int>(
                name: "ProductionTypeId",
                table: "ProductionTypes",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductionTypes_ProductionTypeId",
                table: "ProductionTypes",
                column: "ProductionTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionTypes_ProductionTypes_ProductionTypeId",
                table: "ProductionTypes",
                column: "ProductionTypeId",
                principalTable: "ProductionTypes",
                principalColumn: "Id");
        }
    }
}
