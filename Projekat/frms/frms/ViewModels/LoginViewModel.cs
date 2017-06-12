using frms.DataAccessLayer;
using frms.Helper;
using frms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace frms.ViewModels
{
    class LoginViewModel : INotifyPropertyChanged
    {
        public ICommand Potvrda { get; set; }

        public string Username { get; set; } = "";
        public string Password { get; set; } = "";

        public INavigationService NavigationService { get; set; }

        private async void setupAdmin()
        {
            var db = new FakultetDataSource();
            if (!( await db.Korisnici.ToListAsync()).Any())
                await db.Korisnici.InsertAsync(new Administrator() { Ime = "admin", PasswordHash = Utility.SHA512("admin"), Username = "admin", Prezime = "admin" });

        }

        public LoginViewModel()
        {
            setupAdmin();    


            Potvrda = new RelayCommand<object>(doLogin, param => true );
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private async void doLogin(object param)
        {
            var db = new FakultetDataSource();
            var dbUser = ( await db.Korisnici.ToListAsync()).FirstOrDefault(v => v.PasswordHash == Utility.SHA512(Password) && v.Username == Username);

            if (dbUser == null)
            {
                //login fail
            }
            else if (dbUser is Administrator)
            {
                NavigationService.Navigate(typeof(Views.PaneAdmin));
            }
            else
            {
                //NavigationService.Navigate(typeof(Views.PaneRegular));
                NavigationService.Navigate(typeof(Views.PaneAdmin));
            }
            
        }
    }
}
