using System;
using frms.ViewModels;
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
    public sealed partial class AdminAddUsers : Page
    {
        public AdminAddUsers()
        {
            this.InitializeComponent();
            DataContext = new KorisnikInputViewModel();
            if (Helper.FormDataValidator.validacijaKorisnika(ImeKorisnika.Text.ToString(), PrezimeKorisnika.Text.ToString()))
            {
                sacuvajButton.IsEnabled = true;
            }
            else
            {
                sacuvajButton.IsEnabled = false;
            }
        }
        private void odustaniButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void sacuvajButton_Click(object sender, RoutedEventArgs e)
        {
            /*if (Helper.FormDataValidator.validacijaKorisnika(ImeKorisnika.Text, PrezimeKorisnika.Text))
            {
                sacuvajButton.IsEnabled = true;
            }
            else
            {
                sacuvajButton.IsEnabled = false;
            }*/
        }
    }
}
