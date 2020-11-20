using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreApplication2.Data.Migrations
{
    public partial class programs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Venue",
                table: "ClgEvents",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateTable(
                name: "EventPrograms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Venue = table.Column<string>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventPrograms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventPrograms_ClgEvents_EventId",
                        column: x => x.EventId,
                        principalTable: "ClgEvents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventPrograms_EventId",
                table: "EventPrograms",
                column: "EventId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventPrograms");

            migrationBuilder.AlterColumn<string>(
                name: "Venue",
                table: "ClgEvents",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
