using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Core.Migrations
{
    /// <inheritdoc />
    public partial class mig10082024_10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatkaPszczela_Rasas_RaceId",
                table: "MatkaPszczela");

            migrationBuilder.DropForeignKey(
                name: "FK_OpisUlPrzeglad_Opiss_OpisId",
                table: "OpisUlPrzeglad");

            migrationBuilder.DropForeignKey(
                name: "FK_OpisUlPrzeglad_Review_PrzegladId",
                table: "OpisUlPrzeglad");

            migrationBuilder.DropForeignKey(
                name: "FK_OpisUlPrzeglad_Ul_UlId",
                table: "OpisUlPrzeglad");

            migrationBuilder.DropForeignKey(
                name: "FK_Ul_MatkaPszczela_BeeQueenId",
                table: "Ul");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ul",
                table: "Ul");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OpisUlPrzeglad",
                table: "OpisUlPrzeglad");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MatkaPszczela",
                table: "MatkaPszczela");

            migrationBuilder.RenameTable(
                name: "Ul",
                newName: "Hive");

            migrationBuilder.RenameTable(
                name: "OpisUlPrzeglad",
                newName: "DescriptionHiveReview");

            migrationBuilder.RenameTable(
                name: "MatkaPszczela",
                newName: "BeeQueen");

            migrationBuilder.RenameIndex(
                name: "IX_Ul_BeeQueenId",
                table: "Hive",
                newName: "IX_Hive_BeeQueenId");

            migrationBuilder.RenameIndex(
                name: "IX_OpisUlPrzeglad_UlId",
                table: "DescriptionHiveReview",
                newName: "IX_DescriptionHiveReview_UlId");

            migrationBuilder.RenameIndex(
                name: "IX_OpisUlPrzeglad_PrzegladId",
                table: "DescriptionHiveReview",
                newName: "IX_DescriptionHiveReview_PrzegladId");

            migrationBuilder.RenameIndex(
                name: "IX_OpisUlPrzeglad_OpisId",
                table: "DescriptionHiveReview",
                newName: "IX_DescriptionHiveReview_OpisId");

            migrationBuilder.RenameIndex(
                name: "IX_MatkaPszczela_RaceId",
                table: "BeeQueen",
                newName: "IX_BeeQueen_RaceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hive",
                table: "Hive",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DescriptionHiveReview",
                table: "DescriptionHiveReview",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BeeQueen",
                table: "BeeQueen",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BeeQueen_Rasas_RaceId",
                table: "BeeQueen",
                column: "RaceId",
                principalTable: "Rasas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DescriptionHiveReview_Hive_UlId",
                table: "DescriptionHiveReview",
                column: "UlId",
                principalTable: "Hive",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DescriptionHiveReview_Opiss_OpisId",
                table: "DescriptionHiveReview",
                column: "OpisId",
                principalTable: "Opiss",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DescriptionHiveReview_Review_PrzegladId",
                table: "DescriptionHiveReview",
                column: "PrzegladId",
                principalTable: "Review",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hive_BeeQueen_BeeQueenId",
                table: "Hive",
                column: "BeeQueenId",
                principalTable: "BeeQueen",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BeeQueen_Rasas_RaceId",
                table: "BeeQueen");

            migrationBuilder.DropForeignKey(
                name: "FK_DescriptionHiveReview_Hive_UlId",
                table: "DescriptionHiveReview");

            migrationBuilder.DropForeignKey(
                name: "FK_DescriptionHiveReview_Opiss_OpisId",
                table: "DescriptionHiveReview");

            migrationBuilder.DropForeignKey(
                name: "FK_DescriptionHiveReview_Review_PrzegladId",
                table: "DescriptionHiveReview");

            migrationBuilder.DropForeignKey(
                name: "FK_Hive_BeeQueen_BeeQueenId",
                table: "Hive");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hive",
                table: "Hive");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DescriptionHiveReview",
                table: "DescriptionHiveReview");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BeeQueen",
                table: "BeeQueen");

            migrationBuilder.RenameTable(
                name: "Hive",
                newName: "Ul");

            migrationBuilder.RenameTable(
                name: "DescriptionHiveReview",
                newName: "OpisUlPrzeglad");

            migrationBuilder.RenameTable(
                name: "BeeQueen",
                newName: "MatkaPszczela");

            migrationBuilder.RenameIndex(
                name: "IX_Hive_BeeQueenId",
                table: "Ul",
                newName: "IX_Ul_BeeQueenId");

            migrationBuilder.RenameIndex(
                name: "IX_DescriptionHiveReview_UlId",
                table: "OpisUlPrzeglad",
                newName: "IX_OpisUlPrzeglad_UlId");

            migrationBuilder.RenameIndex(
                name: "IX_DescriptionHiveReview_PrzegladId",
                table: "OpisUlPrzeglad",
                newName: "IX_OpisUlPrzeglad_PrzegladId");

            migrationBuilder.RenameIndex(
                name: "IX_DescriptionHiveReview_OpisId",
                table: "OpisUlPrzeglad",
                newName: "IX_OpisUlPrzeglad_OpisId");

            migrationBuilder.RenameIndex(
                name: "IX_BeeQueen_RaceId",
                table: "MatkaPszczela",
                newName: "IX_MatkaPszczela_RaceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ul",
                table: "Ul",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OpisUlPrzeglad",
                table: "OpisUlPrzeglad",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MatkaPszczela",
                table: "MatkaPszczela",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MatkaPszczela_Rasas_RaceId",
                table: "MatkaPszczela",
                column: "RaceId",
                principalTable: "Rasas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OpisUlPrzeglad_Opiss_OpisId",
                table: "OpisUlPrzeglad",
                column: "OpisId",
                principalTable: "Opiss",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OpisUlPrzeglad_Review_PrzegladId",
                table: "OpisUlPrzeglad",
                column: "PrzegladId",
                principalTable: "Review",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OpisUlPrzeglad_Ul_UlId",
                table: "OpisUlPrzeglad",
                column: "UlId",
                principalTable: "Ul",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ul_MatkaPszczela_BeeQueenId",
                table: "Ul",
                column: "BeeQueenId",
                principalTable: "MatkaPszczela",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
