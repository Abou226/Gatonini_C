using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class MiseAJourTableauxs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Client",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Genre = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Client", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Continent",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Continent", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ExternalLogin",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Provider = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
            //        Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        DateOfLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        DateOfExpiry = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ExternalLogin", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Fournisseur",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Genre = table.Column<int>(type: "int", nullable: false),
            //        DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Fournisseur", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Ingredient",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Reference = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Unité = table.Column<int>(type: "int", nullable: false),
            //        Quantité = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        Stock_Min = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        Stock_Max = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Ingredient", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Num_Vente",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Num_Vente", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Payement",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Montant = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        Reference = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Num_Opération = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Mode_Payement = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Nature = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        DatePayement = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Payement", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Produit",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        GammeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        TailleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        ModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Produit", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Produit_Gamme_GammeId",
            //            column: x => x.GammeId,
            //            principalTable: "Gamme",
            //            principalColumn: "GammeId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Produit_Model_ModelId",
            //            column: x => x.ModelId,
            //            principalTable: "Model",
            //            principalColumn: "ModelId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Produit_Taille_TailleId",
            //            column: x => x.TailleId,
            //            principalTable: "Taille",
            //            principalColumn: "TailleId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Zone",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Zone", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Pays",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ContinentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Pays", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Pays_Continent_ContinentId",
            //            column: x => x.ContinentId,
            //            principalTable: "Continent",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AchatIngredient",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        IngredientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AchatIngredient", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_AchatIngredient_Ingredient_IngredientId",
            //            column: x => x.IngredientId,
            //            principalTable: "Ingredient",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Stock_Produit",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ProduitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Stock_Produit", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Stock_Produit_Produit_ProduitId",
            //            column: x => x.ProduitId,
            //            principalTable: "Produit",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Ville",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        PaysId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Ville", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Ville_Pays_PaysId",
            //            column: x => x.PaysId,
            //            principalTable: "Pays",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Commune",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        VilleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Commune", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Commune_Ville_VilleId",
            //            column: x => x.VilleId,
            //            principalTable: "Ville",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Quartier",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CommuneId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        ZoneId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Quartier", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Quartier_Commune_CommuneId",
            //            column: x => x.CommuneId,
            //            principalTable: "Commune",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Quartier_Zone_ZoneId",
            //            column: x => x.ZoneId,
            //            principalTable: "Zone",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Commande",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ProduitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Quantité = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        Prix_Vente_Unité = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        QuartierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        Heure_Livraison = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Details_Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Date_Livraison = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Num_VenteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        ServerTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        Mention = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Contact_Livraison = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Commande", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Commande_Client_ClientId",
            //            column: x => x.ClientId,
            //            principalTable: "Client",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Commande_Num_Vente_Num_VenteId",
            //            column: x => x.Num_VenteId,
            //            principalTable: "Num_Vente",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Commande_Quartier_QuartierId",
            //            column: x => x.QuartierId,
            //            principalTable: "Quartier",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Filiale",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        QuartierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        ZoneId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Filiale", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Filiale_Quartier_QuartierId",
            //            column: x => x.QuartierId,
            //            principalTable: "Quartier",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Filiale_Zone_ZoneId",
            //            column: x => x.ZoneId,
            //            principalTable: "Zone",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Panier",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ProduitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Quantité = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        Prix_Vente_Unité = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        QuartierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        Heure_Livraison = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Details_Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Date_Livraison = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ServerTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        Mention = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Contact_Livraison = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Panier", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Panier_Client_ClientId",
            //            column: x => x.ClientId,
            //            principalTable: "Client",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Panier_Quartier_QuartierId",
            //            column: x => x.QuartierId,
            //            principalTable: "Quartier",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "GateauBase",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ProduitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        Date = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        FilialeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_GateauBase", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_GateauBase_Filiale_FilialeId",
            //            column: x => x.FilialeId,
            //            principalTable: "Filiale",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_GateauBase_Produit_ProduitId",
            //            column: x => x.ProduitId,
            //            principalTable: "Produit",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "GateauFini",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ProduitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        Date = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        FilialeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_GateauFini", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_GateauFini_Filiale_FilialeId",
            //            column: x => x.FilialeId,
            //            principalTable: "Filiale",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_GateauFini_Produit_ProduitId",
            //            column: x => x.ProduitId,
            //            principalTable: "Produit",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Stock_Base",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ProduitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Quantité = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        FilialeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Stock_Base", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Stock_Base_Filiale_FilialeId",
            //            column: x => x.FilialeId,
            //            principalTable: "Filiale",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Stock_Base_Produit_ProduitId",
            //            column: x => x.ProduitId,
            //            principalTable: "Produit",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_AchatIngredient_IngredientId",
            //    table: "AchatIngredient",
            //    column: "IngredientId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Commande_ClientId",
            //    table: "Commande",
            //    column: "ClientId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Commande_Num_VenteId",
            //    table: "Commande",
            //    column: "Num_VenteId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Commande_QuartierId",
            //    table: "Commande",
            //    column: "QuartierId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Commune_VilleId",
            //    table: "Commune",
            //    column: "VilleId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Filiale_QuartierId",
            //    table: "Filiale",
            //    column: "QuartierId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Filiale_ZoneId",
            //    table: "Filiale",
            //    column: "ZoneId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_GateauBase_FilialeId",
            //    table: "GateauBase",
            //    column: "FilialeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_GateauBase_ProduitId",
            //    table: "GateauBase",
            //    column: "ProduitId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_GateauFini_FilialeId",
            //    table: "GateauFini",
            //    column: "FilialeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_GateauFini_ProduitId",
            //    table: "GateauFini",
            //    column: "ProduitId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Panier_ClientId",
            //    table: "Panier",
            //    column: "ClientId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Panier_QuartierId",
            //    table: "Panier",
            //    column: "QuartierId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Pays_ContinentId",
            //    table: "Pays",
            //    column: "ContinentId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Produit_GammeId",
            //    table: "Produit",
            //    column: "GammeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Produit_ModelId",
            //    table: "Produit",
            //    column: "ModelId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Produit_TailleId",
            //    table: "Produit",
            //    column: "TailleId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Quartier_CommuneId",
            //    table: "Quartier",
            //    column: "CommuneId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Quartier_ZoneId",
            //    table: "Quartier",
            //    column: "ZoneId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Stock_Base_FilialeId",
            //    table: "Stock_Base",
            //    column: "FilialeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Stock_Base_ProduitId",
            //    table: "Stock_Base",
            //    column: "ProduitId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Stock_Produit_ProduitId",
            //    table: "Stock_Produit",
            //    column: "ProduitId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Ville_PaysId",
            //    table: "Ville",
            //    column: "PaysId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AchatIngredient");

            migrationBuilder.DropTable(
                name: "Commande");

            migrationBuilder.DropTable(
                name: "ExternalLogin");

            migrationBuilder.DropTable(
                name: "Fournisseur");

            migrationBuilder.DropTable(
                name: "GateauBase");

            migrationBuilder.DropTable(
                name: "GateauFini");

            migrationBuilder.DropTable(
                name: "Panier");

            migrationBuilder.DropTable(
                name: "Payement");

            migrationBuilder.DropTable(
                name: "Stock_Base");

            migrationBuilder.DropTable(
                name: "Stock_Produit");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Num_Vente");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Filiale");

            migrationBuilder.DropTable(
                name: "Produit");

            migrationBuilder.DropTable(
                name: "Quartier");

            migrationBuilder.DropTable(
                name: "Commune");

            migrationBuilder.DropTable(
                name: "Zone");

            migrationBuilder.DropTable(
                name: "Ville");

            migrationBuilder.DropTable(
                name: "Pays");

            migrationBuilder.DropTable(
                name: "Continent");
        }
    }
}
