using System;
using System.Collections.Generic;
using System.Text;

namespace HyattGalleries.ViewModels
{
    /// <summary>
    /// View model for the exhibit page.
    /// </summary>
    class ExhibitViewModel
    {
        public string ImageSource { get; set; }
        public string ExhibitName { get; set; }
        public string ExhibitDescription { get; set; }

        public ExhibitViewModel() {}
    }
}
