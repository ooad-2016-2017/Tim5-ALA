using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking.Proximity;
using Windows.UI.Core;
using Windows.UI.Xaml;

namespace frms.DataAccessLayer
{
    class Rfid
    {
        ProximityDevice scanner;
        CoreDispatcher _dispatcher = Window.Current.Dispatcher;
        long _messageSubscribeId;
        
        public Rfid()
        {
            scanner = ProximityDevice.GetDefault(); 

            if(scanner != null)
           { 
                scanner.DeviceArrived += ProximityDeviceArrived;
                scanner.DeviceDeparted += ProximityDeviceDeparted;
                _messageSubscribeId = scanner.SubscribeForMessage("NDEF", ReadTag);
            }
            else
            {
                PropagateStatus("Čitač nije pronađen");
            }

        }

        void PropagateStatus(string status)
        {
            MainPage.ShowDialog(status, "uređaj");
        }

        private async void ProximityDeviceArrived(object sender)
        {
            await _dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                PropagateStatus("Čitač pronađen");
            });
        }

        private async void ProximityDeviceDeparted(object sender)
        {
            await _dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                PropagateStatus("Čitač uklonjen");
            });
        }
           
        private async void ReadTag(ProximityDevice sender, ProximityMessage message)
        {
            await _dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                PropagateStatus("Pročitan tag");
            });
        }

    }
}
