using frms.DataAccessLayer;
using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frms.Models
{
    class Sala
    {

        [AutoIncrement, PrimaryKey]
        public int ID { get; set; }

        public string Naziv { get; set; }

        public int BrojMjesta { get; set; }

        public bool Slobodna(DateTime kad)
        {
            using (var db = new FakultetDataSource())
            {
                foreach (var termin in db.Termini.Where( t => t.Sala.ID == ID) )
                {
                    if (termin.VrijemePocetka >= kad && termin.VrijemeZavrsetka <= kad) return false;
                }
            }
            return true;
        }

        public static List<Sala> DajSlobodneSale(DateTime kad, int minBrojMjesta = -1)
        {
            List<Sala> res = new List<Sala>();

            using ( var db = new FakultetDataSource() )
            {
                foreach ( var sala in db.Sale.Distinct() )
                {
                    if (sala.Slobodna(kad) && minBrojMjesta < sala.BrojMjesta )
                        res.Add(sala);
                }
            }

            return res;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Sala)) return false;

            Sala other = (Sala)obj;
            return other.ID == ID;
        }
    }
}
