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
using Windows.UI.Xaml;

namespace frms.ViewModels
{
    class SalaInputViewModel : INotifyPropertyChanged
    {
        public ICommand Potvrda { get; set; }

        public Sala Sala { get; set; } = new Sala();
        public Laboratorij Laboratorij { get; set; } = new Laboratorij();

        private bool _isLab = false;
        public bool IsLab { get
            {
                return _isLab;
            }
            set {
                _isLab = value;
                OnPropertyChanged("IsLabVisible");
                OnPropertyChanged("IsLab");
            }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public Visibility IsLabVisible
        {
            get
            {
                return IsLab ? Visibility.Visible : Visibility.Collapsed;
            }
        }  

        public SalaInputViewModel()
        {

            Potvrda = new RelayCommand<object>(doAdd, param => true);
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void doAdd(object param)
        {
            Sala toSave = Sala;
            if ( IsLab )
            {
                toSave = Laboratorij;
                toSave.Naziv = Sala.Naziv;
                toSave.BrojMjesta = Sala.BrojMjesta;

                var asLab = toSave as Laboratorij;

                // todo dodaj osobine ovdje, ako su oni checked
            }

            using ( var db = new FakultetDataSource() )
            {
                if ( toSave is Sala )
                    db.Sale.Add(toSave);
                else
                    db.Laboratoriji.Add((Laboratorij)toSave);

                db.SaveChanges();
            }
        }
    }
}
