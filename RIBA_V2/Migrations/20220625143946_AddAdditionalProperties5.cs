using Microsoft.EntityFrameworkCore.Migrations;

namespace RIBA_V2.Migrations
{
    public partial class AddAdditionalProperties5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 8, 200 });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 40, 68 });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 32, 7 });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 105, 87 });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 61, 112 });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 100, 43 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 10, 5 });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 10, 12 });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 10, 5 });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 10, 5 });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 10, 5 });

            migrationBuilder.UpdateData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Quantity", "UnitPrice" },
                values: new object[] { 10, 5 });
        }
    }
}
