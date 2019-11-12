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
	public partial class SignupPage : ContentPage
	{
		public SignupPage ()
		{
			InitializeComponent ();

            usernameEntry.Completed += (s, e) => nameEntry.Focus();
            nameEntry.Completed += (s, e) => emailEntry.Focus();
            emailEntry.Completed += (s, e) => passwordEntry.Focus();
            passwordEntry.Completed += (s, e) => password2Entry.Focus();
            password2Entry.Completed += (s, e) => OnSignupButtonPressed(s, e);
		}

        private async void OnSignupButtonPressed(object sender, EventArgs e)
        {
            // TODO: Implement signup
            // For now, navigate to Welcome page.
            await Navigation.PushAsync(new WelcomePage());
        }

        private async void OnSignupWithFbButtonPressed(object sender, EventArgs e)
        {
            // TODO: Implement signup with facebook
            // For now, navigate to Welcome page.
            //await Navigation.PushAsync(new WelcomePage());
            await Navigation.PushAsync(new FilterPage());
        }

        // DO NOT DELETE
        // Test code for Launching the QRcode scanner
        //private async void OnSignupWithFbButtonPressed(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var scanner = DependencyService.Get<IQrScanningService>();
        //        var result = await scanner.ScanAsync();
        //        // TODO: Handle case when result is null
        //        if (result != null)
        //        {
        //            Debug.WriteLine("Result is: " + result);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine("Error during qrcode scanning:" + ex.Message);
        //        // TODO: Return that scanning failed.
        //    }
        //}
	}
}