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
            exhibits = GetDemoExhibits();

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

            // Preselect some artists, time periods and art styles for demo purposes
            IsArtStyleSelected[0] = true;
            IsTimePeriodSelected[1] = true;
            IsTimePeriodSelected[3] = true;
            IsArtStyleSelected[2] = true;
        }

        // Returns a list of demo exhibits
        private List<Exhibit> GetDemoExhibits()
        {
            List<Exhibit> exhibits = new List<Exhibit>
            {
                new Exhibit("AAAA", "George A", "18th century", "Romanticism"),
                new Exhibit("BBBB", "John A", "18th century", "Romanticism"),
                new Exhibit("CCCC", "Dimitris A", "17th century", "Romanticism"),
                new Exhibit("DDDD", "Kostas A", "17th century", "Romanticism"),
                new Exhibit("EEEE", "George B", "19th century", "Renaissance"),
                new Exhibit("FFFF", "John B", "19th century", "Renaissance"),
                new Exhibit("GGGG", "George B", "19th century", "Renaissance"),
                new Exhibit("HHHH", "George B", "12th century", "Classic"),
                new Exhibit("IIII", "John B", "12th century", "Classic")
            };
            return exhibits;
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
