using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyEmployes.Migrations
{
    /// <inheritdoc />
    public partial class AddedRolesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "3d86e294-a67c-4cd3-a5fd-018df9c868f8", null, "Manager", "MANAGER" },
                    { "4dedbd2f-ae2c-4cd9-9ed6-f0067c8aaa4e", null, "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d86e294-a67c-4cd3-a5fd-018df9c868f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4dedbd2f-ae2c-4cd9-9ed6-f0067c8aaa4e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "807b9679-347b-4c0b-9eb8-2d2360318259", null, "Administrator", "ADMINISTRATOR" },
                    { "a7e2ac39-6ee1-42fe-855d-53fd5b04f4b9", null, "Manager", "MANAGER" }
                });
        }
    }
}
