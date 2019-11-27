using HyattGalleries.ViewModels;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HyattGalleries.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FilterPage : ContentPage
	{
        FiltersViewModel viewModel;

		public FilterPage ()
		{
			InitializeComponent ();

            // Hold view model reference to make changes dynamically
            BindingContext = viewModel = new FiltersViewModel();
		}

        private async void OnCreateRoutePressed(object sender, EventArgs e)
        {
            var selectedExhibits = viewModel.GetFilteredExhibits();
            await Navigation.PushAsync(new MapPage(selectedExhibits));
        }
    }
}