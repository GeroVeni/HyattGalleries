using HyattGalleries.ViewModels;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

using static HyattGalleries.ViewModels.WelcomeViewModel;

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
            if (e.CurrentSelection.Count == 0) return;
            
            Exhibition ex = e.CurrentSelection[0] as Exhibition;
            welcomeLabel.Text = GetWelcomeString(ex.name);
            exhibitionsCollView.SelectedItem = null;
        }

        #region Utility functions

        private string GetWelcomeString(string venueName) => "Welcome to " + venueName + ".";
        private string GetWelcomeString() => GetWelcomeString("Hyatt Thessaloniki");
        
        #endregion
    }
}
