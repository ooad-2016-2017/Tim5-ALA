using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frms.Models
{
    class Zahtjev
    {
        [AutoIncrement, PrimaryKey]
        public int ID { get; set; }


        public bool Odobren { get; set; }
        public Korisnik Podnosilac { get; set; }

        //mozda skontati kakav bolji naziv?
        //admin koji je odobrio zahtjev, ako nije odobren onda null
        public Administrator Administrator { get; set; }

    }
}
