using System;
using System.Collections.Generic;
using System.Text;

namespace HyattGalleries.Models
{
    /// <summary>
    /// Class representing an artist. Used in route filtering.
    /// </summary>
    public class Artist
    {
        public string Name { get; set; }

        public Artist(string name) { this.Name = name; }
    }
}
