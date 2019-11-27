using HyattGalleries.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HyattGalleries.ViewModels
{
    /// <summary>
    /// ViewModel for the filters page.
    /// </summary>
    class FiltersViewModel
    {
        public List<ArtistInfo> Artists { get; set; }
        public List<TimePeriodInfo> TimePeriods { get; set; }
        public List<ArtStyleInfo> ArtStyles { get; set; }

        private List<Exhibit> exhibits;

        public FiltersViewModel()
        {
            // Create some demo exhibits
            exhibits = ExhibitBase.GetExhibitBase().Exhibits;

            // Find out all artists and deselect all of them
            Artists = GetArtists(exhibits);

            // Find out all time periods and deselect all of them
            TimePeriods = GetTimePeriods(exhibits);

            // Find out all art styles and deselect all of them
            ArtStyles = GetArtStyles(exhibits);
        }

        public List<Exhibit> GetFilteredExhibits ()
        {
            return GetFilteredExhibits(GetSelectedArtists(), GetSelectedTimePeriods(), GetSelectedArtStyles());
        }

        public static List<Exhibit> GetFilteredExhibits(List<Artist> selectedArtists, List<TimePeriod> selectedTimePeriods,
            List<ArtStyle> selectedArtStyles)
        {
            List<Exhibit> exhibits = ExhibitBase.GetExhibitBase().Exhibits;
            if (selectedArtists is null) selectedArtists = GetArtists(exhibits)
                    .ConvertAll(a => a.Artist);
            if (selectedTimePeriods is null) selectedTimePeriods = GetTimePeriods(exhibits)
                    .ConvertAll(tp => tp.TimePeriod);
            if (selectedArtStyles is null) selectedArtStyles = GetArtStyles(exhibits)
                    .ConvertAll(st => st.ArtStyle);
            return exhibits.FindAll((e) =>
                    selectedArtists.Exists(a => a.Name == e.Artist.Name) &&
                    selectedTimePeriods.Exists(tp => tp.Name == e.TimePeriod.Name) &&
                    selectedArtStyles.Exists(st => st.Name == e.ArtStyle.Name));
        }

        // Returns a list of unique artists from a list of exhibits.
        private static List<ArtistInfo> GetArtists(List<Exhibit> exhibits)
        {
            List<ArtistInfo> artists = new List<ArtistInfo>();
            foreach (var exhibit in exhibits)
            {
                // Check if the artist is not in the list already
                if (artists.FindIndex((a) => a.Name == exhibit.Artist.Name) == -1)
                {
                    artists.Add(new ArtistInfo(exhibit.Artist, false));
                }
            }
            return artists;
        }

        // Returns a list of selected artists
        private List<Artist> GetSelectedArtists()
        {
            List<Artist> filtered = Artists.FindAll((a) => a.IsChecked).ConvertAll((a) => a.Artist);
            return filtered;
        }

        // Returns a list of unique time periods from a list of exhibits.
        private static List<TimePeriodInfo> GetTimePeriods(List<Exhibit> exhibits)
        {
            List<TimePeriodInfo> timePeriods = new List<TimePeriodInfo>();
            foreach (var exhibit in exhibits)
            {
                // Check if the time period is not in the list already
                if (timePeriods.FindIndex((a) => a.Name == exhibit.TimePeriod.Name) == -1)
                {
                    timePeriods.Add(new TimePeriodInfo(exhibit.TimePeriod, false));
                }
            }
            return timePeriods;
        }

        // Returns a list of selected time periods
        private List<TimePeriod> GetSelectedTimePeriods()
        {
            var filtered = TimePeriods.FindAll((tp) => tp.IsChecked).ConvertAll((tp) => tp.TimePeriod);
            return filtered;
        }

        // Returns a list of unique art styles from a list of exhibits.
        private static List<ArtStyleInfo> GetArtStyles(List<Exhibit> exhibits)
        {
            List<ArtStyleInfo> artStyles = new List<ArtStyleInfo>();
            foreach (var exhibit in exhibits)
            {
                // Check if the art style is not in the list already
                if (artStyles.FindIndex((a) => a.Name == exhibit.ArtStyle.Name) == -1)
                {
                    artStyles.Add(new ArtStyleInfo(exhibit.ArtStyle, false));
                }
            }
            return artStyles;
        }

        // Returns a list of selected art styles
        private List<ArtStyle> GetSelectedArtStyles()
        {
            var filtered = ArtStyles.FindAll((st) => st.IsChecked).ConvertAll((st) => st.ArtStyle);
            return filtered;
        }

        public class ArtistInfo
        {
            public Artist Artist { get; set; }
            public string Name => Artist.Name;
            public bool IsChecked { get; set; }

            public ArtistInfo(Artist artist, bool IsChecked)
            {
                Artist = artist;
                this.IsChecked = IsChecked;
            }
        }

        public class TimePeriodInfo
        {
            public TimePeriod TimePeriod { get; set; }
            public string Name => TimePeriod.Name;
            public bool IsChecked { get; set; }

            public TimePeriodInfo(TimePeriod period, bool IsChecked)
            {
                TimePeriod = period;
                this.IsChecked = IsChecked;
            }
        }

        public class ArtStyleInfo
        {
            public ArtStyle ArtStyle { get; set; }
            public string Name => ArtStyle.Name;
            public bool IsChecked { get; set; }

            public ArtStyleInfo(ArtStyle style, bool IsChecked)
            {
                ArtStyle = style;
                this.IsChecked = IsChecked;
            }
        }
    }
}
