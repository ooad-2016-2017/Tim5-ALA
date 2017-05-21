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
        
        // mainpage je okvir za cijelu aplikaciju, pane treba sakriti samo kada je login forma aktivna
        // a adaptivni triggeri svakako prikažu pane kad se resize uradi (sa prethodnom verzijom)
        // => riješila sam sve na drugi način xD

        public MainPage()
        {
            this.InitializeComponent();
            this.normalCompactPaneLength = MainSplitView.CompactPaneLength;
            aktivnaStranica.Navigate(typeof(Views.Login));
        }

        public void Navigate(Type sourcePageType)
        {
            aktivnaStranica.Navigate(sourcePageType);
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

    }
}
