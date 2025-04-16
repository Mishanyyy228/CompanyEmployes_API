using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyEmployes.Migrations
{
    /// <inheritdoc />
    public partial class NewMigrationNam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "0a5fd413-d80b-4673-a008-ea52b5c71c1e", null, "Administrator", "ADMINISTRATOR" },
                    { "7b2144ac-f008-4a73-8663-b20186b4ca63", null, "Manager", "MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "3d86e294-a67c-4cd3-a5fd-018df9c868f8", null, "Manager", "MANAGER" },
                    { "4dedbd2f-ae2c-4cd9-9ed6-f0067c8aaa4e", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
