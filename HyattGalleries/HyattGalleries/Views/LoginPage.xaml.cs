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
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        private async void onLoginClicked(object Sender, EventArgs e)
        {
            // Login
            // TODO: Implement login
            // For now navigate to welcome page
            await Navigation.PushAsync(new MainPage());
        }

        private async void onFbLoginClicked(object Sender, EventArgs e)
        {
            // TODO: Implement loging in with Facebook.
            // For now, navigate to the welcome page.
            await Navigation.PushAsync(new WelcomePage());
        }
    }
}