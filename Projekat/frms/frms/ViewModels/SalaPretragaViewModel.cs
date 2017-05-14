using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace frms.ViewModels
{
    class SalaPretragaViewModel
    {
        public ICommand Potvrda { get; set; }

        public string Pretraga { get; set; }
    }
}
