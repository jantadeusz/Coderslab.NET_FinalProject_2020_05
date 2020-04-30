using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class ChangeModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductOrders_Orders_OrderID",
                table: "ProductOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductOrders_Products_ProductID",
                table: "ProductOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductOrders",
                table: "ProductOrders");

            migrationBuilder.RenameTable(
                name: "ProductOrders",
                newName: "ProductsOrders");

            migrationBuilder.RenameIndex(
                name: "IX_ProductOrders_ProductID",
                table: "ProductsOrders",
                newName: "IX_ProductsOrders_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductOrders_OrderID",
                table: "ProductsOrders",
                newName: "IX_ProductsOrders_OrderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsOrders",
                table: "ProductsOrders",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsOrders_Orders_OrderID",
                table: "ProductsOrders",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsOrders_Products_ProductID",
                table: "ProductsOrders",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsOrders_Orders_OrderID",
                table: "ProductsOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsOrders_Products_ProductID",
                table: "ProductsOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsOrders",
                table: "ProductsOrders");

            migrationBuilder.RenameTable(
                name: "ProductsOrders",
                newName: "ProductOrders");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsOrders_ProductID",
                table: "ProductOrders",
                newName: "IX_ProductOrders_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsOrders_OrderID",
                table: "ProductOrders",
                newName: "IX_ProductOrders_OrderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductOrders",
                table: "ProductOrders",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOrders_Orders_OrderID",
                table: "ProductOrders",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOrders_Products_ProductID",
                table: "ProductOrders",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
