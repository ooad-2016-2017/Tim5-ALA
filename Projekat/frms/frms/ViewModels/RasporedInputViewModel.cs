using frms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace frms.ViewModels
{
    class RasporedInputViewModel
    {
        public ICommand Potvrda { get; set; }
        
        public Raspored Raspored { get; set; }
    }
}
