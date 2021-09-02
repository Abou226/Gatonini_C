using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class MiseAJourTableauxskl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GateauBase_Filiale_FilialeId",
                table: "GateauBase");

            migrationBuilder.DropForeignKey(
                name: "FK_GateauBase_Produit_ProduitId",
                table: "GateauBase");

            migrationBuilder.DropForeignKey(
                name: "FK_GateauFini_Filiale_FilialeId",
                table: "GateauFini");

            migrationBuilder.DropForeignKey(
                name: "FK_GateauFini_Produit_ProduitId",
                table: "GateauFini");

            migrationBuilder.DropIndex(
                name: "IX_GateauFini_FilialeId",
                table: "GateauFini");

            migrationBuilder.DropIndex(
                name: "IX_GateauBase_FilialeId",
                table: "GateauBase");

            migrationBuilder.DropColumn(
                name: "FilialeId",
                table: "GateauFini");

            migrationBuilder.DropColumn(
                name: "FilialeId",
                table: "GateauBase");

            //migrationBuilder.DropColumn(
            //    name: "UserId",
            //    table: "Categorie");

            migrationBuilder.RenameColumn(
                name: "ProduitId",
                table: "GateauFini",
                newName: "StockId");

            migrationBuilder.RenameIndex(
                name: "IX_GateauFini_ProduitId",
                table: "GateauFini",
                newName: "IX_GateauFini_StockId");

            migrationBuilder.RenameColumn(
                name: "ProduitId",
                table: "GateauBase",
                newName: "StockId");

            migrationBuilder.RenameIndex(
                name: "IX_GateauBase_ProduitId",
                table: "GateauBase",
                newName: "IX_GateauBase_StockId");

            //migrationBuilder.AlterColumn<Guid>(
            //    name: "UserId",
            //    table: "Taille",
            //    type: "uniqueidentifier",
            //    nullable: true,
            //    oldClrType: typeof(int),
            //    oldType: "int",
            //    oldNullable: true);

            //migrationBuilder.AddColumn<Guid>(
            //    name: "FilialeId",
            //    table: "Stock_Produit",
            //    type: "uniqueidentifier",
            //    nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Produit",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "Client",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Contact1",
                table: "Client",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UsageIngredient",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IngredientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsageIngredient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsageIngredient_Ingredient_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Stock_Produit_FilialeId",
            //    table: "Stock_Produit",
            //    column: "FilialeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Panier_ProduitId",
            //    table: "Panier",
            //    column: "ProduitId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Commande_ProduitId",
            //    table: "Commande",
            //    column: "ProduitId");

            migrationBuilder.CreateIndex(
                name: "IX_UsageIngredient_IngredientId",
                table: "UsageIngredient",
                column: "IngredientId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Commande_Produit_ProduitId",
            //    table: "Commande",
            //    column: "ProduitId",
            //    principalTable: "Produit",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GateauBase_Stock_Base_StockId",
                table: "GateauBase",
                column: "StockId",
                principalTable: "Stock_Base",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GateauFini_Stock_Produit_StockId",
                table: "GateauFini",
                column: "StockId",
                principalTable: "Stock_Produit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Panier_Produit_ProduitId",
            //    table: "Panier",
            //    column: "ProduitId",
            //    principalTable: "Produit",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Stock_Produit_Filiale_FilialeId",
            //    table: "Stock_Produit",
            //    column: "FilialeId",
            //    principalTable: "Filiale",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commande_Produit_ProduitId",
                table: "Commande");

            migrationBuilder.DropForeignKey(
                name: "FK_GateauBase_Stock_Base_StockId",
                table: "GateauBase");

            migrationBuilder.DropForeignKey(
                name: "FK_GateauFini_Stock_Produit_StockId",
                table: "GateauFini");

            migrationBuilder.DropForeignKey(
                name: "FK_Panier_Produit_ProduitId",
                table: "Panier");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Produit_Filiale_FilialeId",
                table: "Stock_Produit");

            migrationBuilder.DropTable(
                name: "UsageIngredient");

            migrationBuilder.DropIndex(
                name: "IX_Stock_Produit_FilialeId",
                table: "Stock_Produit");

            migrationBuilder.DropIndex(
                name: "IX_Panier_ProduitId",
                table: "Panier");

            migrationBuilder.DropIndex(
                name: "IX_Commande_ProduitId",
                table: "Commande");

            migrationBuilder.DropColumn(
                name: "FilialeId",
                table: "Stock_Produit");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Produit");

            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "Contact1",
                table: "Client");

            migrationBuilder.RenameColumn(
                name: "StockId",
                table: "GateauFini",
                newName: "ProduitId");

            migrationBuilder.RenameIndex(
                name: "IX_GateauFini_StockId",
                table: "GateauFini",
                newName: "IX_GateauFini_ProduitId");

            migrationBuilder.RenameColumn(
                name: "StockId",
                table: "GateauBase",
                newName: "ProduitId");

            migrationBuilder.RenameIndex(
                name: "IX_GateauBase_StockId",
                table: "GateauBase",
                newName: "IX_GateauBase_ProduitId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Taille",
                type: "int",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FilialeId",
                table: "GateauFini",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FilialeId",
                table: "GateauBase",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Categorie",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GateauFini_FilialeId",
                table: "GateauFini",
                column: "FilialeId");

            migrationBuilder.CreateIndex(
                name: "IX_GateauBase_FilialeId",
                table: "GateauBase",
                column: "FilialeId");

            migrationBuilder.AddForeignKey(
                name: "FK_GateauBase_Filiale_FilialeId",
                table: "GateauBase",
                column: "FilialeId",
                principalTable: "Filiale",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GateauBase_Produit_ProduitId",
                table: "GateauBase",
                column: "ProduitId",
                principalTable: "Produit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GateauFini_Filiale_FilialeId",
                table: "GateauFini",
                column: "FilialeId",
                principalTable: "Filiale",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GateauFini_Produit_ProduitId",
                table: "GateauFini",
                column: "ProduitId",
                principalTable: "Produit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
