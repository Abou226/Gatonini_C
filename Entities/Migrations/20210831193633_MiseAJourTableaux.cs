using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class MiseAJourTableaux : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<string>(
            //    name: "Url",
            //    table: "User",
            //    type: "nvarchar(max)",
            //    nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "User");
        }
    }
}
