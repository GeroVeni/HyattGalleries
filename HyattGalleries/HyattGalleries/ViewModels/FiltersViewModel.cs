using HyattGalleries.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HyattGalleries.ViewModels
{
    /// <summary>
    /// ViewModel for the filters page.
    /// </summary>
    class FiltersViewModel
    {
        public List<Artist> Artists { get; set; }
        public List<TimePeriod> TimePeriods { get; set; }

        public FiltersViewModel()
        {
            Artists = new List<Artist>
            {
                // TODO: Remove testing artists
                new Artist("George"),
                new Artist("John"),
                new Artist("Dimitris"),
                new Artist("Kostas"),
                new Artist("Petros")
            };

            TimePeriods = new List<TimePeriod>
            {
                // TODO: Remove testing time periods
                new TimePeriod("16th century"),
                new TimePeriod("17th century"),
                new TimePeriod("18th century"),
                new TimePeriod("19th century")
            };
        }
    }
}
