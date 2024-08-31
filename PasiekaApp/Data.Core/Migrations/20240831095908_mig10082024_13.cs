using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Core.Migrations
{
    /// <inheritdoc />
    public partial class mig10082024_13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StanMagazynowys",
                table: "StanMagazynowys");

            migrationBuilder.RenameTable(
                name: "StanMagazynowys",
                newName: "StockAvailabilities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockAvailabilities",
                table: "StockAvailabilities",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StockAvailabilities",
                table: "StockAvailabilities");

            migrationBuilder.RenameTable(
                name: "StockAvailabilities",
                newName: "StanMagazynowys");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StanMagazynowys",
                table: "StanMagazynowys",
                column: "Id");
        }
    }
}
