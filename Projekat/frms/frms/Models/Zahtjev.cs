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


        public bool Odobren { get; private set; }
        public Korisnik Podnosilac { get; set; }

        //mozda skontati kakav bolji naziv?
        //admin koji je odobrio zahtjev, ako nije odobren onda null
        public Administrator Administrator { get; private set; }



        public void PostaviOdobreno( Administrator admin, bool odobreno )
        {
            this.Odobren = odobreno;
            this.Administrator = admin;
        }
        
    }
}
