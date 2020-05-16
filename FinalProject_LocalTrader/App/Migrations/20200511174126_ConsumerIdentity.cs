using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class ConsumerIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressModel_ConsumerModel_ConsumerId",
                table: "AddressModel");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ConsumerModel_ConsumerId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "ConsumerModel");

            migrationBuilder.DropIndex(
                name: "IX_AddressModel_ConsumerId",
                table: "AddressModel");

            migrationBuilder.AlterColumn<string>(
                name: "ConsumerId",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "ConsumerId",
                table: "AddressModel",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_AddressModel_ConsumerId",
                table: "AddressModel",
                column: "ConsumerId",
                unique: true,
                filter: "[ConsumerId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressModel_AspNetUsers_ConsumerId",
                table: "AddressModel",
                column: "ConsumerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_ConsumerId",
                table: "Orders",
                column: "ConsumerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressModel_AspNetUsers_ConsumerId",
                table: "AddressModel");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_ConsumerId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_AddressModel_ConsumerId",
                table: "AddressModel");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "ConsumerId",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ConsumerId",
                table: "AddressModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ConsumerModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nick = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumerModel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressModel_ConsumerId",
                table: "AddressModel",
                column: "ConsumerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AddressModel_ConsumerModel_ConsumerId",
                table: "AddressModel",
                column: "ConsumerId",
                principalTable: "ConsumerModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ConsumerModel_ConsumerId",
                table: "Orders",
                column: "ConsumerId",
                principalTable: "ConsumerModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
