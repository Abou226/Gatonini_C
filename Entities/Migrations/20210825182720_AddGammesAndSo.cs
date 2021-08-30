using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class AddGammesAndSo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Categories",
            //    columns: table => new
            //    {
            //        CategorieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
            //        DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Url = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        ServerTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UserId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Categories", x => x.CategorieId);
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
            //            name: "FK_Gamme_Categories_CategorieId",
            //            column: x => x.CategorieId,
            //            principalTable: "Categories",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gamme");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
