using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class FirtsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    categoryId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    categoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "warehouses",
                columns: table => new
                {
                    warehouseId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    warehouseName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    warehouseAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_warehouses", x => x.warehouseId);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    productId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    productName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    productDescription = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    totalQuantity = table.Column<int>(type: "int", nullable: false),
                    categoryId = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.productId);
                    table.ForeignKey(
                        name: "FK_products_categories_categoryId",
                        column: x => x.categoryId,
                        principalTable: "categories",
                        principalColumn: "categoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "storages",
                columns: table => new
                {
                    storegeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    lastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    partialQuantity = table.Column<int>(type: "int", nullable: false),
                    productId = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    warehouseId = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_storages", x => x.storegeId);
                    table.ForeignKey(
                        name: "FK_storages_products_productId",
                        column: x => x.productId,
                        principalTable: "products",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_storages_warehouses_warehouseId",
                        column: x => x.warehouseId,
                        principalTable: "warehouses",
                        principalColumn: "warehouseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "inOuts",
                columns: table => new
                {
                    inOutId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    inOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    isInput = table.Column<bool>(type: "bit", nullable: false),
                    storegeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    storagestoregeId = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inOuts", x => x.inOutId);
                    table.ForeignKey(
                        name: "FK_inOuts_storages_storagestoregeId",
                        column: x => x.storagestoregeId,
                        principalTable: "storages",
                        principalColumn: "storegeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_inOuts_storagestoregeId",
                table: "inOuts",
                column: "storagestoregeId");

            migrationBuilder.CreateIndex(
                name: "IX_products_categoryId",
                table: "products",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_storages_productId",
                table: "storages",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_storages_warehouseId",
                table: "storages",
                column: "warehouseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "inOuts");

            migrationBuilder.DropTable(
                name: "storages");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "warehouses");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
