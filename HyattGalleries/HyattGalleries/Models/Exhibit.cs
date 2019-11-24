using System;
using System.Collections.Generic;
using System.Text;

namespace HyattGalleries.Models
{
    /// <summary>
    /// Holds information relevant to the exhibit like style, artist, era etc.
    /// </summary>
    public class Exhibit
    {
        public Guid ID { get; private set; }
        public string Name { get; set; }
        public string ImageSource { get; set; }
        public Artist Artist { get; set; }
        public TimePeriod TimePeriod { get; set; }
        public ArtStyle ArtStyle { get; set; }

        public Exhibit(string name, string imageSource, Artist Artist, TimePeriod TimePeriod, ArtStyle ArtStyle)
        {
            ID = Guid.NewGuid();
            this.Name = name;
            this.ImageSource = imageSource;
            this.Artist = Artist;
            this.TimePeriod = TimePeriod;
            this.ArtStyle = ArtStyle;
        }

        public Exhibit(string name, string imageSource, string ArtistString, string TimePeriodString, string ArtStyleString)
            : this(name, imageSource, new Artist(ArtistString), new TimePeriod(TimePeriodString), new ArtStyle(ArtStyleString))
        {}
    }
}
