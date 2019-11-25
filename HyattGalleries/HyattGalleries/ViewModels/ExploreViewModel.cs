using HyattGalleries.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HyattGalleries.ViewModels
{
    /// <summary>
    /// ViewModel for the explore page.
    /// </summary>
    class ExploreViewModel
    {
        public List<RouteInfo> PreselectedRoutes { get; set; }
        public List<ExhibitInfo> PopularExhibits { get; set; }

        public ExploreViewModel ()
        {
            PreselectedRoutes = new List<RouteInfo>();
            for (int i = 0; i < 5; i++) PreselectedRoutes.Add(new RouteInfo { imageSource = "", name = "test route " + i });

            ExhibitBase exhibitBase = ExhibitBase.GetExhibitBase();

            PopularExhibits = new List<ExhibitInfo>();
            var FavExhibits = exhibitBase.GetFavourites();
            int exhibitCount = Math.Min(5, exhibitBase.Exhibits.Count);
            for (int i = 0; i < exhibitCount; i++)
            {
                Exhibit exhibit = exhibitBase.Exhibits[i];
                bool isFav = false;
                if (FavExhibits.Contains(exhibit)) { isFav = true; }
                PopularExhibits.Add(new ExhibitInfo(exhibit, isFav));
            }
        }

        /// <summary>
        /// Helper class for storing information about a preselected route.
        /// </summary>
        public class RouteInfo
        {
            public string imageSource;
            public string name { get; set; }
        }

        /// <summary>
        /// Helper class for storing information about a popular exhibit.
        /// </summary>
        public class ExhibitInfo
        {
            private bool isFavourite;

            public Exhibit Exhibit { get; }
            public string Name => Exhibit.Name;
            public string ImageSource => Exhibit.ImageSource;
            public string FavImageSource
            {
                get
                {
                    if (isFavourite) return "ic_favourite_fill.png";
                    return "ic_favourite_empty.png";
                }
            }

            public ExhibitInfo(Exhibit exhibit, bool isFavourite)
            {
                Exhibit = exhibit;
                this.isFavourite = isFavourite;
            }
        }
    }

    
}
