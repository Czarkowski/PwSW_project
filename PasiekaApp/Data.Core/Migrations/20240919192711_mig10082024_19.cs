using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Core.Migrations
{
    /// <inheritdoc />
    public partial class mig10082024_19 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_ProductionTypes_ProductionTypeId",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_ProductionTypeId",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "ProductionTypeId",
                table: "Review");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "ProductionTypeId",
                table: "Review",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Review_ProductionTypeId",
                table: "Review",
                column: "ProductionTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_ProductionTypes_ProductionTypeId",
                table: "Review",
                column: "ProductionTypeId",
                principalTable: "ProductionTypes",
                principalColumn: "Id");
        }
    }
}
