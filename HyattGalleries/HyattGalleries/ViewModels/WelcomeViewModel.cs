using System;
using System.Collections.Generic;
using System.Text;

namespace HyattGalleries.ViewModels
{
    class WelcomeViewModel
    {
        public List<Exhibition> Exhibitions { get; set; }

        public WelcomeViewModel()
        {
            Exhibitions = new List<Exhibition>();
            for (int i = 0; i < 5; i++) Exhibitions.Add(new Exhibition { imageSource = "", name = "test exhibition " + i });
        }

        public class Exhibition
        {
            public string imageSource { get; set; }
            public string name { get; set; }
        }
    }
}
