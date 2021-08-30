using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class AddStyleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Style");
        }
    }
}
