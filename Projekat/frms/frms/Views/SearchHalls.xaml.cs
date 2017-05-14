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
    public sealed partial class SearchHalls : Page
    {
        public SearchHalls()
        {
            this.InitializeComponent();
        }

        // zabrana karaktera koji nisu brojevi
        // alternativa za numericupdown

        private void PretragaBrojMjesta_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            // clunky but eh
            
            try
            {
                Convert.ToInt32(sender.Text);
            }
            catch(Exception ex)
            {
                if(sender.Text != null)
                {
                    int len = sender.Text.Length - 1;
                    sender.Text = sender.Text.Substring(0, len);
                }
            }

        }

        private void ButtonPretraga_Click(object sender, RoutedEventArgs e)
        {
            // search, obviously
        }

        private void SaleRezultat_ItemClick(object sender, ItemClickEventArgs e)
        {
            // vodi na dijalog za rezervisanje 
        }
    }
}
