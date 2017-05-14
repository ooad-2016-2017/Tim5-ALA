using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace frms.ViewModels
{
    class LoginViewModel
    {
        public ICommand Potvrda { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
    }
}
