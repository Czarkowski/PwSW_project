using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Core.Migrations
{
    /// <inheritdoc />
    public partial class mig10082024_17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductionTypeId",
                table: "Review",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Races",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ProductionType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    IsVisible = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductionTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productions_ProductionType_ProductionTypeId",
                        column: x => x.ProductionTypeId,
                        principalTable: "ProductionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductionHives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductionId = table.Column<int>(type: "INTEGER", nullable: false),
                    HiveId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionHives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionHives_Hive_HiveId",
                        column: x => x.HiveId,
                        principalTable: "Hive",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionHives_Productions_ProductionId",
                        column: x => x.ProductionId,
                        principalTable: "Productions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Review_ProductionTypeId",
                table: "Review",
                column: "ProductionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionHives_HiveId",
                table: "ProductionHives",
                column: "HiveId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionHives_ProductionId",
                table: "ProductionHives",
                column: "ProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_Productions_ProductionTypeId",
                table: "Productions",
                column: "ProductionTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_ProductionType_ProductionTypeId",
                table: "Review",
                column: "ProductionTypeId",
                principalTable: "ProductionType",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_ProductionType_ProductionTypeId",
                table: "Review");

            migrationBuilder.DropTable(
                name: "ProductionHives");

            migrationBuilder.DropTable(
                name: "Productions");

            migrationBuilder.DropTable(
                name: "ProductionType");

            migrationBuilder.DropIndex(
                name: "IX_Review_ProductionTypeId",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "ProductionTypeId",
                table: "Review");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Races",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
