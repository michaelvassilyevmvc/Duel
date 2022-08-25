using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.MsSql.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Disputers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disputers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TopicDisputers",
                columns: table => new
                {
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    DisputerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicDisputers", x => new { x.TopicId, x.DisputerId });
                    table.ForeignKey(
                        name: "FK_TopicDisputers_Disputers_DisputerId",
                        column: x => x.DisputerId,
                        principalTable: "Disputers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TopicDisputers_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TopicDisputers_DisputerId",
                table: "TopicDisputers",
                column: "DisputerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TopicDisputers");

            migrationBuilder.DropTable(
                name: "Disputers");

            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}
