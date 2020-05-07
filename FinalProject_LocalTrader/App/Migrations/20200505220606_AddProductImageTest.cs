using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class AddProductImageTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImageModel_Products_ProductId",
                table: "ProductImageModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImageModel",
                table: "ProductImageModel");

            migrationBuilder.RenameTable(
                name: "ProductImageModel",
                newName: "ProductImage");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImageModel_ProductId",
                table: "ProductImage",
                newName: "IX_ProductImage_ProductId");

            migrationBuilder.AddColumn<byte[]>(
                name: "ProductImageTest",
                table: "Products",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImage",
                table: "ProductImage",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImage_Products_ProductId",
                table: "ProductImage",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImage_Products_ProductId",
                table: "ProductImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImage",
                table: "ProductImage");

            migrationBuilder.DropColumn(
                name: "ProductImageTest",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "ProductImage",
                newName: "ProductImageModel");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImage_ProductId",
                table: "ProductImageModel",
                newName: "IX_ProductImageModel_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImageModel",
                table: "ProductImageModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImageModel_Products_ProductId",
                table: "ProductImageModel",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
