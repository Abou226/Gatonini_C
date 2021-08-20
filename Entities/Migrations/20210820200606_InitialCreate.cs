using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Categorie",
            //    columns: table => new
            //    {
            //        CategorieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
            //        DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Url = table.Column<string>(type: "nvarchar(220)", maxLength: 220, nullable: false),
            //        Active = table.Column<bool>(type: "bit", nullable: false),
            //        ServerTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UserId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Categorie", x => x.CategorieId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Marque",
            //    columns: table => new
            //    {
            //        MarqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UserId = table.Column<int>(type: "int", nullable: true),
            //        Url = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
            //        ServerTime = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Marque", x => x.MarqueId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Model",
            //    columns: table => new
            //    {
            //        ModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
            //        DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UserId = table.Column<int>(type: "int", nullable: true),
            //        CatégorieId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        Url = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //        ServerTime = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Model", x => x.ModelId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "stk_temp",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Id_Produit = table.Column<int>(type: "int", nullable: true),
            //        Ingredient = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Unité = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_stk_temp", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Style",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
            //        DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Url = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        ServerTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UserId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Style", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "sysdiagrams",
            //    columns: table => new
            //    {
            //        name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //        principal_id = table.Column<int>(type: "int", nullable: false),
            //        diagram_id = table.Column<int>(type: "int", nullable: false),
            //        version = table.Column<int>(type: "int", nullable: true),
            //        definition = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Taille",
            //    columns: table => new
            //    {
            //        TailleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
            //        DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        ServerTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UserId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Taille", x => x.TailleId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_accessoire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Nom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_accessoire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_achat",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Reference = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Nom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Fournisseur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Bon_Commande = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Num_Facture = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Qreel = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Montant = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Ref_Pièces = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Débit = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Crédit = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_achat", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_arrivée",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Code_Barre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Nom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Catégorie = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Fournisseur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Bon_Commande = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date_Arrivée = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Prix = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Taille = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Détachement = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Num_Achat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_arrivée", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_arrivée_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Barcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Catégorie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Fournisseur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Bon_Commande = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Taille = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date_Arrivée = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Prix = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Mesure = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Q_Unité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Num_Achat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date_Action = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Id_Fournisseur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_arrivée_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_arrivée_temp",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Code_Barre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Nom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Catégorie = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Fournisseur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Bon_Commande = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date_Arrivée = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Prix = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Taille = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Détachement = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_arrivée_temp", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_arrivée_temp_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Barcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Catégorie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Fournisseur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Bon_Commande = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Taille = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date_Arrivée = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Prix = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Mesure = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Id_Fournisseur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_arrivée_temp_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_avarie_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Source = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Gateau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Nb_Part = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Forme = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Destination = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Num_Transfère = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Code_Barre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Mesure = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Validé = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_avarie_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_avarie_partenaire_temp",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Source = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Gateau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Nb_Part = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Forme = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Destination = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Num_Transfère = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Code_Barre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Mesure = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_avarie_partenaire_temp", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_bon",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Order_Id = table.Column<int>(type: "int", nullable: true),
            //        Bon_Commande = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_bon", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_bon_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Order_Id = table.Column<int>(type: "int", nullable: true),
            //        Bon_Commande = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_bon_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_catégorie",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Catégorie = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_catégorie", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_catégorie_gadget",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Catégorie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_catégorie_gadget", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_catégorie_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Catégorie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_catégorie_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_client",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Prenom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Genre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Telephone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Adresse = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_client", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_client_partenaires",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Prenom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Genre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Telephone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Adresse = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_client_partenaires", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_clients",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Prenom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Nom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Genre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Telephone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Telephone2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date_Ajout = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Mot_Passe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_clients", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_commande",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Reference = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Produit = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Prix_Unité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Montant = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Bon_Commande = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Fournisseur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_commande", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_commande_partenaires",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Barcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Date_Livraison = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Heure = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Id_Auteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Designation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Mention = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Adresse = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Id_Entité = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Contact_Livraison = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Livreur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Contact_Livreur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Num_Vente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Payée = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Montant = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Prix_Unité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Produit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Forme = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Client = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Contact_Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Annulée = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date_Modification = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Date_Action = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Date_Annulation = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Date_Payement = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Reference_Payement = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Livrée = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_commande_partenaires", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_commande_temp_partenaires",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Barcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Date_Livraison = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Heure = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Id_Auteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Designation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Mention = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Adresse = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Id_Entité = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Contact_Livraison = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Livreur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Contact_Livreur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Montant = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Prix_Unité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Produit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Forme = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Client = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Contact_Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_commande_temp_partenaires", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_compte_comptable",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Compte = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        Catégorie = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
            //        Nom_Compte = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
            //        Description = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
            //        Compte_Aux = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Préfix = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_compte_comptable", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_depenses",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Info_Compte = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Depenses = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Montant = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_depenses", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_detachement",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Adresse = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        Contact = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Siège = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_detachement", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_elements",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Nom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Valeur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_elements", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_entité",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Nom = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_entité", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_entreprise",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Nom = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
            //        Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Adresse = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
            //        Téléphone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Pays = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Ville = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Secteur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Type_Produit = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Slogan = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
            //        Couleur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_entreprise", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_fichier_gestion",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Nom = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Num_Opération = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Fichier = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
            //        Nom_Fichier = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_fichier_gestion", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_FileLocation",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        FilePath = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_FileLocation", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_filiale_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Adresse = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        Contact = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Siège = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_filiale_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_formule_mesure_vente",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Formule = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Petit = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Moyen = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Grand = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Large = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        HyperLarge = table.Column<decimal>(name: "Hyper Large", type: "decimal(18,0)", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_formule_mesure_vente", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_formule_mesure_vente_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Formule = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Petit = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Moyen = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Grand = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Large = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        HyperLarge = table.Column<decimal>(name: "Hyper Large", type: "decimal(18,0)", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_formule_mesure_vente_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_fournisseurs",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Nom = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        Adresse = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: true),
            //        Contact = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Genre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_fournisseurs", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_gadget",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Code_Barre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Marque = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        Catégorie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Taille = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Usage = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Prix_Unité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Image = table.Column<byte[]>(type: "image", nullable: true),
            //        Nom_Fichier = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Formule = table.Column<int>(type: "int", nullable: true),
            //        Mesure = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Prix_Petit = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Prix_Moyen = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Prix_Grand = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Prix_Large = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Prix_Hyper_Large = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Stock_min = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Stock_max = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_gadget", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_garnissage",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Nom = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: true),
            //        Prix_Unité = table.Column<decimal>(type: "decimal(18,1)", nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_garnissage", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_gateau",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Gateau = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
            //        Nb_Part = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Heure = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Rectangle = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Rond = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Coeur = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Buste = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Rond_Haut = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Autre_Forme = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Q_Utilisé = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Q_Reçu = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur_Sortie = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        Auteur_Reception = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        Date_Reception = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Q_Autre = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Q_Rond = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Q_Rectangle = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Q_Coeur = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Q_Buste = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Q_RondHaut = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        U_Rectangle = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        U_Rond = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        U_Coeur = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        U_RondHaut = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        U_Buste = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        U_AutreForme = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_gateau", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_gateau_base",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Gateau = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
            //        Heure = table.Column<int>(type: "int", nullable: true),
            //        Nombre = table.Column<int>(type: "int", nullable: true),
            //        Nb_Part = table.Column<int>(type: "int", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
            //        Forme = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Auteur_Validation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        Nb_Lancé = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Detachement = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_gateau_base", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_gateau_base_temp",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Gateau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Nb_Part = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Forme = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur_Validation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        Date_Validation = table.Column<DateTime>(type: "datetime", nullable: true),
            //        QReel = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_gateau_base_temp", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_gateau_client",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Image = table.Column<byte[]>(type: "image", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Likes = table.Column<int>(type: "int", nullable: true),
            //        Nb_Cmd = table.Column<int>(type: "int", nullable: true),
            //        Nb_Avis = table.Column<int>(type: "int", nullable: true),
            //        Prix_Unité = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_gateau_client", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_gateau_fini_temp",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Gateau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Nb_Part = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Forme = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur_Validation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        Date_Validation = table.Column<DateTime>(type: "datetime", nullable: true),
            //        QReel = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_gateau_fini_temp", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_intitulé",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Intitulé = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_intitulé", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_inventaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Reference = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Nom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Stock_min = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Stock_max = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_inventaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_journal_comptable",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Date = table.Column<DateTime>(type: "date", nullable: true),
            //        Date_Enregistrement = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Libelle = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Compte = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Débit = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Crédit = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
            //        Ref_Pièces = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Commentaire = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
            //        Nom_Fichier = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Fichier = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
            //        Ref_Payement = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
            //        Compte_Tier = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Active = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        N_Facture = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Validé = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Cloturé = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_journal_comptable", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_journal_comptable_test",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Date = table.Column<DateTime>(type: "date", nullable: true),
            //        Date_Enregistrement = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Libelle = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Compte = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Débit = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Crédit = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
            //        Ref_Pièces = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Commentaire = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
            //        Nom_Fichier = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Fichier = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
            //        Ref_Payement = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
            //        Compte_Tier = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Active = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        N_Facture = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Validé = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_journal_comptable_test", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_likes_gateau",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Id_Produit = table.Column<int>(type: "int", nullable: true),
            //        Id_Client = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_likes_gateau", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_list_fournisseur",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Adresse = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Telephone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Ville = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Pays = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Logo = table.Column<byte[]>(type: "image", nullable: true),
            //        Taille_Image = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_list_fournisseur", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_list_gateau",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Catégorie = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Produit = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Rond = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Rectangle = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Coeur = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        RondHaut = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Buste = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        AutreForme = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Nb_Part = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Prix_Unité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Stock_min = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Stock_max = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_list_gateau", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_list_journaux",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Nom = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Prefix = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        Compte = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_list_journaux", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_list_produit",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Code_Barre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Catégorie = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Produit = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Rond = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Rectangle = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Coeur = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        RondHaut = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Buste = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        AutreForme = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Nb_Part = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Prix_Unité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Stock_min = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Stock_max = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_list_produit", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_list_validation_stock",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Id_User = table.Column<int>(type: "int", nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_list_validation_stock", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_livraison_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Reference = table.Column<int>(type: "int", nullable: true),
            //        Gateau = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        Contact_Client = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Nom_Client = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
            //        Adresse_Livraison = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
            //        Livreur = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
            //        Date_Livraison = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Filiale = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_livraison_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_livraison_partenaire_express",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Reference = table.Column<int>(type: "int", nullable: true),
            //        Gateau = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        Contact_Client = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Nom_Client = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
            //        Adresse_Livraison = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
            //        Livreur = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
            //        Date_Livraison = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Entité = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_livraison_partenaire_express", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_livreur",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Nom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Contact = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Adresse = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Genre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_livreur", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_livreur_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Nom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Contact = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Adresse = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Genre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Entreprise = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Prenom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_livreur_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_marque",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Marque = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_marque", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_marque_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Marque = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_marque_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_melange",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Model = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
            //        Prix_Unité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_melange", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_mesure_vente",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Default = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Niveau = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_mesure_vente", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_mesure_vente_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Default = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Niveau = table.Column<int>(type: "int", nullable: true),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_mesure_vente_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_mode_payement_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Mode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Auteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Simpa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Defaut = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_mode_payement_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_model",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Model = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
            //        Prix_Unité = table.Column<decimal>(type: "decimal(18,1)", nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_model", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_num_achat",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Num_Achat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        OrderId = table.Column<int>(type: "int", nullable: true),
            //        Order = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_num_achat", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_num_achat_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Num_Achat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        OrderId = table.Column<int>(type: "int", nullable: true),
            //        Order = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_num_achat_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_num_avarie_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        OrderId = table.Column<int>(type: "int", nullable: true),
            //        Order = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_num_avarie_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_num_cmd",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        OrderId = table.Column<int>(type: "int", nullable: true),
            //        Order = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_num_cmd", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_num_cmd_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        OrderId = table.Column<int>(type: "int", nullable: true),
            //        Order = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_num_cmd_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_num_payement_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        OrderId = table.Column<int>(type: "int", nullable: true),
            //        Order = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_num_payement_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_num_transfère",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        OrderId = table.Column<int>(type: "int", nullable: true),
            //        Order = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_num_transfère", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_num_transfère_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        OrderId = table.Column<int>(type: "int", nullable: true),
            //        Order = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_num_transfère_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_num_vente",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        OrderId = table.Column<int>(type: "int", nullable: true),
            //        Order = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_num_vente", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_num_vente_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        OrderId = table.Column<int>(type: "int", nullable: true),
            //        Order = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_num_vente_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_num_vente_partenaires_express",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        OrderId = table.Column<int>(type: "int", nullable: true),
            //        Order = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_num_vente_partenaires_express", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_operation_default_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Default = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_operation_default_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        NomSocial = table.Column<string>(name: "Nom Social", type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Contact1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Contact2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Adresse = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Ville = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Pays = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
            //        Logo = table.Column<byte[]>(type: "image", nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_partenaires_filiale",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Filiale = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Gateau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Forme = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Nb_Part = table.Column<int>(type: "int", nullable: true),
            //        Code_Barre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_partenaires_filiale", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_payement",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Num_Cmd = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        Client = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        Contact_Client = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Nb_Gateau = table.Column<int>(type: "int", nullable: true),
            //        Ref_Gateau = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
            //        Montant = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
            //        Mode_Payement = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date_Payement = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Ref_Payement = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Ref_Sarali = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Raison = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Id_Tier = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Réduction = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_payement", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_payement_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Num_Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Date_Payement = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Montant = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Mode_Payement = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Commentaire = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Num_Opération = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Matricule = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Réduction = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Raison = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        CompteTier = table.Column<string>(name: "Compte Tier", type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Nature = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date_Echeance = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Reference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Filiale = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_payement_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_petit_gateau",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Nom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_petit_gateau", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_preparé",
            //    columns: table => new
            //    {
            //        Ref = table.Column<int>(type: "int", nullable: false),
            //        Gateau = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
            //        Description = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
            //        Mention = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        Client = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date_Sortie = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur_Enregistrement = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Nb_Part = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Forme = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_preparé", x => x.Ref);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_produits",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Nom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Ref = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Unité = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Stock_min = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Stock_max = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_produits", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_produits_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Barcode = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
            //        Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Catégorie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Taille = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Stock_min = table.Column<int>(type: "int", nullable: true),
            //        Stock_max = table.Column<int>(type: "int", nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Dept_Auteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Image = table.Column<byte[]>(type: "image", nullable: true),
            //        Usage = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Prix_Petit = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Prix_Moyen = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Prix_Grand = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Prix_Large = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Prix_Hyper_Large = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Mesure = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Formule_Stockage = table.Column<int>(type: "int", nullable: true),
            //        Nom_Image = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        Prix_Petit_Grossiste = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Prix_Moyen_Grossiste = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Prix_Grand_Grossiste = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Prix_Large_Grossiste = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Prix_Hyper_Large_Grossiste = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Prix_Achat = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Filiale = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_produits_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_protuit_agro",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Nom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_protuit_agro", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_redévance_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Redéveur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Rédevant = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Montant = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_redévance_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_registre_gateau",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Code_Barre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Gateau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Nb_Part = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Forme = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_registre_gateau", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_remise",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Num_Cmd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Client = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Num_Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Montant = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_remise", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_repartition_gadget",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Code_Barre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Marque = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Catégorie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Taille = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Source = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Destination = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Num_Tranfère = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_repartition_gadget", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_repartition_gadget_temp",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Code_Barre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Marque = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Catégorie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Taille = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Source = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Destination = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_repartition_gadget_temp", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_repartition_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Source = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Gateau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Nb_Part = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Forme = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Destination = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Num_Transfère = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Code_Barre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Mesure = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_repartition_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_repartition_partenaire_temp",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Source = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Gateau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Nb_Part = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Forme = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Destination = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Num_Transfère = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Code_Barre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Mesure = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_repartition_partenaire_temp", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_repartitions",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Source = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Gateau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Nb_Part = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Forme = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Destination = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Num_Transfère = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Code_Barre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Validée = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_repartitions", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_repartitions_temp",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Source = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Gateau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Nb_Part = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Forme = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Destination = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Num_Transfère = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Code_Barre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_repartitions_temp", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_requette_gateau_base",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Gateau = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        Nb_Part = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Forme = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Auteur_Requette = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Active = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Qreel = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Auteur_Validation = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date_Validation = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Q_Utilisé = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_requette_gateau_base", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_requette_ingredient",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Ingredient = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Reference = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Mesure = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Date_Validation = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Auteur_Validation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        QReel = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Active = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_requette_ingredient", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_reservation_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Num_Operation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Commande = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Catégorie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Taille = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Code_Barre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Date_Livraison = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Adresse = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Mention = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Disponible = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Livré = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Livreur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Id_Livreur = table.Column<int>(type: "int", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Montant = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Payée = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Partenaire = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Id_Client = table.Column<int>(type: "int", nullable: true),
            //        Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Num_Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Num_Livraison = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Image = table.Column<byte[]>(type: "image", nullable: true),
            //        Taille_Image = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Filiale = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Situation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Type_Produit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        TarifLivraison = table.Column<decimal>(name: "Tarif Livraison", type: "decimal(18,0)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_reservation_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_reservation_partenaire_temp",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Num_Operation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Commande = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Catégorie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Taille = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Code_Barre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Date_Livraison = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Adresse = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Mention = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Disponible = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Livré = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Livreur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Id_Livreur = table.Column<int>(type: "int", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Montant = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Payée = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Partenaire = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Id_Client = table.Column<int>(type: "int", nullable: true),
            //        Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Num_Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Num_Livraison = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Image = table.Column<byte[]>(type: "image", nullable: true),
            //        Taille_Image = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Type_Produit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        TarifLivraison = table.Column<decimal>(name: "Tarif Livraison", type: "decimal(18,0)", nullable: true),
            //        Filiale = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_reservation_partenaire_temp", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_reste_ingredient",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Ingredient = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Mesure = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Fichier = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
            //        Nom_Fichier = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_reste_ingredient", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_retour_client",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Num_Cmd = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Client = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        Contact = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Nb_Cmd = table.Column<int>(type: "int", nullable: true),
            //        Montant = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Reception = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
            //        Produit = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
            //        Livraison = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
            //        Note = table.Column<int>(type: "int", nullable: true),
            //        Auteur_Retour = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Suggestion = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_retour_client", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_stock_fini_ravitaillement",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Gateau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Nb_Part = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Forme = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur_Validation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Nb_Lancé = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Detachement = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_stock_fini_ravitaillement", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_stock_gadget",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Code_Barre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Détachement = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Marque = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Taille = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Catégorie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Formule = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_stock_gadget", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_stock_gateau",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Code_Barre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Gateau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Nb_Part = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Forme = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Detachement = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_stock_gateau", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_stock_gateau_base",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Gateau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Nb_Part = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Forme = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Detachement = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_stock_gateau_base", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_stock_partenaires_filiale",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Filiale = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Catégorie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Taille = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Code_Barre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Formule = table.Column<int>(type: "int", nullable: true),
            //        Prix = table.Column<decimal>(type: "decimal(18,0)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_stock_partenaires_filiale", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_synchro",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Gateau_Base = table.Column<int>(type: "int", nullable: true),
            //        Finition = table.Column<int>(type: "int", nullable: true),
            //        Logistique = table.Column<int>(type: "int", nullable: true),
            //        Programme = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_synchro", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_synchro_date",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Production = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_synchro_date", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_synchro_stats",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Stats_Vente = table.Column<int>(type: "int", nullable: true),
            //        Stats_Achat = table.Column<int>(type: "int", nullable: true),
            //        Stats_Stock = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_synchro_stats", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_taille",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Taille = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_taille", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_taille_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Taille = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_taille_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_temp_achat",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Reference = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Nom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Fournisseur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Bon_Commande = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Num_Facture = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Qreel = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Montant = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Ref_Pièces = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Débit = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Crédit = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Compte_C = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Compte_D = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_temp_achat", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_temp_commande",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Reference = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Produit = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Prix_Unité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Montant = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Bon_Commande = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Fournisseur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_temp_commande", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_temp_usage",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Reference = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Nom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Unité = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Effectuée_Par = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_temp_usage", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_trans",
            //    columns: table => new
            //    {
            //        TransId = table.Column<int>(type: "int", nullable: false),
            //        Nb_Reserv = table.Column<int>(type: "int", nullable: true),
            //        Client = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
            //        Contact = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,1)", nullable: true),
            //        Total_Encaissé = table.Column<decimal>(type: "decimal(18,1)", nullable: true),
            //        Part = table.Column<decimal>(type: "decimal(18,1)", nullable: true),
            //        Payement = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Reste = table.Column<decimal>(type: "decimal(18,1)", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_trans", x => x.TransId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_Usage",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Reference = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Nom = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
            //        Unité = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,1)", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
            //        Effectuée_Par = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_Usage", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_usage_gadget",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Usage = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_usage_gadget", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_Users",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Prenom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Nom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Contact = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Adresse = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Genre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Type_Compte = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Departement = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Active = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Role = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Nom_Complet = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        Auth_Reservation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Auth_Cuisine = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Auth_Logistique = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Auth_Stock = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Auth_Stats_Dashboard = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Auth_Comptabilité = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Partenaire = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Auth_Gestion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Filiale = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_Users", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_users_partenaires",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Prenom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Genre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Password = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Telephone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Telephone2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Id_Entité = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Type_Compte = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Pic_Path = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Email_Confirm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Telephone_Confirm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Telephone2_Confirm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_users_partenaires", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_vente",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Code_Barre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Produit = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Catégorie = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Prix_Unité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Montant = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Client = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Num_Client = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Part = table.Column<int>(type: "int", nullable: true),
            //        Taille = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Usage = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Détachement = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Num_Vente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_vente", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_vente_partenaire",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Barcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Produit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Catégorie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Taille = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Usage = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Num_Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Prix_Unité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Montant = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date_Vente = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Dept_Auteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Num_Vente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date_Action = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Date_Payement = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur_Payement = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Mesure = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Q_Unité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        ModePayement = table.Column<string>(name: "Mode Payement", type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Id_Client = table.Column<int>(type: "int", nullable: true),
            //        Filiale = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Nature = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Plateform = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        IdAuteur = table.Column<string>(name: "Id Auteur", type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Id_Entité = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_vente_partenaire", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_vente_partenaire_temp",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Barcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Produit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Catégorie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Taille = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Usage = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Client = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Num_Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Prix_Unité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Montant = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Date_Vente = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Dept_Auteur = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Mesure = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Id_Client = table.Column<int>(type: "int", nullable: true),
            //        Filiale = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Entreprise = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Nature = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Plateform = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        IdAuteur = table.Column<string>(name: "Id Auteur", type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Id_Entité = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_vente_partenaire_temp", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_vente_temp",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Code_Barre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Produit = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Catégorie = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Prix_Unité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Montant = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Client = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Num_Client = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Part = table.Column<int>(type: "int", nullable: true),
            //        Taille = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Usage = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Detachement = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_vente_temp", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tests",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Nom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Image = table.Column<byte[]>(type: "image", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Gamme",
            //    columns: table => new
            //    {
            //        GammeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CategorieId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        MarqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        StyleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ServerTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Url = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        Prix_Unité = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        UserId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Gamme", x => x.GammeId);
            //        table.ForeignKey(
            //            name: "FK_Gamme_Categorie_CategorieId",
            //            column: x => x.CategorieId,
            //            principalTable: "Categorie",
            //            principalColumn: "CategorieId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Gamme_Marque_MarqueId",
            //            column: x => x.MarqueId,
            //            principalTable: "Marque",
            //            principalColumn: "MarqueId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Gamme_Style_StyleId",
            //            column: x => x.StyleId,
            //            principalTable: "Style",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "RefreshToken",
            //    columns: table => new
            //    {
            //        RefreshTokenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        DateOfExpiry = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        DateOfIssue = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Refreshable = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
            //        UserId = table.Column<int>(type: "int", nullable: true),
            //        ServerTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('0001-01-01T00:00:00.0000000')"),
            //        AuteurId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_RefreshToken", x => x.RefreshTokenId);
            //        table.ForeignKey(
            //            name: "FK_RefreshToken_tbl_Users_AuteurId",
            //            column: x => x.AuteurId,
            //            principalTable: "tbl_Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_RefreshToken_tbl_Users_UserId",
            //            column: x => x.UserId,
            //            principalTable: "tbl_Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Reservation",
            //    columns: table => new
            //    {
            //        Reference = table.Column<int>(type: "int", nullable: false),
            //        TransId = table.Column<int>(type: "int", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Gateau = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Description = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
            //        Image = table.Column<byte[]>(type: "image", nullable: true),
            //        Nombre = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Part = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Montant = table.Column<decimal>(type: "decimal(18,1)", nullable: true),
            //        Client = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
            //        Num_Client = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Num2_Client = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Genre_Client = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Gateau_Pour = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date_Livraison = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Adresse_Livraison = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Heure_Livraison = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
            //        Mention_sur_gateau = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Dept_Auteur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Reçu_Logistique = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
            //        Auteur_Reception = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Sortie_Cuisine = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Auteur_Sortie = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Payée = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
            //        Payement = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
            //        Reste = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Validation_Payement = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date_Sortie = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Livraison = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Livreur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Echec_Livr = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Autre_Num_Payement = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Ref_Payement = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Ref_Sarali = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Reserv_Boutique = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Garnissage = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Descrip_Info = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
            //        Temp_Livraison = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Forme_Gateau = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Somme_Payée = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Situation_Payement = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Num_Cmd = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date_Payement = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Attribué = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Retour = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date_Production = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Contact_Livraison = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Date_Modification = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur_Modif = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Date_Annultation = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur_Annulation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        Date_Action = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Disponible = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Detachement = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Id_Client = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        UserId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Reservation", x => x.Reference);
            //        table.ForeignKey(
            //            name: "FK_Reservation_tbl_Users_UserId",
            //            column: x => x.UserId,
            //            principalTable: "tbl_Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_gros_gateau",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Nom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
            //        Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Categorie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Filename = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
            //        AuteurId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_gros_gateau", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_tbl_gros_gateau_tbl_Users_AuteurId",
            //            column: x => x.AuteurId,
            //            principalTable: "tbl_Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_livraison",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Reference = table.Column<int>(type: "int", nullable: true),
            //        Gateau = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        Contact_Client = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Nom_Client = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
            //        Adresse_Livraison = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
            //        Livreur = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
            //        Date_Livraison = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        AuteurId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_livraison", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_tbl_livraison_tbl_Users_AuteurId",
            //            column: x => x.AuteurId,
            //            principalTable: "tbl_Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_tempReserv",
            //    columns: table => new
            //    {
            //        ReserId = table.Column<int>(type: "int", nullable: false),
            //        Gateau = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Montant = table.Column<decimal>(type: "decimal(18,1)", nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,1)", nullable: true),
            //        Part = table.Column<decimal>(type: "decimal(18,1)", nullable: true),
            //        AuteurId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_tempReserv", x => x.ReserId);
            //        table.ForeignKey(
            //            name: "FK_tbl_tempReserv_tbl_Users_AuteurId",
            //            column: x => x.AuteurId,
            //            principalTable: "tbl_Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "temp_Reservation",
            //    columns: table => new
            //    {
            //        Reference = table.Column<int>(type: "int", nullable: false),
            //        TransId = table.Column<int>(type: "int", nullable: true),
            //        Date = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Gateau = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Description = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
            //        Image = table.Column<byte[]>(type: "image", nullable: true),
            //        Nombre = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Part = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Montant = table.Column<decimal>(type: "decimal(18,1)", nullable: true),
            //        Client = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: true),
            //        Num_Client = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Num2_Client = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Genre_Client = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Gateau_Pour = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date_Livraison = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Adresse_Livraison = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Heure_Livraison = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
            //        Mention_sur_gateau = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Dept_Auteur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Reçu_Logistique = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
            //        Auteur_Reception = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Sortie_Cuisine = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Auteur_Sortie = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Payée = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
            //        Payement = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Reste = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Validation_Payement = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date_Sortie = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Livraison = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Livreur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Echec_Livr = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Autre_Num_Payement = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Ref_Payement = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Ref_Sarali = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Reserv_Boutique = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Garnissage = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Descrip_Info = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
            //        Temp_Livraison = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Forme_Gateau = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Attribué = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Date_Production = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Contact_Livraison = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        AuteurId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_temp_Reservation", x => x.Reference);
            //        table.ForeignKey(
            //            name: "FK_temp_Reservation_tbl_Users_AuteurId",
            //            column: x => x.AuteurId,
            //            principalTable: "tbl_Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "tbl_planing_gateau",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Gateau = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true),
            //        Nb_Part = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Forme = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Heure = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Quantité = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Nb_Recueilli = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Nb_Compter = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Nb_Finition = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Use_Finition = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Auteur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Auteur_Requette = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        Auteur_Sortie = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        Date_Requette = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Date_ExRequette = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Date_Livraison = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Date_Sortie = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Reception_Confirmé = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Auteur_Reception = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        Date_Reception = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Annulée = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
            //        Auteur_Annulation = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        Rond_Fini = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        RHaut_Fini = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Rectangle_Fini = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Coeur_Fini = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Busque_Fini = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
            //        Assignation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        GammeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        ModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        TailleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        UserId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_planing_gateau", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_tbl_planing_gateau_Gamme_GammeId",
            //            column: x => x.GammeId,
            //            principalTable: "Gamme",
            //            principalColumn: "GammeId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_tbl_planing_gateau_Model_ModelId",
            //            column: x => x.ModelId,
            //            principalTable: "Model",
            //            principalColumn: "ModelId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_tbl_planing_gateau_Taille_TailleId",
            //            column: x => x.TailleId,
            //            principalTable: "Taille",
            //            principalColumn: "TailleId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Gamme_CategorieId",
            //    table: "Gamme",
            //    column: "CategorieId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Gamme_MarqueId",
            //    table: "Gamme",
            //    column: "MarqueId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Gamme_StyleId",
            //    table: "Gamme",
            //    column: "StyleId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_RefreshToken_AuteurId",
            //    table: "RefreshToken",
            //    column: "AuteurId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_RefreshToken_UserId",
            //    table: "RefreshToken",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Reservation_UserId",
            //    table: "Reservation",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_tbl_gros_gateau_AuteurId",
            //    table: "tbl_gros_gateau",
            //    column: "AuteurId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_tbl_livraison_AuteurId",
            //    table: "tbl_gros_gateau",
            //    column: "AuteurId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_tbl_livraison_AuteurId1",
            //    table: "tbl_livraison",
            //    column: "AuteurId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_tbl_planing_gateau_GammeId",
            //    table: "tbl_planing_gateau",
            //    column: "GammeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_tbl_planing_gateau_ModelId",
            //    table: "tbl_planing_gateau",
            //    column: "ModelId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_tbl_planing_gateau_TailleId",
            //    table: "tbl_planing_gateau",
            //    column: "TailleId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_tbl_tempReserv_AuteurId",
            //    table: "tbl_tempReserv",
            //    column: "AuteurId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_temp_Reservation_AuteurId",
            //    table: "temp_Reservation",
            //    column: "AuteurId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "stk_temp");

            migrationBuilder.DropTable(
                name: "sysdiagrams");

            migrationBuilder.DropTable(
                name: "tbl_accessoire");

            migrationBuilder.DropTable(
                name: "tbl_achat");

            migrationBuilder.DropTable(
                name: "tbl_arrivée");

            migrationBuilder.DropTable(
                name: "tbl_arrivée_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_arrivée_temp");

            migrationBuilder.DropTable(
                name: "tbl_arrivée_temp_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_avarie_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_avarie_partenaire_temp");

            migrationBuilder.DropTable(
                name: "tbl_bon");

            migrationBuilder.DropTable(
                name: "tbl_bon_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_catégorie");

            migrationBuilder.DropTable(
                name: "tbl_catégorie_gadget");

            migrationBuilder.DropTable(
                name: "tbl_catégorie_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_client");

            migrationBuilder.DropTable(
                name: "tbl_client_partenaires");

            migrationBuilder.DropTable(
                name: "tbl_clients");

            migrationBuilder.DropTable(
                name: "tbl_commande");

            migrationBuilder.DropTable(
                name: "tbl_commande_partenaires");

            migrationBuilder.DropTable(
                name: "tbl_commande_temp_partenaires");

            migrationBuilder.DropTable(
                name: "tbl_compte_comptable");

            migrationBuilder.DropTable(
                name: "tbl_depenses");

            migrationBuilder.DropTable(
                name: "tbl_detachement");

            migrationBuilder.DropTable(
                name: "tbl_elements");

            migrationBuilder.DropTable(
                name: "tbl_entité");

            migrationBuilder.DropTable(
                name: "tbl_entreprise");

            migrationBuilder.DropTable(
                name: "tbl_fichier_gestion");

            migrationBuilder.DropTable(
                name: "tbl_FileLocation");

            migrationBuilder.DropTable(
                name: "tbl_filiale_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_formule_mesure_vente");

            migrationBuilder.DropTable(
                name: "tbl_formule_mesure_vente_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_fournisseurs");

            migrationBuilder.DropTable(
                name: "tbl_gadget");

            migrationBuilder.DropTable(
                name: "tbl_garnissage");

            migrationBuilder.DropTable(
                name: "tbl_gateau");

            migrationBuilder.DropTable(
                name: "tbl_gateau_base");

            migrationBuilder.DropTable(
                name: "tbl_gateau_base_temp");

            migrationBuilder.DropTable(
                name: "tbl_gateau_client");

            migrationBuilder.DropTable(
                name: "tbl_gateau_fini_temp");

            migrationBuilder.DropTable(
                name: "tbl_gros_gateau");

            migrationBuilder.DropTable(
                name: "tbl_intitulé");

            migrationBuilder.DropTable(
                name: "tbl_inventaire");

            migrationBuilder.DropTable(
                name: "tbl_journal_comptable");

            migrationBuilder.DropTable(
                name: "tbl_journal_comptable_test");

            migrationBuilder.DropTable(
                name: "tbl_likes_gateau");

            migrationBuilder.DropTable(
                name: "tbl_list_fournisseur");

            migrationBuilder.DropTable(
                name: "tbl_list_gateau");

            migrationBuilder.DropTable(
                name: "tbl_list_journaux");

            migrationBuilder.DropTable(
                name: "tbl_list_produit");

            migrationBuilder.DropTable(
                name: "tbl_list_validation_stock");

            migrationBuilder.DropTable(
                name: "tbl_livraison");

            migrationBuilder.DropTable(
                name: "tbl_livraison_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_livraison_partenaire_express");

            migrationBuilder.DropTable(
                name: "tbl_livreur");

            migrationBuilder.DropTable(
                name: "tbl_livreur_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_marque");

            migrationBuilder.DropTable(
                name: "tbl_marque_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_melange");

            migrationBuilder.DropTable(
                name: "tbl_mesure_vente");

            migrationBuilder.DropTable(
                name: "tbl_mesure_vente_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_mode_payement_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_model");

            migrationBuilder.DropTable(
                name: "tbl_num_achat");

            migrationBuilder.DropTable(
                name: "tbl_num_achat_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_num_avarie_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_num_cmd");

            migrationBuilder.DropTable(
                name: "tbl_num_cmd_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_num_payement_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_num_transfère");

            migrationBuilder.DropTable(
                name: "tbl_num_transfère_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_num_vente");

            migrationBuilder.DropTable(
                name: "tbl_num_vente_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_num_vente_partenaires_express");

            migrationBuilder.DropTable(
                name: "tbl_operation_default_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_partenaires_filiale");

            migrationBuilder.DropTable(
                name: "tbl_payement");

            migrationBuilder.DropTable(
                name: "tbl_payement_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_petit_gateau");

            migrationBuilder.DropTable(
                name: "tbl_planing_gateau");

            migrationBuilder.DropTable(
                name: "tbl_preparé");

            migrationBuilder.DropTable(
                name: "tbl_produits");

            migrationBuilder.DropTable(
                name: "tbl_produits_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_protuit_agro");

            migrationBuilder.DropTable(
                name: "tbl_redévance_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_registre_gateau");

            migrationBuilder.DropTable(
                name: "tbl_remise");

            migrationBuilder.DropTable(
                name: "tbl_repartition_gadget");

            migrationBuilder.DropTable(
                name: "tbl_repartition_gadget_temp");

            migrationBuilder.DropTable(
                name: "tbl_repartition_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_repartition_partenaire_temp");

            migrationBuilder.DropTable(
                name: "tbl_repartitions");

            migrationBuilder.DropTable(
                name: "tbl_repartitions_temp");

            migrationBuilder.DropTable(
                name: "tbl_requette_gateau_base");

            migrationBuilder.DropTable(
                name: "tbl_requette_ingredient");

            migrationBuilder.DropTable(
                name: "tbl_reservation_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_reservation_partenaire_temp");

            migrationBuilder.DropTable(
                name: "tbl_reste_ingredient");

            migrationBuilder.DropTable(
                name: "tbl_retour_client");

            migrationBuilder.DropTable(
                name: "tbl_stock_fini_ravitaillement");

            migrationBuilder.DropTable(
                name: "tbl_stock_gadget");

            migrationBuilder.DropTable(
                name: "tbl_stock_gateau");

            migrationBuilder.DropTable(
                name: "tbl_stock_gateau_base");

            migrationBuilder.DropTable(
                name: "tbl_stock_partenaires_filiale");

            migrationBuilder.DropTable(
                name: "tbl_synchro");

            migrationBuilder.DropTable(
                name: "tbl_synchro_date");

            migrationBuilder.DropTable(
                name: "tbl_synchro_stats");

            migrationBuilder.DropTable(
                name: "tbl_taille");

            migrationBuilder.DropTable(
                name: "tbl_taille_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_temp_achat");

            migrationBuilder.DropTable(
                name: "tbl_temp_commande");

            migrationBuilder.DropTable(
                name: "tbl_temp_usage");

            migrationBuilder.DropTable(
                name: "tbl_tempReserv");

            migrationBuilder.DropTable(
                name: "tbl_trans");

            migrationBuilder.DropTable(
                name: "tbl_Usage");

            migrationBuilder.DropTable(
                name: "tbl_usage_gadget");

            migrationBuilder.DropTable(
                name: "tbl_users_partenaires");

            migrationBuilder.DropTable(
                name: "tbl_vente");

            migrationBuilder.DropTable(
                name: "tbl_vente_partenaire");

            migrationBuilder.DropTable(
                name: "tbl_vente_partenaire_temp");

            migrationBuilder.DropTable(
                name: "tbl_vente_temp");

            migrationBuilder.DropTable(
                name: "temp_Reservation");

            migrationBuilder.DropTable(
                name: "tests");

            migrationBuilder.DropTable(
                name: "Gamme");

            migrationBuilder.DropTable(
                name: "Model");

            migrationBuilder.DropTable(
                name: "Taille");

            migrationBuilder.DropTable(
                name: "tbl_Users");

            migrationBuilder.DropTable(
                name: "Categorie");

            migrationBuilder.DropTable(
                name: "Marque");

            migrationBuilder.DropTable(
                name: "Style");
        }
    }
}
