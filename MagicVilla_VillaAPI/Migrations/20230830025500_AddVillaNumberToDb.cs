using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddVillaNumberToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VillaNumbers",
                columns: table => new
                {
                    VillaNum = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaNumbers", x => x.VillaNum);
                });

            migrationBuilder.InsertData(
                table: "VillaNumbers",
                columns: new[] { "VillaNum", "CreatedDate", "SpecialDetails", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 29, 19, 55, 0, 566, DateTimeKind.Local).AddTicks(8385), "None 1", new DateTime(2023, 8, 29, 19, 55, 0, 566, DateTimeKind.Local).AddTicks(8386) },
                    { 2, new DateTime(2023, 8, 29, 19, 55, 0, 566, DateTimeKind.Local).AddTicks(8388), "None 2", new DateTime(2023, 8, 29, 19, 55, 0, 566, DateTimeKind.Local).AddTicks(8389) },
                    { 3, new DateTime(2023, 8, 29, 19, 55, 0, 566, DateTimeKind.Local).AddTicks(8390), "None 3", new DateTime(2023, 8, 29, 19, 55, 0, 566, DateTimeKind.Local).AddTicks(8391) },
                    { 4, new DateTime(2023, 8, 29, 19, 55, 0, 566, DateTimeKind.Local).AddTicks(8393), "None 4", new DateTime(2023, 8, 29, 19, 55, 0, 566, DateTimeKind.Local).AddTicks(8394) },
                    { 5, new DateTime(2023, 8, 29, 19, 55, 0, 566, DateTimeKind.Local).AddTicks(8395), "None 5", new DateTime(2023, 8, 29, 19, 55, 0, 566, DateTimeKind.Local).AddTicks(8397) }
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 19, 55, 0, 566, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 19, 55, 0, 566, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 19, 55, 0, 566, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 19, 55, 0, 566, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 29, 19, 55, 0, 566, DateTimeKind.Local).AddTicks(8314));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaNumbers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 11, 45, 6, 782, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 11, 45, 6, 782, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 11, 45, 6, 782, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 11, 45, 6, 782, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 28, 11, 45, 6, 782, DateTimeKind.Local).AddTicks(633));
        }
    }
}
