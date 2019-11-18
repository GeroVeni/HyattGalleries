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

        public ExhibitPage(Exhibit exhibit)
        {
            InitializeComponent();

            viewModel = new ExhibitViewModel();
            viewModel.ImageSource = exhibit.ImageSource;
            viewModel.ExhibitName = exhibit.Name;
            viewModel.ExhibitDescription = exhibit.Name;
            BindingContext = viewModel;
        }
    }

    //private async void onArtistBioClicked(object Sender, EventArgs e)
    //{
        
    //}
}
