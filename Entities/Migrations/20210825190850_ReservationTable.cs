using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class ReservationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Gamme_Categories_CategorieId",
            //    table: "Gamme");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Categories",
            //    table: "Categories");

            //migrationBuilder.RenameTable(
            //    name: "Categories",
            //    newName: "Categorie");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Categorie",
            //    table: "Categorie",
            //    column: "CategorieId");

            //migrationBuilder.CreateTable(
            //    name: "Reservation",
            //    columns: table => new
            //    {
            //        Reference = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        TransId = table.Column<int>(type: "int", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        Gateau = table.Column<string>(type: "varchar(50)", nullable: true),
            //        Description = table.Column<string>(type: "varchar(400)", nullable: true),
            //        Image = table.Column<byte>(type: "tinyint", nullable: true),
            //        Nombre = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        Part = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        Montant = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        Client = table.Column<string>(type: "Varchar(75)", nullable: true),
            //        NumClient = table.Column<string>(type: "Varchar(50)", nullable: true),
            //        Num2Client = table.Column<string>(type: "Varchar(50)", nullable: true),
            //        GenreClient = table.Column<string>(type: "Varchar(50)", nullable: true),
            //        GateauPour = table.Column<string>(type: "Varchar(50)", nullable: true),
            //        DateLivraison = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        AdresseLivraison = table.Column<string>(type: "Varchar(50)", nullable: true),
            //        HeureLivraison = table.Column<string>(type: "Varchar(10)", nullable: true),
            //        MentionSurGateau = table.Column<string>(type: "Varchar(100)", nullable: true),
            //        Auteur = table.Column<string>(type: "Varchar(50)", nullable: true),
            //        Payée = table.Column<string>(type: "Varchar(5)", nullable: true),
            //        DeptAuteur = table.Column<string>(type: "Varchar(50)", nullable: true),
            //        GammeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Reservation", x => x.Reference);
            //        table.ForeignKey(
            //            name: "FK_Reservation_Gamme_GammeId",
            //            column: x => x.GammeId,
            //            principalTable: "Gamme",
            //            principalColumn: "GammeId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Reservation_GammeId",
            //    table: "Reservation",
            //    column: "GammeId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Gamme_Categorie_CategorieId",
            //    table: "Gamme",
            //    column: "CategorieId",
            //    principalTable: "Categorie",
            //    principalColumn: "CategorieId",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gamme_Categorie_CategorieId",
                table: "Gamme");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorie",
                table: "Categorie");

            migrationBuilder.RenameTable(
                name: "Categorie",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategorieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gamme_Categories_CategorieId",
                table: "Gamme",
                column: "CategorieId",
                principalTable: "Categories",
                principalColumn: "CategorieId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
