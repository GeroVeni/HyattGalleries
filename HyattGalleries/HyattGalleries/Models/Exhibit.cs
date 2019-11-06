﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HyattGalleries.Models
{
    /// <summary>
    /// Holds information relevant to the exhibit like style, artist, era etc.
    /// </summary>
    class Exhibit
    {
        public string Name { get; set; }
        public Artist Artist { get; set; }
        public TimePeriod TimePeriod { get; set; }
        public ArtStyle ArtStyle { get; set; }

        public Exhibit(string name, Artist Artist, TimePeriod TimePeriod, ArtStyle ArtStyle)
        {
            this.Name = name;
            this.Artist = Artist;
            this.TimePeriod = TimePeriod;
            this.ArtStyle = ArtStyle;
        }

        public Exhibit(string name, string ArtistString, string TimePeriodString, string ArtStyleString)
            : this(name, new Artist(ArtistString), new TimePeriod(TimePeriodString), new ArtStyle(ArtStyleString))
        {}
    }
}