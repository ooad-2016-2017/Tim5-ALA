using frms.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace frms.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegularReserveHall : Page
    {
        public RegularReserveHall()
        {
            this.InitializeComponent();

            DataContext = new RezervacijaSaleViewModel();

            DatumPocetka.Date = DateTime.Now;
        }


        private void ButtonOtkazi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonPretraga_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DatumPocetka_DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
            DatumZavrsetka.Date = DatumPocetka.Date;
        }
    }
}
