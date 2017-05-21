using frms.DataAccessLayer;
using frms.Helper;
using frms.Models;
using frms.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
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
    public sealed partial class Login : Page
    {
        private MainPage mainPage
        {
            get
            {
                var rootFrame = Window.Current.Content as Frame;
                return rootFrame.Content as MainPage;
            }
        }

        public Login()
        {
            this.InitializeComponent();
            DataContext = new LoginViewModel();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            //LoginPanel.IsEnabled = false;
            string user = Username.Text;
            string pass = Utility.SHA512(Password.Password);
            
            using (var db = new FakultetDataSource())
            {
                var dbUser = db.Korisnici.FirstOrDefault(v => v.PasswordHash == pass && v.Username == user);

                if ( dbUser == null )
                {
                    //login fail
                } else if ( dbUser is Administrator )
                {
                    mainPage.NavigatePane(typeof(Views.PaneAdmin));
                } else
                {
                    mainPage.NavigatePane(typeof(Views.PaneRegular));
                }
            }
        }
    }
}
