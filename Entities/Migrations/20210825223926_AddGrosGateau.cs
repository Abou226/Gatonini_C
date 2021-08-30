using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class AddGrosGateau : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.RenameColumn(
            //    name: "NumClient",
            //    table: "Reservation",
            //    newName: "Num_Client");

            //migrationBuilder.RenameColumn(
            //    name: "Num2Client",
            //    table: "Reservation",
            //    newName: "Num2_Client");

            //migrationBuilder.RenameColumn(
            //    name: "MentionSurGateau",
            //    table: "Reservation",
            //    newName: "Mention_Sur_Gateau");

            //migrationBuilder.RenameColumn(
            //    name: "HeureLivraison",
            //    table: "Reservation",
            //    newName: "Heure_Livraison");

            //migrationBuilder.RenameColumn(
            //    name: "GenreClient",
            //    table: "Reservation",
            //    newName: "Genre_Client");

            //migrationBuilder.RenameColumn(
            //    name: "GateauPour",
            //    table: "Reservation",
            //    newName: "Gateau_Pour");

            //migrationBuilder.RenameColumn(
            //    name: "DeptAuteur",
            //    table: "Reservation",
            //    newName: "Dept_Auteur");

            //migrationBuilder.RenameColumn(
            //    name: "DateLivraison",
            //    table: "Reservation",
            //    newName: "Date_Livraison");

            //migrationBuilder.RenameColumn(
            //    name: "AdresseLivraison",
            //    table: "Reservation",
            //    newName: "Adresse_Livraison");

            //migrationBuilder.AlterColumn<string>(
            //    name: "Gateau",
            //    table: "Reservation",
            //    type: "Varchar(50)",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<string>(
            //    name: "Description",
            //    table: "Reservation",
            //    type: "Varchar(100)",
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "nvarchar(max)",
            //    oldNullable: true);

            //migrationBuilder.CreateTable(
            //    name: "tbl_gros_gateau",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Date_Ajout = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Auteur = table.Column<string>(type: "Varchar(150)", nullable: true),
            //        Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Categorie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_tbl_gros_gateau", x => x.Id);
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_gros_gateau");

            migrationBuilder.RenameColumn(
                name: "Num_Client",
                table: "Reservation",
                newName: "NumClient");

            migrationBuilder.RenameColumn(
                name: "Num2_Client",
                table: "Reservation",
                newName: "Num2Client");

            migrationBuilder.RenameColumn(
                name: "Mention_Sur_Gateau",
                table: "Reservation",
                newName: "MentionSurGateau");

            migrationBuilder.RenameColumn(
                name: "Heure_Livraison",
                table: "Reservation",
                newName: "HeureLivraison");

            migrationBuilder.RenameColumn(
                name: "Genre_Client",
                table: "Reservation",
                newName: "GenreClient");

            migrationBuilder.RenameColumn(
                name: "Gateau_Pour",
                table: "Reservation",
                newName: "GateauPour");

            migrationBuilder.RenameColumn(
                name: "Dept_Auteur",
                table: "Reservation",
                newName: "DeptAuteur");

            migrationBuilder.RenameColumn(
                name: "Date_Livraison",
                table: "Reservation",
                newName: "DateLivraison");

            migrationBuilder.RenameColumn(
                name: "Adresse_Livraison",
                table: "Reservation",
                newName: "AdresseLivraison");

            migrationBuilder.AlterColumn<string>(
                name: "Gateau",
                table: "Reservation",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Reservation",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(100)",
                oldNullable: true);
        }
    }
}
