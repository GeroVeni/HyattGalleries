using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HyattGalleries.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IntroPage : ContentPage
	{
		public IntroPage ()
		{
			InitializeComponent ();
		}

        private async void OnLoginPressed(object sender, EventArgs e)
        {
            // Login button is pressed
            //await Navigation.PushAsync(new LoginPage());
        }

        private async void OnSignupPressed(object sender, EventArgs e)
        {
            // Signup button is pressed
            //await Navigation.PushAsync(new SignupPage());
        }

        private async void OnForgottenPressed(object sender, EventArgs e)
        {
            // "Forgotten your password" button is pressed
        }
    }
}