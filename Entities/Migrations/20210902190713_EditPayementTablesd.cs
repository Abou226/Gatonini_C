using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class EditPayementTablesd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
