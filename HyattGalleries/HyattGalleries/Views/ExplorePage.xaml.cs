using HyattGalleries.ViewModels;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

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
    }
}
