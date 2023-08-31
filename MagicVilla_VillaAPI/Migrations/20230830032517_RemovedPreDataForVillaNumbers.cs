using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class RemovedPreDataForVillaNumbers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNum",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNum",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNum",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNum",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNum",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 20, 25, 17, 440, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 20, 25, 17, 440, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 20, 25, 17, 440, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 20, 25, 17, 440, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 20, 25, 17, 440, DateTimeKind.Local).AddTicks(9368));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VillaNumbers",
                columns: new[] { "VillaNum", "CreatedDate", "SpecialDetails", "UpdatedDate", "VillaID" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(1990), "None 1", new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2011), 0 },
                    { 2, new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2021), "None 2", new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2027), 0 },
                    { 3, new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2036), "None 3", new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2043), 0 },
                    { 4, new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2051), "None 4", new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2057), 0 },
                    { 5, new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2066), "None 5", new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2072), 0 }
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(1258));
        }
    }
}
