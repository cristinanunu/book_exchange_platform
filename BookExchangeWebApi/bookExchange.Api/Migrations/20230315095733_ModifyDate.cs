using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bookExchange.Api.Migrations
{
    /// <inheritdoc />
    public partial class ModifyDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedAt",
                table: "Book",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name" },
                values: new object[] { "KiarraCormier_Rippin25@hotmail.com", "Kiarra Cormier" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name" },
                values: new object[] { "MikeKoss35@gmail.com", "Mike Koss" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name" },
                values: new object[] { "JulioLegros19@gmail.com", "Julio Legros" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Name" },
                values: new object[] { "ElyssaRomaguera86@gmail.com", "Elyssa Romaguera" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Name" },
                values: new object[] { "AdolphusGreenholt_Hoppe11@hotmail.com", "Adolphus Greenholt" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "Name" },
                values: new object[] { "AndyPredovic55@hotmail.com", "Andy Predovic" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Email", "Name" },
                values: new object[] { "MathewRoberts.Watsica94@hotmail.com", "Mathew Roberts" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Email", "Name" },
                values: new object[] { "MargarettLangworth.Haag@hotmail.com", "Margarett Langworth" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Email", "Name" },
                values: new object[] { "EldoraBailey.Konopelski23@yahoo.com", "Eldora Bailey" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Email", "Name" },
                values: new object[] { "AhmadHartmann71@yahoo.com", "Ahmad Hartmann" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedAt",
                table: "Book",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name" },
                values: new object[] { "KenyattaNolan42@gmail.com", "Kenyatta Nolan" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name" },
                values: new object[] { "FedericoHyatt.Skiles@hotmail.com", "Federico Hyatt" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Name" },
                values: new object[] { "DiamondKris.Russel@yahoo.com", "Diamond Kris" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Name" },
                values: new object[] { "BaileyKreiger64@yahoo.com", "Bailey Kreiger" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "Name" },
                values: new object[] { "HilbertFerry.Metz@yahoo.com", "Hilbert Ferry" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Email", "Name" },
                values: new object[] { "JoelProsacco58@hotmail.com", "Joel Prosacco" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Email", "Name" },
                values: new object[] { "DoyleAbbott10@hotmail.com", "Doyle Abbott" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Email", "Name" },
                values: new object[] { "ZettaBatz.Hahn71@gmail.com", "Zetta Batz" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Email", "Name" },
                values: new object[] { "DomenicaPollich_Jacobson@hotmail.com", "Domenica Pollich" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Email", "Name" },
                values: new object[] { "MyaBechtelar0@hotmail.com", "Mya Bechtelar" });
        }
    }
}
