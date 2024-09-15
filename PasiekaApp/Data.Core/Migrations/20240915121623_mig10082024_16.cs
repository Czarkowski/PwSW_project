using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Core.Migrations
{
    /// <inheritdoc />
    public partial class mig10082024_16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ReviewTypes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ReviewTypes");
        }
    }
}
