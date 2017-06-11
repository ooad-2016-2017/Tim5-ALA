using frms.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frms.Models
{
    class Sala
    {
        
        public string ID { get; set; }

        public string Naziv { get; set; }

        public int BrojMjesta { get; set; }

        public async Task<bool> Slobodna(DateTime kad)
        {
            var db = new FakultetDataSource();

            foreach (var termin in await db.Termini.Where( t => t.Sala.ID == ID).ToListAsync() )
            {
                if (termin.VrijemePocetka >= kad && termin.VrijemeZavrsetka <= kad) return false;
            }
            return true;
        }

        public static async Task<List<Sala>> DajSlobodneSale(DateTime kad, int minBrojMjesta = -1)
        {
            List<Sala> res = new List<Sala>();

            var db = new FakultetDataSource();
            foreach ( var sala in ( await db.Sale.ToListAsync()).Distinct() )
            {
                if (await sala.Slobodna(kad) && minBrojMjesta < sala.BrojMjesta )
                    res.Add(sala);
            }
            

            return res;
        }

        public override bool Equals(object obj)
        {
            Sala other = obj as Sala;
            return other?.ID == ID;
        }
    }
}
