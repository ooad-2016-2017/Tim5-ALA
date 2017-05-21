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
    public sealed partial class RegularManageGroups : Page
    {
        public static List<String> listaPredmeta = new List<String>();

        public static String OdabraniPredmet;      
        private MainPage mainPage
        {
            get
            {
                var rootFrame = Window.Current.Content as Frame;
                return rootFrame.Content as MainPage;
            }
        }

        public RegularManageGroups()
        {
            this.InitializeComponent();

            DataContext = new GrupaInputViewModel();

            // FOR DEBUGGING !!!
            // TODO: kôd za dodavanje predmeta (u viewmodelu)

            for (int i = 1; i < 5; ++i)
            {
                listaPredmeta.Add("Predmet " + i.ToString());
            }

            Predmeti.ItemsSource = listaPredmeta;

        }        

        private void Predmeti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // TODO: kôd za dodavanje grupa na predmetu (viewmodel)

            OdabraniPredmet = (String)e.AddedItems[0];

            int brojStudenata = 20;
            
            for (int i = 1; i < 5; ++i)
            {
                Grid sp = new Grid();
                sp.Width = 150;

                TextBlock ime = new TextBlock();
                ime.Text = "Grupa " + i.ToString();
                ime.HorizontalAlignment = HorizontalAlignment.Left;

                TextBlock brojS = new TextBlock();
                brojS.Text = Convert.ToString(brojStudenata);
                brojS.HorizontalAlignment = HorizontalAlignment.Right;

                sp.Children.Add(ime);
                sp.Children.Add(brojS);

                Grupe.Items.Add(sp);
            }
        }

        private void CreateNewGroup_Click(object sender, RoutedEventArgs e)
        {
            mainPage.Navigate(typeof(RegularAddGroup));
        }
    }
}
