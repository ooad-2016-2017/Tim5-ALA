using frms.Models;
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
    class FakultetDataSource
    {
        private static string dbPath = string.Empty;
        private static string DbPath
        {
            get
            {
                if (string.IsNullOrEmpty(dbPath))
                {
                    dbPath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "database.sqlite");
                }

                return dbPath;
            }
        }

        private SQLiteConnection dbConn;

        public FakultetDataSource()
        {
            dbConn = new SQLiteConnection(new SQLitePlatformWinRT(), DbPath);
        }

        public void Close()
        {
            dbConn.Close();
        }

        /// TODO za sad prazno, dodati kasnije vezu na bazu...

        public IEnumerable<Sala> DajSale()
        {
            return new List<Sala>();
        }

        public IEnumerable<Korisnik> DajKorisnike()
        {
            return new List<Korisnik>();
        }

        public IEnumerable<Zahtjev> DajZahtjeve()
        {
            return new List<Zahtjev>();
        } 

        public IEnumerable<Grupa> DajGrupe()
        {
            return new List<Grupa>();
        }

        public Sala DajSaluById(int id) {
            return null;
        }

        public Korisnik DajKorisnikaById(int id)
        {
            return null;
        }

        public Grupa DajGrupuById(int id)
        {
            return null;
        }

        public Zahtjev DajZahtjevById(int id)
        {
            return null;
        }

        public Sala RegistrujSalu(Sala target)
        {
            //todo
            return target;
        }

        public Grupa RegistrujGrupu(Grupa target)
        {
            //todo
            return target;
        }

        public Zahtjev RegistrujZahtjev(Zahtjev target)
        {
            //todo
            return target;
        }

        public Korisnik RegistrujKorisnika(Korisnik target)
        {
            //todo
            return target;
        }

        public bool ObrisiSalu(Sala target)
        {
            return false;
        }

        public bool ObrisiGrupu(Grupa target)
        {
            return false;
        }

        public bool ObrisiKorisnika(Korisnik target)
        {
            return false;
        }

        public bool ObrisiZahtjev(Zahtjev target)
        {
            return false;
        }

        public void CreateDatabase()
        {
            dbConn.CreateTable<Grupa>();
            dbConn.CreateTable<Korisnik>();
            dbConn.CreateTable<Sala>();
            dbConn.CreateTable<Zahtjev>();
            dbConn.CreateTable<Osobina>();
            dbConn.CreateTable<Student>();
            dbConn.CreateTable<Termin>();
        }

    }
}
