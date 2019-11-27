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

        public ExploreViewModel()
        {
            // Make a list of preselected routes
            RouteInfo filter1 = new RouteInfo { ImageSource = "", Name = "Classic" };
            filter1.ArtStyleFilter = new List<ArtStyle>
            {
                new ArtStyle("Classic")
            };

            RouteInfo filter2 = new RouteInfo { ImageSource = "", Name = "17th century" };
            filter2.TimePeriodFilter = new List<TimePeriod>
            {
                new TimePeriod("17th century")
            };

            RouteInfo filter3 = new RouteInfo { ImageSource = "", Name = "ALEKOS TZOMAKAS" };
            filter3.ArtistFilter = new List<Artist>
            {
                new Artist("ALEKOS TZOMAKAS")
            };

            PreselectedRoutes = new List<RouteInfo>
            {
                filter1,
                filter2,
                filter3
            };
            
            // Make a list of popular exhibits
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
            public string ImageSource;
            public string Name { get; set; }
            public List<Artist> ArtistFilter { get; set; }
            public List<TimePeriod> TimePeriodFilter { get; set; }
            public List<ArtStyle> ArtStyleFilter { get; set; }

            public RouteInfo ()
            {
                ArtistFilter = null;
                TimePeriodFilter = null;
                ArtStyleFilter = null;
            }
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
