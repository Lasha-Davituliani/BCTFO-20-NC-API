using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Todo.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                    LastActivity = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastActivity", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8716071C-1D9B-48FD-B3D0-F059C4FB8031", 0, "c6771d5f-3068-42f3-8c88-50c8782d0f86", "admin@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEPLX/nmxHfscwtZJXBlDYUTvlMWXgVDJ1eoOj/rHYJBfbkCTfmm3G94KiNh6gbAaLg==", "555337681", false, "0988f846-f22c-4e54-a238-3a35d9d248d7", false, "admin@gmail.com" },
                    { "87746F88-DC38-4756-924A-B95CFF3A1D8A", 0, "0e66376f-50f5-4862-8c8f-aba1f8639746", "gio@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "GIO@GMAIL.COM", "GIO@GMAIL.COM", "AQAAAAIAAYagAAAAEL3k0JDkOBMl+f02KtaHLd5MJV3ghyAy6SFbmI2vCpLZZ9MZCfxxxoUahDWLI9zZWQ==", "551442269", false, "f89b623e-a25c-4401-a293-8db295433df0", false, "gio@gmail.com" },
                    { "D514EDC9-94BB-416F-AF9D-7C13669689C9", 0, "7045f220-37e3-43fc-8bbe-64a367f81929", "nika@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "NIKA@GMAIL.COM", "NIKA@GMAIL.COM", "AQAAAAIAAYagAAAAEOQGoNKzv8hv8SDCl7RewC+pDYgA8uwVFM/JZ37fm75FNgvgyPJ8TnIgLSecAV0vzg==", "558490645", false, "c36dba05-a1e0-4701-9396-191f4ab68d5f", false, "nika@gmail.com" }
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
                    { 1, "პირველი საქმის აღწერა...", new DateTime(2024, 5, 18, 1, 36, 58, 874, DateTimeKind.Local).AddTicks(1777), 2, new DateTime(2024, 5, 18, 0, 36, 58, 874, DateTimeKind.Local).AddTicks(1776), 1, "პირველი საქმე", "87746F88-DC38-4756-924A-B95CFF3A1D8A" },
                    { 2, "მეორე საქმის აღწერა...", new DateTime(2024, 5, 18, 1, 36, 58, 874, DateTimeKind.Local).AddTicks(1785), 1, new DateTime(2024, 5, 18, 0, 36, 58, 874, DateTimeKind.Local).AddTicks(1785), 1, "მეორე საქმე", "D514EDC9-94BB-416F-AF9D-7C13669689C9" },
                    { 3, "მესამე საქმის აღწერა...", new DateTime(2024, 5, 18, 5, 36, 58, 874, DateTimeKind.Local).AddTicks(1788), 4, new DateTime(2024, 5, 18, 0, 36, 58, 874, DateTimeKind.Local).AddTicks(1788), 2, "მესამე საქმე", "D514EDC9-94BB-416F-AF9D-7C13669689C9" },
                    { 4, "მეოთხე საქმის აღწერა...", new DateTime(2024, 5, 25, 0, 36, 58, 874, DateTimeKind.Local).AddTicks(1791), 1, new DateTime(2024, 5, 18, 0, 36, 58, 874, DateTimeKind.Local).AddTicks(1790), 1, "მეოთხე საქმე", "87746F88-DC38-4756-924A-B95CFF3A1D8A" },
                    { 5, "მეხუთე საქმის აღწერა...", new DateTime(2024, 5, 21, 0, 36, 58, 874, DateTimeKind.Local).AddTicks(1794), 3, new DateTime(2024, 5, 18, 0, 36, 58, 874, DateTimeKind.Local).AddTicks(1794), 1, "მეხუთე საქმე", "87746F88-DC38-4756-924A-B95CFF3A1D8A" },
                    { 6, "მეექვსე საქმის აღწერა...", new DateTime(2024, 5, 28, 0, 36, 58, 874, DateTimeKind.Local).AddTicks(1797), 2, new DateTime(2024, 5, 18, 0, 36, 58, 874, DateTimeKind.Local).AddTicks(1796), 2, "მეექვსე საქმე", "87746F88-DC38-4756-924A-B95CFF3A1D8A" }
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
