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
        public List<Exhibit> PopularExhibits { get; set; }

        public ExploreViewModel ()
        {
            PreselectedRoutes = new List<RouteInfo>();
            for (int i = 0; i < 5; i++) PreselectedRoutes.Add(new RouteInfo { imageSource = "", name = "test route " + i });

            ExhibitBase exhibitBase = ExhibitBase.GetExhibitBase();

            PopularExhibits = new List<Exhibit>();
            int exhibitCount = Math.Min(5, exhibitBase.Exhibits.Count);
            for (int i = 0; i < exhibitCount; i++) PopularExhibits.Add(exhibitBase.Exhibits[i]);
        }

        /// <summary>
        /// Helper class for storing information about a preselected route.
        /// </summary>
        public class RouteInfo
        {
            public string imageSource;
            public string name { get; set; }
        }
    }

    
}
