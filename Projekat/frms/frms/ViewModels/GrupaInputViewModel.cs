using frms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace frms.ViewModels
{
    class GrupaInputViewModel
    {
        public ICommand Potvrda { get; set; }
        public Grupa Grupa { get; set; }
    }
}
