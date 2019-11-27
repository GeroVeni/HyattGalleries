using HyattGalleries.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HyattGalleries.ViewModels
{
    class MapViewModel
    {
        public List<Exhibit> Exhibits { get; set; }

        public MapViewModel()
        {
            Exhibits = new List<Exhibit>();
        }
    }
}
