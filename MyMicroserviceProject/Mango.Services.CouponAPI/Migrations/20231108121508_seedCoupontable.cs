using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mango.Services.CouponAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedCoupontable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Coupones",
                columns: new[] { "CouponId", "CouponCode", "DiscountAmount", "MinAmount" },
                values: new object[,]
                {
                    { 1, "1000A", 100.0, 500 },
                    { 2, "1000B", 10.0, 50 },
                    { 3, "1000C", 150.0, 500 },
                    { 4, "1000D", 140.0, 200 },
                    { 5, "1000E", 10.0, 50 },
                    { 6, "1000F", 180.0, 350 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coupones",
                keyColumn: "CouponId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coupones",
                keyColumn: "CouponId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Coupones",
                keyColumn: "CouponId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Coupones",
                keyColumn: "CouponId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Coupones",
                keyColumn: "CouponId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Coupones",
                keyColumn: "CouponId",
                keyValue: 6);
        }
    }
}
