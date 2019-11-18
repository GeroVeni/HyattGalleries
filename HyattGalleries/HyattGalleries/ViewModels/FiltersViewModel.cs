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
        public List<Artist> Artists { get; set; }
        public List<bool> IsAristSelected { get; set; }
        public List<TimePeriod> TimePeriods { get; set; }
        public List<bool> IsTimePeriodSelected { get; set; }
        public List<ArtStyle> ArtStyles { get; set; }
        public List<bool> IsArtStyleSelected { get; set; }

        private List<Exhibit> exhibits;

        public FiltersViewModel()
        {
            // Create some demo exhibits
            exhibits = ExhibitBase.GetExhibitBase().exhibits;

            // Find out all artists and deselect all of them
            Artists = GetArtists(exhibits);
            IsAristSelected = new List<bool>(Artists.Count);
            for (int i = 0; i < Artists.Count; i++) IsAristSelected.Add(false);

            // Find out all time periods and deselect all of them
            TimePeriods = GetTimePeriods(exhibits);
            IsTimePeriodSelected = new List<bool>(TimePeriods.Count);
            for (int i = 0; i < TimePeriods.Count; i++) IsTimePeriodSelected.Add(false);

            // Find out all art styles and deselect all of them
            ArtStyles = GetArtStyles(exhibits);
            IsArtStyleSelected = new List<bool>(ArtStyles.Count);
            for (int i = 0; i < ArtStyles.Count; i++) IsArtStyleSelected.Add(false);
        }

        // Returns a list of unique artists from a list of exhibits.
        private List<Artist> GetArtists(List<Exhibit> exhibits)
        {
            List<Artist> artists = new List<Artist>();
            foreach (var exhibit in exhibits)
            {
                // Check if the artist is not in the list already
                if (artists.FindIndex((a) => a.Name == exhibit.Artist.Name) == -1)
                {
                    artists.Add(exhibit.Artist);
                }
            }
            return artists;
        }

        // Returns a list of unique time periods from a list of exhibits.
        private List<TimePeriod> GetTimePeriods(List<Exhibit> exhibits)
        {
            List<TimePeriod> timePeriods = new List<TimePeriod>();
            foreach (var exhibit in exhibits)
            {
                // Check if the time period is not in the list already
                if (timePeriods.FindIndex((a) => a.Name == exhibit.TimePeriod.Name) == -1)
                {
                    timePeriods.Add(exhibit.TimePeriod);
                }
            }
            return timePeriods;
        }

        // Returns a list of unique art styles from a list of exhibits.
        private List<ArtStyle> GetArtStyles(List<Exhibit> exhibits)
        {
            List<ArtStyle> artStyles = new List<ArtStyle>();
            foreach (var exhibit in exhibits)
            {
                // Check if the art style is not in the list already
                if (artStyles.FindIndex((a) => a.Name == exhibit.ArtStyle.Name) == -1)
                {
                    artStyles.Add(exhibit.ArtStyle);
                }
            }
            return artStyles;
        }
    }
}
