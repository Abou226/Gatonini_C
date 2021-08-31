using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class EditPayementTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mode_Payement",
                table: "Payement");

            migrationBuilder.AddColumn<Guid>(
                name: "Mode_PayementId",
                table: "Payement",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payement_Mode_PayementId",
                table: "Payement",
                column: "Mode_PayementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payement_Mode_Payement_Mode_PayementId",
                table: "Payement",
                column: "Mode_PayementId",
                principalTable: "Mode_Payement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payement_Mode_Payement_Mode_PayementId",
                table: "Payement");

            migrationBuilder.DropIndex(
                name: "IX_Payement_Mode_PayementId",
                table: "Payement");

            migrationBuilder.DropColumn(
                name: "Mode_PayementId",
                table: "Payement");

            migrationBuilder.AddColumn<string>(
                name: "Mode_Payement",
                table: "Payement",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
