using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HyattGalleries.Views
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private async void onExploreClicked(object Sender, EventArgs e)
        {
            // Navigate to Explore Page
            await Navigation.PushAsync(new ExplorePage());
        }
    }
}
