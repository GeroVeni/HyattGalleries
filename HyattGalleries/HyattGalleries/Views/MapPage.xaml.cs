using HyattGalleries.Models;
using HyattGalleries.ViewModels;
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
	}
}