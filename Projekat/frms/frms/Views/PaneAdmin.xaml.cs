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
    public sealed partial class PaneAdmin : Page
    {
        private MainPage mainPage
        {
            get
            {
                var rootFrame = Window.Current.Content as Frame;
                return rootFrame.Content as MainPage;
            }
        }

        public PaneAdmin()
        {
            this.InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (mainPage.IsPaneOpen())
            {
                mainPage.HidePane();
            }
            else
            {
                mainPage.ShowPane();
            }
        }

        private void RequestsButton_Click(object sender, RoutedEventArgs e)
        {
            mainPage.Navigate(typeof(Views.AdminRequests));
        }

        private void AddUsersButton_Click(object sender, RoutedEventArgs e)
        {
            mainPage.Navigate(typeof(Views.AdminAddUsers));
        }

        private void AddHallsButton_Click(object sender, RoutedEventArgs e)
        {
            mainPage.Navigate(typeof(Views.AdminAddHalls));
        }

        private void SearchHallsButton_Click(object sender, RoutedEventArgs e)
        {
            mainPage.Navigate(typeof(Views.AdminSearchHalls));
        }
    }
}
