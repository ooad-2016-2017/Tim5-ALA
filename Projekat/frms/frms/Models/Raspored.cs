using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frms.Models
{
    class Raspored
    {
        public Grupa Grupa { get; set; }
        public List<Termin> Termini { get; set; }


        public static Raspored ZaGrupu(Grupa g)
        {
            //todo
            return null;
        }

        public static Raspored ZaKorisnika(Korisnik k)
        {
            //todo
            return null;
        }
       
    }
}
