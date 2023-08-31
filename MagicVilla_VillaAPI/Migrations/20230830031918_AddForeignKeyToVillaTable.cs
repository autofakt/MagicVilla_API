using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyToVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VillaID",
                table: "VillaNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNum",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate", "VillaID" },
                values: new object[] { new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(1990), new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2011), 0 });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNum",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate", "VillaID" },
                values: new object[] { new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2021), new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2027), 0 });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNum",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate", "VillaID" },
                values: new object[] { new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2036), new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2043), 0 });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNum",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate", "VillaID" },
                values: new object[] { new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2051), new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2057), 0 });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNum",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate", "VillaID" },
                values: new object[] { new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2066), new DateTime(2023, 8, 29, 20, 19, 18, 229, DateTimeKind.Local).AddTicks(2072), 0 });

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

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumbers",
                column: "VillaID");

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villas_VillaID",
                table: "VillaNumbers",
                column: "VillaID",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villas_VillaID",
                table: "VillaNumbers");

            migrationBuilder.DropIndex(
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumbers");

            migrationBuilder.DropColumn(
                name: "VillaID",
                table: "VillaNumbers");

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNum",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 29, 19, 55, 0, 566, DateTimeKind.Local).AddTicks(8385), new DateTime(2023, 8, 29, 19, 55, 0, 566, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNum",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 29, 19, 55, 0, 566, DateTimeKind.Local).AddTicks(8388), new DateTime(2023, 8, 29, 19, 55, 0, 566, DateTimeKind.Local).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNum",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 29, 19, 55, 0, 566, DateTimeKind.Local).AddTicks(8390), new DateTime(2023, 8, 29, 19, 55, 0, 566, DateTimeKind.Local).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNum",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 29, 19, 55, 0, 566, DateTimeKind.Local).AddTicks(8393), new DateTime(2023, 8, 29, 19, 55, 0, 566, DateTimeKind.Local).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNum",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 8, 29, 19, 55, 0, 566, DateTimeKind.Local).AddTicks(8395), new DateTime(2023, 8, 29, 19, 55, 0, 566, DateTimeKind.Local).AddTicks(8397) });

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
    }
}
