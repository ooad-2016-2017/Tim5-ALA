using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace frms.Migrations
{
    public partial class DBUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrojMjesta",
                table: "Sale",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Termini",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GrupaID = table.Column<int>(nullable: true),
                    PredavacID = table.Column<int>(nullable: true),
                    SalaID = table.Column<int>(nullable: true),
                    VrijemePocetka = table.Column<DateTime>(nullable: false),
                    VrijemeZavrsetka = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Termini", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Termini_Grupe_GrupaID",
                        column: x => x.GrupaID,
                        principalTable: "Grupe",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Termini_Korisnici_PredavacID",
                        column: x => x.PredavacID,
                        principalTable: "Korisnici",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Termini_Sale_SalaID",
                        column: x => x.SalaID,
                        principalTable: "Sale",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Termini_GrupaID",
                table: "Termini",
                column: "GrupaID");

            migrationBuilder.CreateIndex(
                name: "IX_Termini_PredavacID",
                table: "Termini",
                column: "PredavacID");

            migrationBuilder.CreateIndex(
                name: "IX_Termini_SalaID",
                table: "Termini",
                column: "SalaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Termini");

            migrationBuilder.DropColumn(
                name: "BrojMjesta",
                table: "Sale");
        }
    }
}
