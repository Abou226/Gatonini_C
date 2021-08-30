using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class AddMoreTabless : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commande_Gamme_GammeId",
                table: "Commande");

            migrationBuilder.DropForeignKey(
                name: "FK_Commande_Model_ModelId",
                table: "Commande");

            migrationBuilder.DropForeignKey(
                name: "FK_Commande_Taille_TailleId",
                table: "Commande");

            migrationBuilder.DropForeignKey(
                name: "FK_Panier_Gamme_GammeId",
                table: "Panier");

            migrationBuilder.DropForeignKey(
                name: "FK_Panier_Model_ModelId",
                table: "Panier");

            migrationBuilder.DropForeignKey(
                name: "FK_Panier_Taille_TailleId",
                table: "Panier");

            migrationBuilder.DropIndex(
                name: "IX_Panier_GammeId",
                table: "Panier");

            migrationBuilder.DropIndex(
                name: "IX_Panier_ModelId",
                table: "Panier");

            migrationBuilder.DropIndex(
                name: "IX_Commande_GammeId",
                table: "Commande");

            migrationBuilder.DropIndex(
                name: "IX_Commande_ModelId",
                table: "Commande");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Continents",
                table: "Continents");

            migrationBuilder.DropColumn(
                name: "GammeId",
                table: "Panier");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "Panier");

            migrationBuilder.DropColumn(
                name: "GammeId",
                table: "Commande");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "Commande");

            migrationBuilder.RenameTable(
                name: "Continents",
                newName: "Continent");

            migrationBuilder.RenameColumn(
                name: "Pays",
                table: "Ville",
                newName: "PaysId");

            migrationBuilder.RenameColumn(
                name: "TailleId",
                table: "Panier",
                newName: "ProduitId");

            migrationBuilder.RenameIndex(
                name: "IX_Panier_TailleId",
                table: "Panier",
                newName: "IX_Panier_ProduitId");

            migrationBuilder.RenameColumn(
                name: "TailleId",
                table: "Commande",
                newName: "ProduitId");

            migrationBuilder.RenameIndex(
                name: "IX_Commande_TailleId",
                table: "Commande",
                newName: "IX_Commande_ProduitId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Continent",
                table: "Continent",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Filiale",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ZoneId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    QuartierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filiale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filiale_Quartier_QuartierId",
                        column: x => x.QuartierId,
                        principalTable: "Quartier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Filiale_Zone_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fournisseur",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Genre = table.Column<int>(type: "int", nullable: false),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fournisseur", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Unité = table.Column<int>(type: "int", nullable: false),
                    Quantité = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock_Min = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock_Max = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Montant = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Num_Operation = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Mode_Payement = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Nature = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatePayement = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GammeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TailleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produit_Gamme_GammeId",
                        column: x => x.GammeId,
                        principalTable: "Gamme",
                        principalColumn: "GammeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Produit_Model_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Model",
                        principalColumn: "ModelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Produit_Taille_TailleId",
                        column: x => x.TailleId,
                        principalTable: "Taille",
                        principalColumn: "TailleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AchatIngredient",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IngredientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FournisseurId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AchatIngredient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AchatIngredient_Fournisseur_FournisseurId",
                        column: x => x.FournisseurId,
                        principalTable: "Fournisseur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AchatIngredient_Ingredient_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usage_Ingredient",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IngredientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usage_Ingredient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usage_Ingredient_Ingredient_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GateauBase",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProduitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FilialeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Quantité = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GateauBase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GateauBase_Filiale_FilialeId",
                        column: x => x.FilialeId,
                        principalTable: "Filiale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GateauBase_Produit_ProduitId",
                        column: x => x.ProduitId,
                        principalTable: "Produit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GateauFini",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProduitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FilialeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Quantité = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GateauFini", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GateauFini_Filiale_FilialeId",
                        column: x => x.FilialeId,
                        principalTable: "Filiale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GateauFini_Produit_ProduitId",
                        column: x => x.ProduitId,
                        principalTable: "Produit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stock_Base",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProduitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FilialeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Quantité = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock_Base", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stock_Base_Filiale_FilialeId",
                        column: x => x.FilialeId,
                        principalTable: "Filiale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stock_Base_Produit_ProduitId",
                        column: x => x.ProduitId,
                        principalTable: "Produit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stock_Produit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProduitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FilialeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Quantité = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock_Produit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stock_Produit_Filiale_FilialeId",
                        column: x => x.FilialeId,
                        principalTable: "Filiale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stock_Produit_Produit_ProduitId",
                        column: x => x.ProduitId,
                        principalTable: "Produit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ville_PaysId",
                table: "Ville",
                column: "PaysId");

            migrationBuilder.CreateIndex(
                name: "IX_Quartier_CommuneId",
                table: "Quartier",
                column: "CommuneId");

            migrationBuilder.CreateIndex(
                name: "IX_Quartier_ZoneId",
                table: "Quartier",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Pays_ContinentId",
                table: "Pays",
                column: "ContinentId");

            migrationBuilder.CreateIndex(
                name: "IX_Commune_VilleId",
                table: "Commune",
                column: "VilleId");

            migrationBuilder.CreateIndex(
                name: "IX_AchatIngredient_FournisseurId",
                table: "AchatIngredient",
                column: "FournisseurId");

            migrationBuilder.CreateIndex(
                name: "IX_AchatIngredient_IngredientId",
                table: "AchatIngredient",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Filiale_QuartierId",
                table: "Filiale",
                column: "QuartierId");

            migrationBuilder.CreateIndex(
                name: "IX_Filiale_ZoneId",
                table: "Filiale",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_GateauBase_FilialeId",
                table: "GateauBase",
                column: "FilialeId");

            migrationBuilder.CreateIndex(
                name: "IX_GateauBase_ProduitId",
                table: "GateauBase",
                column: "ProduitId");

            migrationBuilder.CreateIndex(
                name: "IX_GateauFini_FilialeId",
                table: "GateauFini",
                column: "FilialeId");

            migrationBuilder.CreateIndex(
                name: "IX_GateauFini_ProduitId",
                table: "GateauFini",
                column: "ProduitId");

            migrationBuilder.CreateIndex(
                name: "IX_Produit_GammeId",
                table: "Produit",
                column: "GammeId");

            migrationBuilder.CreateIndex(
                name: "IX_Produit_ModelId",
                table: "Produit",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Produit_TailleId",
                table: "Produit",
                column: "TailleId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_Base_FilialeId",
                table: "Stock_Base",
                column: "FilialeId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_Base_ProduitId",
                table: "Stock_Base",
                column: "ProduitId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_Produit_FilialeId",
                table: "Stock_Produit",
                column: "FilialeId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_Produit_ProduitId",
                table: "Stock_Produit",
                column: "ProduitId");

            migrationBuilder.CreateIndex(
                name: "IX_Usage_Ingredient_IngredientId",
                table: "Usage_Ingredient",
                column: "IngredientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commande_Produit_ProduitId",
                table: "Commande",
                column: "ProduitId",
                principalTable: "Produit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commune_Ville_VilleId",
                table: "Commune",
                column: "VilleId",
                principalTable: "Ville",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Panier_Produit_ProduitId",
                table: "Panier",
                column: "ProduitId",
                principalTable: "Produit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pays_Continent_ContinentId",
                table: "Pays",
                column: "ContinentId",
                principalTable: "Continent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quartier_Commune_CommuneId",
                table: "Quartier",
                column: "CommuneId",
                principalTable: "Commune",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quartier_Zone_ZoneId",
                table: "Quartier",
                column: "ZoneId",
                principalTable: "Zone",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ville_Pays_PaysId",
                table: "Ville",
                column: "PaysId",
                principalTable: "Pays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commande_Produit_ProduitId",
                table: "Commande");

            migrationBuilder.DropForeignKey(
                name: "FK_Commune_Ville_VilleId",
                table: "Commune");

            migrationBuilder.DropForeignKey(
                name: "FK_Panier_Produit_ProduitId",
                table: "Panier");

            migrationBuilder.DropForeignKey(
                name: "FK_Pays_Continent_ContinentId",
                table: "Pays");

            migrationBuilder.DropForeignKey(
                name: "FK_Quartier_Commune_CommuneId",
                table: "Quartier");

            migrationBuilder.DropForeignKey(
                name: "FK_Quartier_Zone_ZoneId",
                table: "Quartier");

            migrationBuilder.DropForeignKey(
                name: "FK_Ville_Pays_PaysId",
                table: "Ville");

            migrationBuilder.DropTable(
                name: "AchatIngredient");

            migrationBuilder.DropTable(
                name: "GateauBase");

            migrationBuilder.DropTable(
                name: "GateauFini");

            migrationBuilder.DropTable(
                name: "Payement");

            migrationBuilder.DropTable(
                name: "Stock_Base");

            migrationBuilder.DropTable(
                name: "Stock_Produit");

            migrationBuilder.DropTable(
                name: "Usage_Ingredient");

            migrationBuilder.DropTable(
                name: "Fournisseur");

            migrationBuilder.DropTable(
                name: "Filiale");

            migrationBuilder.DropTable(
                name: "Produit");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropIndex(
                name: "IX_Ville_PaysId",
                table: "Ville");

            migrationBuilder.DropIndex(
                name: "IX_Quartier_CommuneId",
                table: "Quartier");

            migrationBuilder.DropIndex(
                name: "IX_Quartier_ZoneId",
                table: "Quartier");

            migrationBuilder.DropIndex(
                name: "IX_Pays_ContinentId",
                table: "Pays");

            migrationBuilder.DropIndex(
                name: "IX_Commune_VilleId",
                table: "Commune");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Continent",
                table: "Continent");

            migrationBuilder.RenameTable(
                name: "Continent",
                newName: "Continents");

            migrationBuilder.RenameColumn(
                name: "PaysId",
                table: "Ville",
                newName: "Pays");

            migrationBuilder.RenameColumn(
                name: "ProduitId",
                table: "Panier",
                newName: "TailleId");

            migrationBuilder.RenameIndex(
                name: "IX_Panier_ProduitId",
                table: "Panier",
                newName: "IX_Panier_TailleId");

            migrationBuilder.RenameColumn(
                name: "ProduitId",
                table: "Commande",
                newName: "TailleId");

            migrationBuilder.RenameIndex(
                name: "IX_Commande_ProduitId",
                table: "Commande",
                newName: "IX_Commande_TailleId");

            migrationBuilder.AddColumn<Guid>(
                name: "GammeId",
                table: "Panier",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ModelId",
                table: "Panier",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "GammeId",
                table: "Commande",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ModelId",
                table: "Commande",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Continents",
                table: "Continents",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Panier_GammeId",
                table: "Panier",
                column: "GammeId");

            migrationBuilder.CreateIndex(
                name: "IX_Panier_ModelId",
                table: "Panier",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Commande_GammeId",
                table: "Commande",
                column: "GammeId");

            migrationBuilder.CreateIndex(
                name: "IX_Commande_ModelId",
                table: "Commande",
                column: "ModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commande_Gamme_GammeId",
                table: "Commande",
                column: "GammeId",
                principalTable: "Gamme",
                principalColumn: "GammeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commande_Model_ModelId",
                table: "Commande",
                column: "ModelId",
                principalTable: "Model",
                principalColumn: "ModelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commande_Taille_TailleId",
                table: "Commande",
                column: "TailleId",
                principalTable: "Taille",
                principalColumn: "TailleId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Panier_Gamme_GammeId",
                table: "Panier",
                column: "GammeId",
                principalTable: "Gamme",
                principalColumn: "GammeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Panier_Model_ModelId",
                table: "Panier",
                column: "ModelId",
                principalTable: "Model",
                principalColumn: "ModelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Panier_Taille_TailleId",
                table: "Panier",
                column: "TailleId",
                principalTable: "Taille",
                principalColumn: "TailleId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
