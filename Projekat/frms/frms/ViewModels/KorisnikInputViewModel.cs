using frms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using frms.DataAccessLayer;
using frms.Helper;

namespace frms.ViewModels
{
    class KorisnikInputViewModel : INotifyPropertyChanged
    {
        public ICommand Potvrda { get; set; }
        public Korisnik Korisnik { get; set; } = new Korisnik();

        public bool isAdmin { get; set; } = false;

        public bool DataIsValid
        {
            get { return Helper.FormDataValidator.validacijaKorisnika(Korisnik.Ime, Korisnik.Prezime); }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;


        public KorisnikInputViewModel()
        {

            Potvrda = new RelayCommand<object>(doAdd, param => true);

        }

        private void doAdd(object param)
        {
            Korisnik toSave = Korisnik;

            if (isAdmin)
            {
                var admin = new Administrator();
                admin.Ime = toSave.Ime;
                admin.Prezime = toSave.Prezime;
                admin.PasswordHash = toSave.PasswordHash;
                admin.Username = toSave.Username;


                toSave = admin;
            }
            
            var db = new FakultetDataSource();

            toSave.PasswordHash = Utility.SHA512(toSave.PasswordHash);

            if (toSave.ID != null)
                db.Korisnici.UpdateAsync(toSave);
            else
                db.Korisnici.InsertAsync(toSave);
        }
    }
}
