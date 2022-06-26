using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RIBA_V2.Migrations
{
    public partial class AddAdditionalProperties4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Maria" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Brian" });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "CustomerId", "DateTime", "OrderDescription", "TotalCost" },
                values: new object[] { 6, 1, new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Second Big Order For Jacob", 0 });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "CustomerId", "DateTime", "OrderDescription", "TotalCost" },
                values: new object[] { 4, 4, new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Big Order For Mam", 0 });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "CustomerId", "DateTime", "OrderDescription", "TotalCost" },
                values: new object[] { 5, 5, new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Big Order For Dad", 0 });

            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "Id", "ItemName", "OrderId", "Quantity", "UnitPrice" },
                values: new object[] { 6, "Wood", 6, 10, 5 });

            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "Id", "ItemName", "OrderId", "Quantity", "UnitPrice" },
                values: new object[] { 4, "Wool", 4, 10, 5 });

            migrationBuilder.InsertData(
                table: "OrderItem",
                columns: new[] { "Id", "ItemName", "OrderId", "Quantity", "UnitPrice" },
                values: new object[] { 5, "Wool", 5, 10, 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderItem",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
