using frms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace frms.ViewModels
{
    class SalaInputViewModel
    {
        public ICommand Potvrda { get; set; }
        public Sala Sala;
    }
}
