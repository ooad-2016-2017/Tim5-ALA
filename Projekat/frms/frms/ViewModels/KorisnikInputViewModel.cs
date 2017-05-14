using frms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace frms.ViewModels
{
    class KorisnikInputViewModel
    {
        public ICommand Potvrda { get; set; }
        public Korisnik Korisnik { get; set; }
    }
}
