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
        private bool isFavourite;

        public bool IsFavourite
        {
            get
            {
                return isFavourite;
            }

            set
            {
                if (value != isFavourite)
                {
                    if (value) FavImageSource = "ic_favourite_fill.png";
                    else FavImageSource = "ic_favourite_empty.png";
                    isFavourite = value;
                }
            }
        }
        public string ImageSource { get; set; }
        public Guid ExhibitID { get; set; }
        public string ExhibitName { get; set; }
        public string ExhibitDescription { get; set; }
        public string FavImageSource { get; private set; }

        public ExhibitViewModel()
        {
            IsFavourite = false;
            FavImageSource = "ic_favourite_empty.png";
        }
    }
}
