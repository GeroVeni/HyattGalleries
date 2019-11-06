using System;
using System.Collections.Generic;
using System.Text;

namespace HyattGalleries.Models
{
    /// <summary>
    /// Class representing a time period. Used in route filtering.
    /// </summary>
    class TimePeriod
    {
        public string Name { get; set; }

        public TimePeriod (string name) { this.Name = name; }
    }
}
