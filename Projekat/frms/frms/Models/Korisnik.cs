using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frms.Models
{
    class Korisnik
    {
        public string ID { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        
    }
}
