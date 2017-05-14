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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace frms
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private double normalCompactPaneLength;

        private void HidePane()
        {
            MainSplitView.CompactPaneLength = 0;
            MainSplitView.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            MainSplitView.IsPaneOpen = false;
        }

        public MainPage()
        {
            this.InitializeComponent();
            // treba disableati navigaciju dok se ne odradi login?
            // ili samo da kontrole ništa ne prikazuju :)

            this.normalCompactPaneLength = MainSplitView.CompactPaneLength;
            HidePane();
            aktivnaStranica.Navigate(typeof(Views.Login));
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainSplitView.IsPaneOpen)
            {
                MainSplitView.IsPaneOpen = false;
                MainSplitView.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            }
            else
            {
                MainSplitView.IsPaneOpen = true;
                MainSplitView.DisplayMode = SplitViewDisplayMode.Overlay;
            }
        }

        private void UpdateScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            aktivnaStranica.Navigate(typeof(Views.UpdateSchedule));
        }

        private void ManageGroupsButton_Click(object sender, RoutedEventArgs e)
        {
            aktivnaStranica.Navigate(typeof(Views.ManageGroups));
        }

        private void ReserveHallButton_Click(object sender, RoutedEventArgs e)
        {
            aktivnaStranica.Navigate(typeof(Views.ReserveHall));
        }

        private void SearchHallsButton_Click(object sender, RoutedEventArgs e)
        {
            aktivnaStranica.Navigate(typeof(Views.SearchHalls));
        }
    }
}
