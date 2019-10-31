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
            // Login, for now navigate to explore page
            await Navigation.PushAsync(new ExplorePage());
        }

        private async void onFbLoginClicked(object Sender, EventArgs e)
        {
            // Login with Facebook
        }
    }
}