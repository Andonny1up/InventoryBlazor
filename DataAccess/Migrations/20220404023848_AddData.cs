using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "categoryId", "categoryName" },
                values: new object[,]
                {
                    { "ASH", "Aseo Hogar" },
                    { "ASP", "Aseo Personal" },
                    { "HGR", "Hogar" },
                    { "SLD", "Salud" }
                });

            migrationBuilder.InsertData(
                table: "warehouses",
                columns: new[] { "warehouseId", "warehouseAddress", "warehouseName" },
                values: new object[,]
                {
                    { "4219cb30-65a4-4514-a62f-57e3b51caed2", "Calle Norte con oriente", "Bodega Norte" },
                    { "a1e46b78-a78d-4ed8-b181-bef446d86252", "Calle sur con este", "Bodega Sur" },
                    { "c7f6d9ab-7df8-43c1-aa56-b0178b278bfe", "Calle 8 con 23", "Bodega Central" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "categoryId",
                keyValue: "ASH");

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "categoryId",
                keyValue: "ASP");

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "categoryId",
                keyValue: "HGR");

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "categoryId",
                keyValue: "SLD");

            migrationBuilder.DeleteData(
                table: "warehouses",
                keyColumn: "warehouseId",
                keyValue: "4219cb30-65a4-4514-a62f-57e3b51caed2");

            migrationBuilder.DeleteData(
                table: "warehouses",
                keyColumn: "warehouseId",
                keyValue: "a1e46b78-a78d-4ed8-b181-bef446d86252");

            migrationBuilder.DeleteData(
                table: "warehouses",
                keyColumn: "warehouseId",
                keyValue: "c7f6d9ab-7df8-43c1-aa56-b0178b278bfe");
        }
    }
}
