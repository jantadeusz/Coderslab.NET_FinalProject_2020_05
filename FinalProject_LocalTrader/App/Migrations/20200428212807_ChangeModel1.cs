using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class ChangeModel1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderTime",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "ProductQuantity",
                table: "ProductOrders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderEnd",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderStart",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductQuantity",
                table: "ProductOrders");

            migrationBuilder.DropColumn(
                name: "OrderEnd",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderStart",
                table: "Orders");

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
