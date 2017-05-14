using frms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace frms.ViewModels
{
    class RezervacijaSaleViewModel
    {
        public ICommand Potvrda { get; set; }
       
        public Termin Termin { get; set; }
    }
}
