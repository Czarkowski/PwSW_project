using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Core.Migrations
{
    /// <inheritdoc />
    public partial class OneToManyRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Opiss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opiss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Przeglads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Przeglads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rasas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: false),
                    Opis = table.Column<string>(type: "TEXT", nullable: false),
                    Licznosc = table.Column<int>(type: "INTEGER", nullable: false),
                    Produktywnosc = table.Column<int>(type: "INTEGER", nullable: false),
                    Rojliwosc = table.Column<int>(type: "INTEGER", nullable: false),
                    Higienicznosc = table.Column<int>(type: "INTEGER", nullable: false),
                    Lagodnosc = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rasas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StanMagazynowys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: false),
                    Ilosc = table.Column<double>(type: "REAL", nullable: false),
                    Jednostka = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StanMagazynowys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MatkaPszczela",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RasaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatkaPszczela", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatkaPszczela_Rasas_RasaId",
                        column: x => x.RasaId,
                        principalTable: "Rasas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ul",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Numer = table.Column<int>(type: "INTEGER", nullable: false),
                    MatkaPszczelaId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ul", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ul_MatkaPszczela_MatkaPszczelaId",
                        column: x => x.MatkaPszczelaId,
                        principalTable: "MatkaPszczela",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "OpisUlPrzeglads",
                columns: table => new
                {
                    UlId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrzegladId = table.Column<int>(type: "INTEGER", nullable: false),
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    OpisId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpisUlPrzeglads", x => new { x.UlId, x.PrzegladId });
                    table.ForeignKey(
                        name: "FK_OpisUlPrzeglads_Opiss_OpisId",
                        column: x => x.OpisId,
                        principalTable: "Opiss",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OpisUlPrzeglads_Przeglads_PrzegladId",
                        column: x => x.PrzegladId,
                        principalTable: "Przeglads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OpisUlPrzeglads_Ul_UlId",
                        column: x => x.UlId,
                        principalTable: "Ul",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MatkaPszczela_RasaId",
                table: "MatkaPszczela",
                column: "RasaId");

            migrationBuilder.CreateIndex(
                name: "IX_OpisUlPrzeglads_OpisId",
                table: "OpisUlPrzeglads",
                column: "OpisId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OpisUlPrzeglads_PrzegladId",
                table: "OpisUlPrzeglads",
                column: "PrzegladId");

            migrationBuilder.CreateIndex(
                name: "IX_Ul_MatkaPszczelaId",
                table: "Ul",
                column: "MatkaPszczelaId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OpisUlPrzeglads");

            migrationBuilder.DropTable(
                name: "StanMagazynowys");

            migrationBuilder.DropTable(
                name: "Opiss");

            migrationBuilder.DropTable(
                name: "Przeglads");

            migrationBuilder.DropTable(
                name: "Ul");

            migrationBuilder.DropTable(
                name: "MatkaPszczela");

            migrationBuilder.DropTable(
                name: "Rasas");
        }
    }
}
