using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConsumerModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nick = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumerModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AddressModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Longitude = table.Column<string>(nullable: false),
                    Latitude = table.Column<string>(nullable: false),
                    Elevation = table.Column<decimal>(nullable: false),
                    ConsumerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddressModel_ConsumerModel_ConsumerId",
                        column: x => x.ConsumerId,
                        principalTable: "ConsumerModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(nullable: true),
                    ConsumerId = table.Column<int>(nullable: true),
                    OrderTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_ConsumerModel_ConsumerId",
                        column: x => x.ConsumerId,
                        principalTable: "ConsumerModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProducerModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    AddressId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProducerModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProducerModel_AddressModel_AddressId",
                        column: x => x.AddressId,
                        principalTable: "AddressModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProducerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_CategoryModel_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "CategoryModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProducerModel_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "ProducerModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductOrders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(nullable: false),
                    OrderID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductOrders_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductOrders_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressModel_ConsumerId",
                table: "AddressModel",
                column: "ConsumerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ConsumerId",
                table: "Orders",
                column: "ConsumerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProducerModel_AddressId",
                table: "ProducerModel",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_OrderID",
                table: "ProductOrders",
                column: "OrderID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_ProductID",
                table: "ProductOrders",
                column: "ProductID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProducerId",
                table: "Products",
                column: "ProducerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductOrders");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "CategoryModel");

            migrationBuilder.DropTable(
                name: "ProducerModel");

            migrationBuilder.DropTable(
                name: "AddressModel");

            migrationBuilder.DropTable(
                name: "ConsumerModel");
        }
    }
}
