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
        public List<Artist> Artists;

        public FiltersViewModel()
        {
            Artists = new List<Artist>();
            Artists.Add(new Artist("George"));
            Artists.Add(new Artist("John"));
        }
    }
}
