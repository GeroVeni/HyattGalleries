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
	public partial class FavouritesPage : ContentPage
	{
        FavouritesViewModel viewModel;

		public FavouritesPage ()
		{
			InitializeComponent ();

            BindingContext = viewModel = new FavouritesViewModel();
		}
	}
}