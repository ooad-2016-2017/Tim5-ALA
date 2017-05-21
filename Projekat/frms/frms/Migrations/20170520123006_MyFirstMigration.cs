using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace frms.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grupe",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupe", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Discriminator = table.Column<string>(nullable: false),
                    Ime = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GrupaID = table.Column<int>(nullable: true),
                    Ime = table.Column<string>(nullable: true),
                    Index = table.Column<string>(nullable: true),
                    Odsijek = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Student_Grupe_GrupaID",
                        column: x => x.GrupaID,
                        principalTable: "Grupe",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Discriminator = table.Column<string>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    OdgovorniLaborantID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sale_Korisnici_OdgovorniLaborantID",
                        column: x => x.OdgovorniLaborantID,
                        principalTable: "Korisnici",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zahtjevi",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AdministratorID = table.Column<int>(nullable: true),
                    Odobren = table.Column<bool>(nullable: false),
                    PodnosilacID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zahtjevi", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Zahtjevi_Korisnici_AdministratorID",
                        column: x => x.AdministratorID,
                        principalTable: "Korisnici",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zahtjevi_Korisnici_PodnosilacID",
                        column: x => x.PodnosilacID,
                        principalTable: "Korisnici",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Osobina",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LaboratorijID = table.Column<int>(nullable: true),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osobina", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Osobina_Sale_LaboratorijID",
                        column: x => x.LaboratorijID,
                        principalTable: "Sale",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Osobina_LaboratorijID",
                table: "Osobina",
                column: "LaboratorijID");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_OdgovorniLaborantID",
                table: "Sale",
                column: "OdgovorniLaborantID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_GrupaID",
                table: "Student",
                column: "GrupaID");

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjevi_AdministratorID",
                table: "Zahtjevi",
                column: "AdministratorID");

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjevi_PodnosilacID",
                table: "Zahtjevi",
                column: "PodnosilacID");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Osobina");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Zahtjevi");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "Grupe");

            migrationBuilder.DropTable(
                name: "Korisnici");
        }
    }
}
