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
            await Navigation.PushAsync(new MainPage());
        }

        private void OnExhibitionClicked(object Sender, SelectionChangedEventArgs e)
        {
            // If selection is empty that means it was deselected
            if (e.CurrentSelection.Count == 0) return;

            // An exhibition was clicked so switch to that exhibition
            Exhibition ex = e.CurrentSelection[0] as Exhibition;
            welcomeLabel.Text = GetWelcomeString(ex.name);

            // Deselect item from the list
            exhibitionsCollView.SelectedItem = null;
        }

        #region Utility functions

        private string GetWelcomeString(string venueName) => "Welcome to " + venueName + ".";
        private string GetWelcomeString() => GetWelcomeString("Myro Thessaloniki");
        
        #endregion
    }
}
