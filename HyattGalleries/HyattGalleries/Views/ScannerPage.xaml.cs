using HyattGalleries.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HyattGalleries.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ScannerPage : ContentPage
	{
		public ScannerPage ()
		{
			InitializeComponent ();
		}

        private async void OnScanClicked(object sender, EventArgs e)
        {
            // TODO: Launch scanner when explore button is pressed.
            LaunchScanner();
        }

        private async void LaunchScanner()
        {
            try
            {
                var scanner = DependencyService.Get<IQrScanningService>();
                var result = await scanner.ScanAsync();
                // TODO: Handle case when result is null
                if (result != null)
                {
                    Debug.WriteLine("Result is: " + result);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error during qrcode scanning:" + ex.Message);
                // TODO: Return that scanning failed.
            }
        }
    }
}