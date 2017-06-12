using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace frms.Models
{
    class ZahtjevRezervacija : Zahtjev
    {
        public new string ID { get; set; }

        public Termin ZeljeniTermin { get; set; }
    }
}
