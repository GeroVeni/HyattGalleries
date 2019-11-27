using HyattGalleries.Models;
using HyattGalleries.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static HyattGalleries.ViewModels.ExploreViewModel;

namespace HyattGalleries.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MapPage : ContentPage
	{

        MapViewModel viewModel;

		public MapPage (List<Exhibit> exhibits)
		{
			InitializeComponent ();

            viewModel = new MapViewModel();
            viewModel.Exhibits = exhibits;
            BindingContext = viewModel;
		}

        private async void OnExhibitSelected(object sender, SelectionChangedEventArgs e)
        {
            // Exhibit clicked; open exhibit page

            // Check if selection is null
            if (e.CurrentSelection.Count == 0) return;

            // Open exhibit page
            Guid id = (e.CurrentSelection[0] as Exhibit).ID;
            await Navigation.PushAsync(new ExhibitPage(id));

            // Deselect item
            exhibitCollView.SelectedItem = null;
        }
	}
}