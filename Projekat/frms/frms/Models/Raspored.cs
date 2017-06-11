using frms.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frms.Models
{
    class Raspored
    {
        //null ako je raspored za korisnika, nije null ako je raspored za specific grupu
        public Grupa Grupa { get; set; } = null;

        //null ako je raspored za grupu, nije null ako je raspored za specific korisnika
        public Korisnik Korisnik { get; set; } = null;

        public List<Termin> Termini { get; set; }


        public static async Task<Raspored> ZaGrupu(Grupa g)
        {
            Raspored raspored = null;
            var db = new FakultetDataSource();
            raspored = new Raspored();
            raspored.Termini = new List<Termin>();
            raspored.Termini.AddRange((await db.Termini.ToListAsync()).Where(termin => termin.Grupa.ID == g.ID));
            raspored.Grupa = g;
            
            return raspored;
        }

        public static async Task<Raspored> ZaKorisnika(Korisnik k)
        {
            Raspored raspored = null;
            var db = new FakultetDataSource();
            raspored = new Raspored();
            raspored.Termini = new List<Termin>();
            raspored.Termini.AddRange((await db.Termini.ToListAsync()).Where(termin => termin.Predavac.ID == k.ID));
            raspored.Korisnik = k;

            return raspored;
        }
       
    }
}
