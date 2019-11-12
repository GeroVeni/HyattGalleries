using HyattGalleries.ViewModels;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HyattGalleries.Views
{
    public partial class WelcomePage : ContentPage
    {
        WelcomeViewModel viewModel;

        public WelcomePage()
        {
            InitializeComponent();

            BindingContext = viewModel = new WelcomeViewModel();
        }

        private async void onExploreClicked(object Sender, EventArgs e)
        {
            // Navigate to Explore Page
            await Navigation.PushAsync(new ExplorePage());
        }

        private async void OnExhibitionClicked(object Sender, SelectionChangedEventArgs e)
        {
            // An exhibition was clicked so switch to that exhibition
            // TODO: Implement
        }
    }
}
