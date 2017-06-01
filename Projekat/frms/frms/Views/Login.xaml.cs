using frms.Helper;
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
    public sealed partial class Login : Page, INavigationService
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
            Context.NavigationService = this;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

        }


        public void Navigate(Type sourcePage)
        {
            mainPage.NavigatePane(sourcePage);

            if(sourcePage.Name == "PaneAdmin")
            {
                mainPage.Navigate(typeof(Views.AdminRequests));
            }
            else
            {
                mainPage.Navigate(typeof(Views.RegularUpdateSchedule));
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            FocusManager.TryMoveFocus(FocusNavigationDirection.Next);
        }


        // za početak, hardkodirano
        private void Username_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            if(sender.Text == "0")
            {
                // nekako sakriti ono što se unosi                
            }

            else if(Helper.FormDataValidator.KarticaAdmin(sender.Text))
            {
                Navigate(typeof(PaneAdmin));
            }

            else if(Helper.FormDataValidator.KarticaRegular(sender.Text))
            {
                Navigate(typeof(PaneRegular));
            }
        }
    }
}
