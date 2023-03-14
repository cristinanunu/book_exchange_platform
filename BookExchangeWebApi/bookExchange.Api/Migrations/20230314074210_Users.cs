using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace bookExchange.Api.Migrations
{
    /// <inheritdoc />
    public partial class Users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "KenyattaNolan42@gmail.com", "Kenyatta Nolan" },
                    { 2, "FedericoHyatt.Skiles@hotmail.com", "Federico Hyatt" },
                    { 3, "DiamondKris.Russel@yahoo.com", "Diamond Kris" },
                    { 4, "BaileyKreiger64@yahoo.com", "Bailey Kreiger" },
                    { 5, "HilbertFerry.Metz@yahoo.com", "Hilbert Ferry" },
                    { 6, "JoelProsacco58@hotmail.com", "Joel Prosacco" },
                    { 7, "DoyleAbbott10@hotmail.com", "Doyle Abbott" },
                    { 8, "ZettaBatz.Hahn71@gmail.com", "Zetta Batz" },
                    { 9, "DomenicaPollich_Jacobson@hotmail.com", "Domenica Pollich" },
                    { 10, "MyaBechtelar0@hotmail.com", "Mya Bechtelar" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
