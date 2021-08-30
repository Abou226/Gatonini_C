using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class AddMoreTablesForCoordination : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterColumn<byte[]>(
            //    name: "Image",
            //    table: "Reservation",
            //    type: "varbinary(max)",
            //    nullable: true,
            //    oldClrType: typeof(byte),
            //    oldType: "tinyint",
            //    oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Image",
                table: "Reservation",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);
        }
    }
}
