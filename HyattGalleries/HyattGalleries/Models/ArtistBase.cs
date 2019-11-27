using System;
using System.Collections.Generic;
using System.Text;

namespace HyattGalleries.Models
{
    class ArtistBase
    {
        private static ArtistBase instance;

        private Dictionary<string, string> artistBios;

        private ArtistBase()
        {
            artistBios = new Dictionary<string, string>
            {
                {"ALEKOS TZOMAKAS", "Alekos Tzomakas was born in 1977 in Ioannina, but has lived most of his life in Athens. He studied two years painting and drawing in architecture school and freehand “Plaka” and then marble sculpture at the “School of Fine Arts Panormos Tinos”. He also has a degree of sculpture from the Academy of Fine Arts in Florence. He lives and works in Greece and Italy. He has worked as an assistant to Christos Lambrou, in Antonio Di Tomasso and Antonio Bianci. He has participated in many international sculpture symposiums."},
                {"ANDONIS MAGKRIOTIS", "Andonis Magkriotis was born in Draviskos village of Serres, Greece. He studied at the Military Academy, and in addition graduated from the School of Civil Engineering. He is now studying Fine Arts at the Department of Fine and Applied Arts of the Aristotle University and the Laboratory of Sculpture in the laboratory of Professor George Tsaras. He has taken lessons in iconography. He took part in the “XV Biennale de la Mediterranee” 2011, Thessaloniki, as head of the lab students Industrial Design of Fig Cal Arts. He received, together with his group members, honors from Aristotle for the design and implementation of the “Fairing design of the formula of the Aristotle Racing team (ART)”. He also took part in the competition TRA(N)SHFORMATION, the “Eco Art Festival” at the National Museum of Contemporary Art. He lives and works in Thessaloniki."},
                {"EDWARD FLEMING", "Edward Fleming carves and teaches realistic human figurative sculpture and also abstract sculpture in marble and limestone through direct carving. His work is traditional in technique and attention to anatomical detail but his subjects are contemporary. Fleming creates both self-directed and commissioned sculptures. He is a licensed Architect and has been making stone sculpture since 1993. His art education derives from 20 years of working and apprenticing with master carvers and other artists in Italy and the United States. Edward Fleming is a full-time professional sculptor since 2001 and teaches stone sculpture since 2007. He joined the Initiative as a result of our international call for entries.He was positive from the beginning and very enthusiastic about working in Greece, embracing the very essence of the Initiative as a platform to connect sculptors worldwide.Edward joined the Greek Marble Initiative during its first Symposium, in the summer of 2013.He has exhibited successfully with the Initiative’s exhibitions many times, and he is one of the first full associates of the Greek Marble Initiative and one of our most celebrated partners"},
                {"GIANNIS BIZAS", "Giannis Bizas was born in Hios, in 1980 and early on he showed an interest in painting and sculpture. He followed lessons of sculpture initially in Florence and he completed his studies in Accademia di Belli Arti, in Carrara of Italy. The material that particularly fascinates him is marble, which he carves in a special way. The use of marble in the artistic creations of Bizas is always symbolic. The place where the sculpture will be placed has a significant meaning since it is connected contextually to the artwork, as part of the real world. Moreover the impact of the light on the thinly worked piece creates a transparency on the texture of the marble which allows the eye of the viewer to penetrate the figure. He draws his themes by everyday life. Giannis Bizas embraced the Greek Marble Initiative concept and  was involved with its actions since the beginning. He has exhibited on various occasions with the Initiative and is a full associate."},
                {"GIORGIE CPAJAK", "Giorgie Cpajak was born in Yugoslavia in 1961 and is a world renowned sculptor in marble and stone. He graduated from the Higher School of Design and Arts of Split of Yugoslavia, and in 1989 received a Master of Fine Arts from the University of Belgrade. Since 1990 he is a visiting professor of the Academy of Fine Arts in Stockholm in Sweden, where he teaches contemporary sculpture in stone. In 1989 he moved and lives permanently in Pietrasanta, Italy. His works are in museums around the world in leading collections and he has won awards in many countries for his work. He joined the Initiative as a result of our international call for entries.He was positive from the beginning and very enthusiastic about working in Greece, embracing the very essence of the Initiative as a platform to connect sculptors worldwide.Giorgie joined the Greek Marble Initiative during its first Symposium, in the summer of 2013.He has exhibited successfully with the Initiative's exhibitions many times, and he is one of the first full associates of the Greek Marble Initiative and one of our most celebrated partners."}
            };
        }

        public static ArtistBase GetInstance()
        {
            if (instance is null) instance = new ArtistBase();
            return instance;
        }

        // Returns the artist biography
        public string GetArtistBio(string name)
        {
            return artistBios[name];
        }
    }
}
