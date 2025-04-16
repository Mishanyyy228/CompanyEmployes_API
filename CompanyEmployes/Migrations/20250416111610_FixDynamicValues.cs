using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyEmployes.Migrations
{
    /// <inheritdoc />
    public partial class FixDynamicValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a5fd413-d80b-4673-a008-ea52b5c71c1e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b2144ac-f008-4a73-8663-b20186b4ca63");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "807b9679-347b-4c0b-9eb8-2d2360318259", null, "Administrator", "ADMINISTRATOR" },
                    { "a7e2ac39-6ee1-42fe-855d-53fd5b04f4b9", null, "Manager", "MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "807b9679-347b-4c0b-9eb8-2d2360318259");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7e2ac39-6ee1-42fe-855d-53fd5b04f4b9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a5fd413-d80b-4673-a008-ea52b5c71c1e", null, "Administrator", "ADMINISTRATOR" },
                    { "7b2144ac-f008-4a73-8663-b20186b4ca63", null, "Manager", "MANAGER" }
                });
        }
    }
}
