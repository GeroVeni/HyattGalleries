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
            for (int i = 0; i < 5; i++) PreselectedRoutes.Add(new RouteInfo { imageSource = "", name = "test route" });

            PopularExhibits = new List<ExhibitInfo>();
            for (int i = 0; i < 5; i++) PopularExhibits.Add(new ExhibitInfo { imageSource = "", name = "test exhibit" });
        }

        /// <summary>
        /// Helper class for storing information about an exhibit.
        /// </summary>
        public class ExhibitInfo
        {
            public string imageSource;
            public string name { get; set; }
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
