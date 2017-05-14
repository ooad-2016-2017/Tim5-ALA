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
    public sealed partial class ManageGroups : Page
    {
        public ManageGroups()
        {
            this.InitializeComponent();

            // FOR DEBUGGING !!!
            // TODO: kôd za dodavanje predmeta (u viewmodelu)

            for (int i = 1; i < 5; ++i)
            {
                Predmeti.Items.Add("Predmet " + i.ToString());
            }

        }        

        private void Predmeti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // TODO: kôd za dodavanje grupa na predmetu (viewmodel)

            rootPivot.Title = e.AddedItems[0];

            for (int i = 1; i < 5; ++i)
            {
                TextBlock tb = new TextBlock();
                tb.Text = "Grupa " + i.ToString();
                PivotItem pa = new PivotItem();
                pa.Content = tb;
                rootPivot.Items.Add(pa);
            }
        }

        private void CreateNewGroup_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
