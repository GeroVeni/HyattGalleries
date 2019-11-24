using System;
using System.Collections.Generic;
using System.Text;

namespace HyattGalleries.Models
{
    /// <summary>
    /// Singleton class that holds the exhibits list of a venue.
    /// </summary>
    class ExhibitBase
    {
        private static ExhibitBase instance = null;

        private List<Guid> favouriteIDs;

        public List<Exhibit> Exhibits { get; set; }

        /// <summary>
        /// Private constructor to make the singleton pattern.
        /// </summary>
        private ExhibitBase()
        {
            Exhibits = GetDemoExhibits();
            favouriteIDs = new List<Guid>();
        }

        public static ExhibitBase GetExhibitBase()
        {
            if (instance == null)
            {
                instance = new ExhibitBase();
            }
            return instance;
        }

        public List<Exhibit> GetFavourites()
        {
            List<Exhibit> favs = new List<Exhibit>();
            for (int i = 0; i < favouriteIDs.Count; i++)
            {
                favs.Add(Exhibits.Find((e) => e.ID == favouriteIDs[i]));
            }
            return favs;
        }

        public void AddFavourite(Guid exhibitID)
        {
            favouriteIDs.Add(exhibitID);
        }

        public void RemoveFavourite(Guid exhibitID)
        {
            favouriteIDs.Remove(exhibitID);
        }

        // Returns a list of demo exhibits
        private List<Exhibit> GetDemoExhibits()
        {
            List<Exhibit> exhibits = new List<Exhibit>
            {
                new Exhibit("TZOMAKAS 1", "tzomakas_1.png", "ALEKOS TZOMAKAS", "21st century", "None"),
                new Exhibit("TZOMAKAS 2", "tzomakas_2.png", "ALEKOS TZOMAKAS", "21st century", "None"),
                new Exhibit("TZOMAKAS 3", "tzomakas_3.png", "ALEKOS TZOMAKAS", "21st century", "None"),
                new Exhibit("MAGKRIOTIS 1", "magkriotis_1.png", "ANDONIS MAGKRIOTIS", "18th century", "Romanticism"),
                new Exhibit("MAGKRIOTIS 2", "magkriotis_2.png", "ANDONIS MAGKRIOTIS", "18th century", "Romanticism"),
                new Exhibit("FLEMING 1", "fleming_1.png", "EDWARD FLEMING", "18th century", "Romanticism"),
                new Exhibit("FLEMING 2", "fleming_2.png", "EDWARD FLEMING", "18th century", "Romanticism"),
                new Exhibit("FLEMING 3", "fleming_3.png", "EDWARD FLEMING", "18th century", "Romanticism"),
                new Exhibit("FLEMING 4", "fleming_4.png", "EDWARD FLEMING", "18th century", "Romanticism"),
                new Exhibit("BIZAS 1", "bizas_1.png", "GIANNIS BIZAS", "17th century", "Romanticism"),
                new Exhibit("BIZAS 2", "bizas_2.png", "GIANNIS BIZAS", "17th century", "Romanticism"),
                new Exhibit("BIZAS 3", "bizas_3.png", "GIANNIS BIZAS", "17th century", "Romanticism"),
                new Exhibit("BIZAS 4", "bizas_4.png", "GIANNIS BIZAS", "17th century", "Romanticism"),
                new Exhibit("CPAJAK 1", "cpajak_1.png", "GIORGIE CPAJAK", "17th century", "Romanticism"),
                new Exhibit("CPAJAK 2", "cpajak_2.png", "GIORGIE CPAJAK", "17th century", "Romanticism"),
                new Exhibit("CPAJAK 3", "cpajak_3.png", "GIORGIE CPAJAK", "17th century", "Romanticism"),
                new Exhibit("CPAJAK 4", "cpajak_4.png", "GIORGIE CPAJAK", "17th century", "Romanticism"),
                new Exhibit("CPAJAK 5", "cpajak_5.png", "GIORGIE CPAJAK", "17th century", "Romanticism")
            };
            return exhibits;
        }
    }
}
