using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class ChangeImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductImageTest",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "ProductImage");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ProductImage");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "ProductImage",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "ProductImage");

            migrationBuilder.AddColumn<byte[]>(
                name: "ProductImageTest",
                table: "Products",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "ProductImage",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ProductImage",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
