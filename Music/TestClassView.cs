using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    public class TestClassView
    {
        public List<string> Artiest()
        {
            List<string> Artiest = new List<string>();
            Artiest.Add("*");
            Artiest.Add("Artiest_ID");
            Artiest.Add("Artiest_naam");
            Artiest.Add("Voornaam");
            Artiest.Add("Achternaam");
            Artiest.Add("Geb_datum");
            Artiest.Add("Geb_plaats");
            return Artiest;
        }
        public  List<string> Album()
        {
            List<string> Album = new List<string>();
            Album.Add("*");
            Album.Add("Album_ID");
            Album.Add("Album_naam");
            Album.Add("Album_datum");
            Album.Add("Album_medium");
            Album.Add("Album_image");
            return Album;
        }
        public List<string> Band()
        {
            List<string> Band = new List<string>();
            Band.Add("*");
            Band.Add("Band_ID");
            Band.Add("Band_opgericht_datum");
            Band.Add("Band_stop_datum");
            Band.Add("band_biografie");
            Band.Add("band_oorsprong");
            return Band;
        }
        public List<string> Categorie()
        {
            List<string> Categorie = new List<string>();
            Categorie.Add("*");
            return Categorie;
        }
        public List<string> Track()
        {
            List<string> Track = new List<string>();
            Track.Add("*");
            Track.Add("Track_ID");
            Track.Add("Titel");
            Track.Add("Track_image");
            Track.Add("Datum_uitgebracht");
            Track.Add("producer");
            Track.Add("Taal");
            Track.Add("Youtube_link");
            return Track;
        }
    }
}
