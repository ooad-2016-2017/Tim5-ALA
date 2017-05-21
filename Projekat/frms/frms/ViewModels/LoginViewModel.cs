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

        public LoginViewModel()
        {
            using (var db = new FakultetDataSource())
            {
                if (db.Korisnici.Count() == 0)
                    db.Korisnici.Add(new Administrator() { Ime = "admin", PasswordHash = Utility.SHA512("admin"), Username = "admin", Prezime = "admin" });

                db.SaveChanges();
            }


            Potvrda = new RelayCommand<object>(doLogin, param => true );
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void doLogin(object param)
        {
            using (var db = new FakultetDataSource())
            {
                var dbUser = db.Korisnici.FirstOrDefault(v => v.PasswordHash == Utility.SHA512(Password) && v.Username == Username);

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
                    NavigationService.Navigate(typeof(Views.PaneRegular));
                }
            }
        }
    }
}
