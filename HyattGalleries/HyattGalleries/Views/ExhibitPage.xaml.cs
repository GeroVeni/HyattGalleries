using HyattGalleries.Models;
using HyattGalleries.ViewModels;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HyattGalleries.Views
{
    public partial class ExhibitPage : ContentPage
    {
        ExhibitViewModel viewModel;

        public ExhibitPage(Guid exhibitID)
        {
            InitializeComponent();
            
            viewModel = new ExhibitViewModel();
            ExhibitBase exhibitBase = ExhibitBase.GetExhibitBase();
            var FavExhibits = exhibitBase.GetFavourites();
            Exhibit exhibit = exhibitBase.Exhibits.Find((e) => e.ID == exhibitID);
            viewModel.ImageSource = exhibit.ImageSource;
            // TODO: Remove other attributes apart from ID from ExhibitID
            viewModel.ExhibitID = exhibit.ID;
            viewModel.ExhibitName = exhibit.Name;
            viewModel.ExhibitDescription = exhibit.Name;
            viewModel.IsFavourite = FavExhibits.Contains(exhibit);
            BindingContext = viewModel;

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) =>
            {
                // Switch favourite state
                if (viewModel.IsFavourite)
                {
                    // Unfavourite item
                    viewModel.IsFavourite = false;
                    exhibitBase.RemoveFavourite(viewModel.ExhibitID);
                }
                else
                {
                    // Favourite item
                    viewModel.IsFavourite = true;
                    exhibitBase.AddFavourite(viewModel.ExhibitID);
                }
                // TODO: Do this using data binding
                image_favourite.Source = viewModel.FavImageSource;
            };
            image_favourite.GestureRecognizers.Add(tapGestureRecognizer);
        }
    }

    //private async void onArtistBioClicked(object Sender, EventArgs e)
    //{
        
    //}
}
