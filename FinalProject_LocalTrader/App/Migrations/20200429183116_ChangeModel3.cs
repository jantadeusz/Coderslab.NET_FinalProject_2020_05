using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class ChangeModel3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProductsOrders_OrderID",
                table: "ProductsOrders");

            migrationBuilder.DropIndex(
                name: "IX_ProductsOrders_ProductID",
                table: "ProductsOrders");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsOrders_OrderID",
                table: "ProductsOrders",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsOrders_ProductID",
                table: "ProductsOrders",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProductsOrders_OrderID",
                table: "ProductsOrders");

            migrationBuilder.DropIndex(
                name: "IX_ProductsOrders_ProductID",
                table: "ProductsOrders");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsOrders_OrderID",
                table: "ProductsOrders",
                column: "OrderID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductsOrders_ProductID",
                table: "ProductsOrders",
                column: "ProductID",
                unique: true);
        }
    }
}
