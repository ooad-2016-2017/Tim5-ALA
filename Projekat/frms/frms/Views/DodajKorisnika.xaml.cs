﻿using frms.ViewModels;
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
    public sealed partial class DodajKorisnika : Page
    {
        public DodajKorisnika()
        {
            this.InitializeComponent();

            DataContext = new KorisnikInputViewModel();
        }

        private void sacuvajButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO
        }

        private void odustaniButton_Click(Windows.System.Object sender, RoutedEventArgs e)
        {

        }

        private void odustaniButton_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
