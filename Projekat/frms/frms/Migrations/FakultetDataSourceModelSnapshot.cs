using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using frms.DataAccessLayer;

namespace frms.Migrations
{
    [DbContext(typeof(FakultetDataSource))]
    partial class FakultetDataSourceModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("frms.Models.Grupa", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.HasKey("ID");

                    b.ToTable("Grupe");
                });

            modelBuilder.Entity("frms.Models.Korisnik", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Ime");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("Prezime");

                    b.Property<string>("Username");

                    b.HasKey("ID");

                    b.ToTable("Korisnici");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Korisnik");
                });

            modelBuilder.Entity("frms.Models.Osobina", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("LaboratorijID");

                    b.Property<string>("Naziv");

                    b.HasKey("ID");

                    b.HasIndex("LaboratorijID");

                    b.ToTable("Osobina");
                });

            modelBuilder.Entity("frms.Models.Sala", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Naziv");

                    b.HasKey("ID");

                    b.ToTable("Sale");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Sala");
                });

            modelBuilder.Entity("frms.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("GrupaID");

                    b.Property<string>("Ime");

                    b.Property<string>("Index");

                    b.Property<string>("Odsijek");

                    b.Property<string>("Prezime");

                    b.HasKey("ID");

                    b.HasIndex("GrupaID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("frms.Models.Zahtjev", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AdministratorID");

                    b.Property<bool>("Odobren");

                    b.Property<int?>("PodnosilacID");

                    b.HasKey("ID");

                    b.HasIndex("AdministratorID");

                    b.HasIndex("PodnosilacID");

                    b.ToTable("Zahtjevi");
                });

            modelBuilder.Entity("frms.Models.Administrator", b =>
                {
                    b.HasBaseType("frms.Models.Korisnik");


                    b.ToTable("Administrator");

                    b.HasDiscriminator().HasValue("Administrator");
                });

            modelBuilder.Entity("frms.Models.Laboratorij", b =>
                {
                    b.HasBaseType("frms.Models.Sala");

                    b.Property<int?>("OdgovorniLaborantID");

                    b.HasIndex("OdgovorniLaborantID");

                    b.ToTable("Laboratorij");

                    b.HasDiscriminator().HasValue("Laboratorij");
                });

            modelBuilder.Entity("frms.Models.Osobina", b =>
                {
                    b.HasOne("frms.Models.Laboratorij")
                        .WithMany("DodatneOsobine")
                        .HasForeignKey("LaboratorijID");
                });

            modelBuilder.Entity("frms.Models.Student", b =>
                {
                    b.HasOne("frms.Models.Grupa")
                        .WithMany("Studenti")
                        .HasForeignKey("GrupaID");
                });

            modelBuilder.Entity("frms.Models.Zahtjev", b =>
                {
                    b.HasOne("frms.Models.Administrator", "Administrator")
                        .WithMany()
                        .HasForeignKey("AdministratorID");

                    b.HasOne("frms.Models.Korisnik", "Podnosilac")
                        .WithMany()
                        .HasForeignKey("PodnosilacID");
                });

            modelBuilder.Entity("frms.Models.Laboratorij", b =>
                {
                    b.HasOne("frms.Models.Korisnik", "OdgovorniLaborant")
                        .WithMany()
                        .HasForeignKey("OdgovorniLaborantID");
                });
        }
    }
}
