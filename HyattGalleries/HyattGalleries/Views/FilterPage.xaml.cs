using HyattGalleries.Models;
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
        ItemsViewModel itemsViewModel;

		public FilterPage ()
		{
			InitializeComponent ();

            BindingContext = itemsViewModel = new ItemsViewModel();
		}

        private async void OnCreateRoutePressed(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MapPage());
        }
    }
}