using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaMotocicletas.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Talleres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreTaller = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DireccionTaller = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZonaTaller = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talleres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motocicletas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MarcaMotocicleta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CCMotocicleta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlacaMotocicleta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaDeIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TallerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MotocicletaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motocicletas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Motocicletas_Talleres_TallerId",
                        column: x => x.TallerId,
                        principalTable: "Talleres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Motocicletas_TallerId",
                table: "Motocicletas",
                column: "TallerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Motocicletas");

            migrationBuilder.DropTable(
                name: "Talleres");
        }
    }
}
