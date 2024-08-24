using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Core.Migrations
{
    /// <inheritdoc />
    public partial class mig10082024_11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Opis",
                table: "Rasas",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Nazwa",
                table: "Rasas",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Rasas",
                newName: "Nazwa");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Rasas",
                newName: "Opis");
        }
    }
}
