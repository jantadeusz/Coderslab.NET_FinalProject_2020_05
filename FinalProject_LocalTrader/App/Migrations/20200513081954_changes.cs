using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_CategoryModel_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProducerModel_ProducerId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProducerModel");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProducerId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryModel",
                table: "CategoryModel");

            migrationBuilder.DropColumn(
                name: "ProducerId",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "CategoryModel",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "CategoryModel");

            migrationBuilder.AddColumn<int>(
                name: "ProducerId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryModel",
                table: "CategoryModel",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ProducerModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProducerModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProducerModel_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProducerId",
                table: "Products",
                column: "ProducerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProducerModel_AddressId",
                table: "ProducerModel",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CategoryModel_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "CategoryModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProducerModel_ProducerId",
                table: "Products",
                column: "ProducerId",
                principalTable: "ProducerModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
