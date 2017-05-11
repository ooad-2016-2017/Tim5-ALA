using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frms.Models
{
    class Termin
    {
        [AutoIncrement, PrimaryKey]
        public int ID { get; set; }

        public Sala Sala { get; set; }
        public DateTime VrijemePocetka { get; set; }
        public DateTime VrijemeZavrsetka { get; set; }
        public Korisnik Predavac { get; set; }
        public Grupa Grupa { get; set; }
    }
}
