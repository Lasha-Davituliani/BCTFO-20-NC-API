using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Todo.Data.Migrations
{
    /// <inheritdoc />
    public partial class Mymigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8716071C-1D9B-48FD-B3D0-F059C4FB8031",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a36e1aa-3816-48c2-b5de-729129973002", "AQAAAAIAAYagAAAAEEFDPyx7DGuENc09rLjDGZgqnCnUFSWkrMxhAHiLZHf9CGqNn/uCVtUQZdIQ0SiGmw==", "3f4fadad-6735-4411-bac8-2811dddf8a23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87746F88-DC38-4756-924A-B95CFF3A1D8A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6433f363-2765-48a4-83d7-f0adcf2a4629", "AQAAAAIAAYagAAAAELm0pvWSZ1YEwNI9yycbCKSFtuFnSynjuAc+2kc3U72m4JsWtlRw/MHpKqk/aSWsKA==", "f2f020cd-37f8-4ecc-8ef8-6db1cbb0d8a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D514EDC9-94BB-416F-AF9D-7C13669689C9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c20d3b10-33a3-4ab7-abea-35b8ac1b6564", "AQAAAAIAAYagAAAAEMT7umS3QKcKiodRmCxGBjveE/P3Fs8Vz6ryZVdAadyrVixCixbkBn4+pDEtir0G1Q==", "44f3cdaa-97ca-42f4-9daf-a274da1f02c3" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 10, 1, 36, 21, 951, DateTimeKind.Local).AddTicks(1160), new DateTime(2024, 5, 10, 0, 36, 21, 951, DateTimeKind.Local).AddTicks(1159) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 10, 1, 36, 21, 951, DateTimeKind.Local).AddTicks(1171), new DateTime(2024, 5, 10, 0, 36, 21, 951, DateTimeKind.Local).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 10, 5, 36, 21, 951, DateTimeKind.Local).AddTicks(1176), new DateTime(2024, 5, 10, 0, 36, 21, 951, DateTimeKind.Local).AddTicks(1175) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 17, 0, 36, 21, 951, DateTimeKind.Local).AddTicks(1180), new DateTime(2024, 5, 10, 0, 36, 21, 951, DateTimeKind.Local).AddTicks(1179) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 0, 36, 21, 951, DateTimeKind.Local).AddTicks(1185), new DateTime(2024, 5, 10, 0, 36, 21, 951, DateTimeKind.Local).AddTicks(1184) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 36, 21, 951, DateTimeKind.Local).AddTicks(1188), new DateTime(2024, 5, 10, 0, 36, 21, 951, DateTimeKind.Local).AddTicks(1188) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8716071C-1D9B-48FD-B3D0-F059C4FB8031",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21362261-f7e1-403a-a243-c20607d5e458", "AQAAAAIAAYagAAAAEB+DOlnXJw4+CRGNXCRtCo2TkC88fy4W+KNgCwc0XWp/CpMWi35byktv2nhmcvrW7g==", "094ccabf-1769-4d67-b069-3c4c5b10fa9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87746F88-DC38-4756-924A-B95CFF3A1D8A",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7da1f75b-3866-478c-ab27-b1ba84f52284", "AQAAAAIAAYagAAAAEIlN2jYx+24bIVnao4Zl/QEbIYxylm/hzWo1mmy4szrqj6iWtQlGdHT3heOBg78xUg==", "7bb4f2d3-586e-4657-85af-9263d17c60a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D514EDC9-94BB-416F-AF9D-7C13669689C9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61fb9a8d-9c4a-44a8-b0eb-0f55c03336d0", "AQAAAAIAAYagAAAAEC0T7apK66v/ayi3NNTij8o8/dd02S9K8ojP6qEQMp75huYPgQVAkRtY4ClgIWnQYA==", "9d796298-9743-4c63-a334-f10958ea7f15" });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 17, 6, 39, 936, DateTimeKind.Local).AddTicks(2137), new DateTime(2024, 5, 7, 16, 6, 39, 936, DateTimeKind.Local).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 17, 6, 39, 936, DateTimeKind.Local).AddTicks(2144), new DateTime(2024, 5, 7, 16, 6, 39, 936, DateTimeKind.Local).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 21, 6, 39, 936, DateTimeKind.Local).AddTicks(2146), new DateTime(2024, 5, 7, 16, 6, 39, 936, DateTimeKind.Local).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 6, 39, 936, DateTimeKind.Local).AddTicks(2148), new DateTime(2024, 5, 7, 16, 6, 39, 936, DateTimeKind.Local).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 6, 39, 936, DateTimeKind.Local).AddTicks(2152), new DateTime(2024, 5, 7, 16, 6, 39, 936, DateTimeKind.Local).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 17, 16, 6, 39, 936, DateTimeKind.Local).AddTicks(2154), new DateTime(2024, 5, 7, 16, 6, 39, 936, DateTimeKind.Local).AddTicks(2154) });
        }
    }
}
