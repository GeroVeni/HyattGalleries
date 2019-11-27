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
            RouteInfo info = e.CurrentSelection[0] as RouteInfo;
            List<Exhibit> exhibits = FiltersViewModel.GetFilteredExhibits(info.ArtistFilter, info.TimePeriodFilter,
                info.ArtStyleFilter);
            await Navigation.PushAsync(new MapPage(exhibits));

            // Deselect item
            routesCollView.SelectedItem = null;
        }

        private async void OnExhibitSelected(object sender, SelectionChangedEventArgs e)
        {
            // Exhibit clicked; open exhibit page
            
            // Check if selection is null
            if (e.CurrentSelection.Count == 0) return;

            // Open exhibit page
            Guid id = (e.CurrentSelection[0] as ExhibitInfo).Exhibit.ID;
            await Navigation.PushAsync(new ExhibitPage(id));

            // Deselect item
            exhibitCollView.SelectedItem = null;
        }
    }
}
