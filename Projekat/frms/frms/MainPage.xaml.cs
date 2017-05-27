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
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace frms
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private double normalCompactPaneLength;

        public MainPage()
        {
            this.InitializeComponent();
            this.normalCompactPaneLength = MainSplitView.CompactPaneLength;
            aktivnaStranica.Navigate(typeof(Views.Login));
        }

        public void Navigate(Type sourcePageType)
        {
            aktivnaStranica.Navigate(sourcePageType);
            HidePane();
        }

        public void NavigatePane(Type sourcePageType)
        {
            aktivniPane.Navigate(sourcePageType);
        }

        public void ShowPane()
        {
            MainSplitView.IsPaneOpen = true;
            MainSplitView.DisplayMode = SplitViewDisplayMode.Overlay;
        }

        public void HidePane()
        { 
            if (HamburgerButton.Visibility == Visibility.Collapsed)
            {
                MainSplitView.IsPaneOpen = false;
                MainSplitView.DisplayMode = SplitViewDisplayMode.CompactOverlay;

            }
            else
            {
                MainSplitView.IsPaneOpen = false;            
            }

        }
        
        public bool IsPaneOpen()
        {
            return MainSplitView.IsPaneOpen;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            if(MainSplitView.IsPaneOpen)
            {
                HidePane();
            }
            else
            {
                ShowPane();
            }
        }

        public void Logout()
        {
            // -__-
            aktivniPane.Navigate(typeof(Views.PaneBlank));
            aktivnaStranica.Navigate(typeof(Views.Login));
        }

        public static async void ShowDialog(string message, string title)
        {
            MessageDialog temp = new MessageDialog(message, title);
            await temp.ShowAsync();
        }

    }
}
