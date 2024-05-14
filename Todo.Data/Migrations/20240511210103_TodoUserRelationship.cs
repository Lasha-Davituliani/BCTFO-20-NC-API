using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Todo.Data.Migrations
{
    /// <inheritdoc />
    public partial class TodoUserRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descrtiption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Todos_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "33B7ED72-9434-434A-82D4-3018B018CB87", null, "Admin", "ADMIN" },
                    { "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8716071C-1D9B-48FD-B3D0-F059C4FB8031", 0, "88c85038-eb9d-445c-8760-fd5c89d49c42", "admin@gmail.com", false, true, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEHDXWHz8u6CIYJgyXHk6E6x1ZnWpGca5FvhqdIA9e3SwLN1gNOaxT29yqJHJIyzYpQ==", "555337681", false, "0eb57519-0c01-4491-b0a9-417146f3c5cb", false, "admin@gmail.com" },
                    { "87746F88-DC38-4756-924A-B95CFF3A1D8A", 0, "1799cc55-cadf-4018-86dc-aaed85004c91", "gio@gmail.com", false, true, null, "GIO@GMAIL.COM", "GIO@GMAIL.COM", "AQAAAAIAAYagAAAAENDF+RlG0kBOPkl7OmZSmZcNcP0vq1E93+dX+P3R4FI1R2Ry1+2mLSaOWheR1v4YRg==", "551442269", false, "595d2243-9d89-464f-b92e-899eaca32ffc", false, "gio@gmail.com" },
                    { "D514EDC9-94BB-416F-AF9D-7C13669689C9", 0, "b3d8daf2-9180-4402-98bb-343e89666e9d", "nika@gmail.com", false, true, null, "NIKA@GMAIL.COM", "NIKA@GMAIL.COM", "AQAAAAIAAYagAAAAEIGauBVoWN/Bk+vmcgcjv4bmhOejivL4NcbzcBpulrxNHgNWPad4FN0mHHxSOmyyJw==", "558490645", false, "f2bfa1c6-b2cc-4199-80fc-3d66d5a83942", false, "nika@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "33B7ED72-9434-434A-82D4-3018B018CB87", "8716071C-1D9B-48FD-B3D0-F059C4FB8031" },
                    { "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B", "87746F88-DC38-4756-924A-B95CFF3A1D8A" },
                    { "9C07F9F6-D3B0-458A-AB7F-218AA622FA5B", "D514EDC9-94BB-416F-AF9D-7C13669689C9" }
                });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Descrtiption", "EndDate", "Priority", "StartDate", "Status", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "პირველი საქმის აღწერა...", new DateTime(2024, 5, 12, 2, 1, 3, 8, DateTimeKind.Local).AddTicks(1395), 2, new DateTime(2024, 5, 12, 1, 1, 3, 8, DateTimeKind.Local).AddTicks(1394), 1, "პირველი საქმე", "87746F88-DC38-4756-924A-B95CFF3A1D8A" },
                    { 2, "მეორე საქმის აღწერა...", new DateTime(2024, 5, 12, 2, 1, 3, 8, DateTimeKind.Local).AddTicks(1402), 1, new DateTime(2024, 5, 12, 1, 1, 3, 8, DateTimeKind.Local).AddTicks(1401), 1, "მეორე საქმე", "D514EDC9-94BB-416F-AF9D-7C13669689C9" },
                    { 3, "მესამე საქმის აღწერა...", new DateTime(2024, 5, 12, 6, 1, 3, 8, DateTimeKind.Local).AddTicks(1405), 4, new DateTime(2024, 5, 12, 1, 1, 3, 8, DateTimeKind.Local).AddTicks(1404), 2, "მესამე საქმე", "D514EDC9-94BB-416F-AF9D-7C13669689C9" },
                    { 4, "მეოთხე საქმის აღწერა...", new DateTime(2024, 5, 19, 1, 1, 3, 8, DateTimeKind.Local).AddTicks(1407), 1, new DateTime(2024, 5, 12, 1, 1, 3, 8, DateTimeKind.Local).AddTicks(1407), 1, "მეოთხე საქმე", "87746F88-DC38-4756-924A-B95CFF3A1D8A" },
                    { 5, "მეხუთე საქმის აღწერა...", new DateTime(2024, 5, 15, 1, 1, 3, 8, DateTimeKind.Local).AddTicks(1411), 3, new DateTime(2024, 5, 12, 1, 1, 3, 8, DateTimeKind.Local).AddTicks(1410), 1, "მეხუთე საქმე", "87746F88-DC38-4756-924A-B95CFF3A1D8A" },
                    { 6, "მეექვსე საქმის აღწერა...", new DateTime(2024, 5, 22, 1, 1, 3, 8, DateTimeKind.Local).AddTicks(1413), 2, new DateTime(2024, 5, 12, 1, 1, 3, 8, DateTimeKind.Local).AddTicks(1413), 2, "მეექვსე საქმე", "87746F88-DC38-4756-924A-B95CFF3A1D8A" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Todos_UserId",
                table: "Todos",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Todos");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
