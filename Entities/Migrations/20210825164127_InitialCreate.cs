using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "ExternalLogin",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Provider = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
            //        UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        DateOfLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Token = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ExternalLogin", x => x.Id);
            //    });

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfIssue = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfExpiry = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Refreshable = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "User",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Username = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
            //        Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ServerTime = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Prenom = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
            //        Nom = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
            //        Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        Url = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_User", x => x.Id);
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExternalLogin");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
