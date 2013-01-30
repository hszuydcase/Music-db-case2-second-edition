using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Music
{
    public sealed class Track
    {
        private static readonly Track instance = new Track();
        private int _current_track_id;
        private string _track_name;

        // Explicit static constructor to tell C# compiler 
        // not to mark type as beforefieldinit
        static Track()
        {
        }

        private Track()
        {
        }

        public static Track Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Methode om een nieuwe track aan te maken
        /// </summary>
        /// <param name="titel"></param>
        /// <param name="lengte"></param>
        /// <param name="datumuitgebracht"></param>
        /// <param name="producer"></param>
        /// <param name="taal"></param>
        /// <param name="youtubelink"></param>
        public void CreateTrack(string titel, string lengte, string datumuitgebracht, string producer, string taal, string youtubelink, string categorie, string album, ComboBox combocat, ComboBox comboalbum)
        {
            try
            {
                SQLService sqlService = new SQLService();

                DateTime datrelease = new DateTime();
                DateTime lengtetrack = new DateTime();
                string lengteformat = "HH:MM:SS";
                string format = "dd/MM/yyyy";
                Object lul = new object();
                lul = combocat.SelectedValue;
                Object lul2 = new object();
                lul2 = comboalbum.SelectedValue;
                if (!DateTime.TryParseExact(datumuitgebracht, format, CultureInfo.InvariantCulture,
                                            DateTimeStyles.None, out datrelease))
                {
                    throw new FormatException("Dit is geen geldige datum: dd/mm/yyyy");
                }

                if (titel == "" || lengte == "" || datumuitgebracht == "" || producer == "" || taal == "" || youtubelink == "" || categorie == "" || album == "")
                {
                    throw new NullReferenceException("Alle velden moeten worden ingevult.");
                }
                sqlService.Insert(
                    "INSERT INTO track (lengte, titel, datum_uitgebracht, producer, taal, youtube_link) VALUES ('" + lengte + "','" +
                    titel + "','" + datrelease + "','" + producer + "','" + taal + "','" + youtubelink + "')");
                sqlService.Insert("INSERT INTO cat_tra (cat_id, track_id) VALUES ('" + lul +  "','" + "1" + "')");
                sqlService.Insert("INSERT INTO alb_tra (album_id,track_id) VALUES ('" + lul2 + "','" + "1" + "')");
                 
            }

            catch (NullReferenceException obj)
            {
                MessageBox.Show(obj.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
            }
            catch (FormatException obj)
            {
                MessageBox.Show(obj.Message);
            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
        }
        /// <summary>
        /// Methode om de track id te krijgen.
        /// </summary>
        /// <returns></returns>
        public int GetTrackId()
        {
            return this._current_track_id;
        }

        public string GetTrackName()
        {
            SQLService sqlService = new SQLService();
            this._track_name =
                sqlService.ReturnFirstValue("Select titel FROM track WHERE track_id = '" + this.GetTrackId() + "'");
            return this._track_name;
        }
        /// <summary>
        /// Methode om de track id te setten.
        /// </summary>
        /// <param name="id">ID van de track.</param>
        public void SetTrackId(int id)
        {
            this._current_track_id = id;
        }

   

    }
}
