using frms.DataAccessLayer;
using frms.Helper;
using frms.Models;
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

        public DateTime PretragaVrijeme { get; set; } = DateTime.Now;

        public bool PretragaPoTerminu { get; set; } = true;
        public string PretragaBrojMjesta { get; set; } = "";

        public List<Sala> PronadjeneSale { get; set; } = new List<Sala>();

        public SalaPretragaViewModel()
        {

            Potvrda = new RelayCommand<object>(doSearch, param => true);
        }


        private void doSearch(object param)
        {
            int n = 0;
            int.TryParse(PretragaBrojMjesta, out n);

            PronadjeneSale.Clear();
            PronadjeneSale.AddRange(Sala.DajSlobodneSale(PretragaPoTerminu ? PretragaVrijeme : DateTime.Now, n));
        }
    }
}
