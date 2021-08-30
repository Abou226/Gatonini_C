using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class AddMoreTablesForCoordinations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Genre = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Commune",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    VilleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commune", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "Model",
            //    columns: table => new
            //    {
            //        ModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
            //        DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        CatégorieId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        Url = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //        ServerTime = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Model", x => x.ModelId);
            //    });

            migrationBuilder.CreateTable(
                name: "Num_Vente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Num_Vente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pays",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ContinentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quartier",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommuneId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ZoneId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quartier", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "Taille",
            //    columns: table => new
            //    {
            //        TailleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
            //        DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        ServerTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Taille", x => x.TailleId);
            //    });

            migrationBuilder.CreateTable(
                name: "Ville",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Pays = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ville", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zone",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zone", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Commande",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GammeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TailleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Quantité = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Prix_Vente_Unité = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuartierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Details_Adresse = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Heure_Livraison = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Date_Livraison = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServerTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumVenteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Mention = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Contact_Livraison = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Annulée = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commande", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commande_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Commande_Gamme_GammeId",
                        column: x => x.GammeId,
                        principalTable: "Gamme",
                        principalColumn: "GammeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Commande_Model_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Model",
                        principalColumn: "ModelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Commande_Num_Vente_NumVenteId",
                        column: x => x.NumVenteId,
                        principalTable: "Num_Vente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Commande_Quartier_QuartierId",
                        column: x => x.QuartierId,
                        principalTable: "Quartier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Commande_Taille_TailleId",
                        column: x => x.TailleId,
                        principalTable: "Taille",
                        principalColumn: "TailleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Commande_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Panier",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GammeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TailleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Quantité = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Prix_Vente_Unité = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuartierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Details_Adresse = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Heure_Livraison = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Date_Livraison = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServerTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mention = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Contact_Livraison = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Panier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Panier_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Panier_Gamme_GammeId",
                        column: x => x.GammeId,
                        principalTable: "Gamme",
                        principalColumn: "GammeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Panier_Model_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Model",
                        principalColumn: "ModelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Panier_Quartier_QuartierId",
                        column: x => x.QuartierId,
                        principalTable: "Quartier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Panier_Taille_TailleId",
                        column: x => x.TailleId,
                        principalTable: "Taille",
                        principalColumn: "TailleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Panier_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commande_ClientId",
                table: "Commande",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Commande_GammeId",
                table: "Commande",
                column: "GammeId");

            migrationBuilder.CreateIndex(
                name: "IX_Commande_ModelId",
                table: "Commande",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Commande_NumVenteId",
                table: "Commande",
                column: "NumVenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Commande_QuartierId",
                table: "Commande",
                column: "QuartierId");

            migrationBuilder.CreateIndex(
                name: "IX_Commande_TailleId",
                table: "Commande",
                column: "TailleId");

            migrationBuilder.CreateIndex(
                name: "IX_Commande_UserId",
                table: "Commande",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Panier_ClientId",
                table: "Panier",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Panier_GammeId",
                table: "Panier",
                column: "GammeId");

            migrationBuilder.CreateIndex(
                name: "IX_Panier_ModelId",
                table: "Panier",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Panier_QuartierId",
                table: "Panier",
                column: "QuartierId");

            migrationBuilder.CreateIndex(
                name: "IX_Panier_TailleId",
                table: "Panier",
                column: "TailleId");

            migrationBuilder.CreateIndex(
                name: "IX_Panier_UserId",
                table: "Panier",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commande");

            migrationBuilder.DropTable(
                name: "Commune");

            migrationBuilder.DropTable(
                name: "Panier");

            migrationBuilder.DropTable(
                name: "Pays");

            migrationBuilder.DropTable(
                name: "Ville");

            migrationBuilder.DropTable(
                name: "Zone");

            migrationBuilder.DropTable(
                name: "Num_Vente");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Model");

            migrationBuilder.DropTable(
                name: "Quartier");

            migrationBuilder.DropTable(
                name: "Taille");
        }
    }
}
