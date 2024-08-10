using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Core.Migrations
{
    /// <inheritdoc />
    public partial class mig10082024_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OpisUlPrzeglad",
                table: "OpisUlPrzeglad");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "OpisUlPrzeglad",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OpisUlPrzeglad",
                table: "OpisUlPrzeglad",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_OpisUlPrzeglad_UlId",
                table: "OpisUlPrzeglad",
                column: "UlId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OpisUlPrzeglad",
                table: "OpisUlPrzeglad");

            migrationBuilder.DropIndex(
                name: "IX_OpisUlPrzeglad_UlId",
                table: "OpisUlPrzeglad");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "OpisUlPrzeglad",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OpisUlPrzeglad",
                table: "OpisUlPrzeglad",
                columns: new[] { "UlId", "PrzegladId" });
        }
    }
}
