using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Core.Migrations
{
    /// <inheritdoc />
    public partial class mig10082024_12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rasas",
                table: "Rasas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Opiss",
                table: "Opiss");

            migrationBuilder.RenameTable(
                name: "Rasas",
                newName: "Races");

            migrationBuilder.RenameTable(
                name: "Opiss",
                newName: "Descriptions");

            migrationBuilder.RenameColumn(
                name: "Nazwa",
                table: "StanMagazynowys",
                newName: "Unit");

            migrationBuilder.RenameColumn(
                name: "Jednostka",
                table: "StanMagazynowys",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Ilosc",
                table: "StanMagazynowys",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "UlId",
                table: "DescriptionHiveReview",
                newName: "ReviewId");

            migrationBuilder.RenameColumn(
                name: "PrzegladId",
                table: "DescriptionHiveReview",
                newName: "HiveId");

            migrationBuilder.RenameColumn(
                name: "OpisId",
                table: "DescriptionHiveReview",
                newName: "DescriptionId");

            migrationBuilder.RenameIndex(
                name: "IX_DescriptionHiveReview_UlId",
                table: "DescriptionHiveReview",
                newName: "IX_DescriptionHiveReview_ReviewId");

            migrationBuilder.RenameIndex(
                name: "IX_DescriptionHiveReview_PrzegladId",
                table: "DescriptionHiveReview",
                newName: "IX_DescriptionHiveReview_HiveId");

            migrationBuilder.RenameIndex(
                name: "IX_DescriptionHiveReview_OpisId",
                table: "DescriptionHiveReview",
                newName: "IX_DescriptionHiveReview_DescriptionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Races",
                table: "Races",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Descriptions",
                table: "Descriptions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BeeQueen_Races_RaceId",
                table: "BeeQueen",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DescriptionHiveReview_Descriptions_DescriptionId",
                table: "DescriptionHiveReview",
                column: "DescriptionId",
                principalTable: "Descriptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DescriptionHiveReview_Hive_HiveId",
                table: "DescriptionHiveReview",
                column: "HiveId",
                principalTable: "Hive",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DescriptionHiveReview_Review_ReviewId",
                table: "DescriptionHiveReview",
                column: "ReviewId",
                principalTable: "Review",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BeeQueen_Races_RaceId",
                table: "BeeQueen");

            migrationBuilder.DropForeignKey(
                name: "FK_DescriptionHiveReview_Descriptions_DescriptionId",
                table: "DescriptionHiveReview");

            migrationBuilder.DropForeignKey(
                name: "FK_DescriptionHiveReview_Hive_HiveId",
                table: "DescriptionHiveReview");

            migrationBuilder.DropForeignKey(
                name: "FK_DescriptionHiveReview_Review_ReviewId",
                table: "DescriptionHiveReview");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Races",
                table: "Races");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Descriptions",
                table: "Descriptions");

            migrationBuilder.RenameTable(
                name: "Races",
                newName: "Rasas");

            migrationBuilder.RenameTable(
                name: "Descriptions",
                newName: "Opiss");

            migrationBuilder.RenameColumn(
                name: "Unit",
                table: "StanMagazynowys",
                newName: "Nazwa");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "StanMagazynowys",
                newName: "Ilosc");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "StanMagazynowys",
                newName: "Jednostka");

            migrationBuilder.RenameColumn(
                name: "ReviewId",
                table: "DescriptionHiveReview",
                newName: "UlId");

            migrationBuilder.RenameColumn(
                name: "HiveId",
                table: "DescriptionHiveReview",
                newName: "PrzegladId");

            migrationBuilder.RenameColumn(
                name: "DescriptionId",
                table: "DescriptionHiveReview",
                newName: "OpisId");

            migrationBuilder.RenameIndex(
                name: "IX_DescriptionHiveReview_ReviewId",
                table: "DescriptionHiveReview",
                newName: "IX_DescriptionHiveReview_UlId");

            migrationBuilder.RenameIndex(
                name: "IX_DescriptionHiveReview_HiveId",
                table: "DescriptionHiveReview",
                newName: "IX_DescriptionHiveReview_PrzegladId");

            migrationBuilder.RenameIndex(
                name: "IX_DescriptionHiveReview_DescriptionId",
                table: "DescriptionHiveReview",
                newName: "IX_DescriptionHiveReview_OpisId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rasas",
                table: "Rasas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Opiss",
                table: "Opiss",
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
        }
    }
}
