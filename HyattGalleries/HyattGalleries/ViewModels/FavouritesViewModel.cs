using HyattGalleries.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HyattGalleries.ViewModels
{
    class FavouritesViewModel
    {
        public List<Exhibit> Favourites { get; set; }

        public FavouritesViewModel()
        {
            Favourites = ExhibitBase.GetExhibitBase().GetFavourites();
        }
    }
}
