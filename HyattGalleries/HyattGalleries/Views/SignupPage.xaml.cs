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
	public partial class SignupPage : ContentPage
	{
		public SignupPage ()
		{
			InitializeComponent ();

            NavigationPage.SetHasNavigationBar(this, false);

            usernameEntry.Completed += (s, e) => nameEntry.Focus();
            nameEntry.Completed += (s, e) => emailEntry.Focus();
            emailEntry.Completed += (s, e) => passwordEntry.Focus();
            passwordEntry.Completed += (s, e) => password2Entry.Focus();
            password2Entry.Completed += (s, e) => OnSignupButtonPressed(s, e);
		}

        private async void OnSignupButtonPressed(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FilterPage());
        }
	}
}