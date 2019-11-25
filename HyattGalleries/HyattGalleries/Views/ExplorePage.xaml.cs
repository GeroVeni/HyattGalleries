using HyattGalleries.Models;
using HyattGalleries.ViewModels;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using static HyattGalleries.ViewModels.ExploreViewModel;

namespace HyattGalleries.Views
{
    public partial class ExplorePage : ContentPage
    {
        ExploreViewModel viewModel;

        public ExplorePage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ExploreViewModel();
        }

        private async void OnRouteSelected(object sender, SelectionChangedEventArgs e)
        {
            // Route clicked; open preselected route in map view

            // Check if selection is null
            if (e.CurrentSelection.Count == 0) return;

            // Open map page
            // TODO: Parametrize map page to open specific route
            await Navigation.PushAsync(new MapPage());

            // Deselect item
            routesCollView.SelectedItem = null;
        }

        private async void OnExhibitSelected(object sender, SelectionChangedEventArgs e)
        {
            // Exhibit clicked; open exhibit page
            
            // Check if selection is null
            if (e.CurrentSelection.Count == 0) return;

            // Open exhibit page
            // TODO: Parametrize exhibit page to open specified exhibit
            Guid id = (e.CurrentSelection[0] as ExhibitInfo).Exhibit.ID;
            await Navigation.PushAsync(new ExhibitPage(id));

            // Deselect item
            exhibitCollView.SelectedItem = null;
        }
    }
}
