using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frms.Models
{
    class Laboratorij
    {
        public Korisnik OdgovorniLaborant { get; set; }

        public List<Osobina> DodatneOsobine { get; set; }
    }
}
