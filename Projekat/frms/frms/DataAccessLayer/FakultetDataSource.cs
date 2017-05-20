using frms.Models;
using Microsoft.EntityFrameworkCore;
using SQLite.Net;
using SQLite.Net.Platform.WinRT;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace frms.DataAccessLayer
{
    class FakultetDataSource : DbContext
    {
        private const string DbPath = "database.sqlite";


        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<Grupa> Grupe { get; set; }
        public DbSet<Sala> Sale { get; set; }
        public DbSet<Laboratorij> Laboratoriji { get; set; }
        public DbSet<Zahtjev> Zahtjevi { get; set; }
         
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=" + DbPath);
        }
        
        
        public Sala DajSaluById(int id) {
            return Sale.FirstOrDefault(s => s.ID == id);
        }

        public Korisnik DajKorisnikaById(int id)
        {
            return Korisnici.FirstOrDefault(s => s.ID == id);
        }

        public Grupa DajGrupuById(int id)
        {
            return Grupe.FirstOrDefault(s => s.ID == id);
        }

        public Zahtjev DajZahtjevById(int id)
        {
            return Zahtjevi.FirstOrDefault(s => s.ID == id);
        }

        

    }
}
