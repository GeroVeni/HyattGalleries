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
	public partial class HeaderView : ContentView
	{
		public HeaderView ()
		{
			InitializeComponent ();

            // Make account icon clickable
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) =>
            {
                Navigation.PushAsync(new AccountPage());
            };
            image_account.GestureRecognizers.Add(tapGestureRecognizer);

            //Make basket icon clickable
            tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) =>
            {
                Navigation.PushAsync(new FavouritesPage());
            }
		}
	}
}