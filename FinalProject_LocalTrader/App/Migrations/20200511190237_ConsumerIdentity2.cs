using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class ConsumerIdentity2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressModel_AspNetUsers_ConsumerId",
                table: "AddressModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ProducerModel_AddressModel_AddressId",
                table: "ProducerModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AddressModel",
                table: "AddressModel");

            migrationBuilder.RenameTable(
                name: "AddressModel",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_AddressModel_ConsumerId",
                table: "Addresses",
                newName: "IX_Addresses_ConsumerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_AspNetUsers_ConsumerId",
                table: "Addresses",
                column: "ConsumerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProducerModel_Addresses_AddressId",
                table: "ProducerModel",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_AspNetUsers_ConsumerId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_ProducerModel_Addresses_AddressId",
                table: "ProducerModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "AddressModel");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_ConsumerId",
                table: "AddressModel",
                newName: "IX_AddressModel_ConsumerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AddressModel",
                table: "AddressModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressModel_AspNetUsers_ConsumerId",
                table: "AddressModel",
                column: "ConsumerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProducerModel_AddressModel_AddressId",
                table: "ProducerModel",
                column: "AddressId",
                principalTable: "AddressModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
