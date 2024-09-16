using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Core.Migrations
{
    /// <inheritdoc />
    public partial class mig10082024_18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productions_ProductionType_ProductionTypeId",
                table: "Productions");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_ProductionType_ProductionTypeId",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductionType",
                table: "ProductionType");

            migrationBuilder.RenameTable(
                name: "ProductionType",
                newName: "ProductionTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductionTypes",
                table: "ProductionTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Productions_ProductionTypes_ProductionTypeId",
                table: "Productions",
                column: "ProductionTypeId",
                principalTable: "ProductionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_ProductionTypes_ProductionTypeId",
                table: "Review",
                column: "ProductionTypeId",
                principalTable: "ProductionTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productions_ProductionTypes_ProductionTypeId",
                table: "Productions");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_ProductionTypes_ProductionTypeId",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductionTypes",
                table: "ProductionTypes");

            migrationBuilder.RenameTable(
                name: "ProductionTypes",
                newName: "ProductionType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductionType",
                table: "ProductionType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Productions_ProductionType_ProductionTypeId",
                table: "Productions",
                column: "ProductionTypeId",
                principalTable: "ProductionType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_ProductionType_ProductionTypeId",
                table: "Review",
                column: "ProductionTypeId",
                principalTable: "ProductionType",
                principalColumn: "Id");
        }
    }
}
