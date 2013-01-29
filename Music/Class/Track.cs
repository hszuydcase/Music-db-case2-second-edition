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
        public void CreateTrack(string titel, string lengte, string datumuitgebracht, string producer, string taal, string youtubelink)
        {
            try
            {
                SQLService sqlService = new SQLService();

                DateTime datrelease = new DateTime();
                DateTime lengtetrack = new DateTime();
                string lengteformat = "HH:MM:SS";
                string format = "dd/MM/yyyy";

                if (!DateTime.TryParseExact(datumuitgebracht, format, CultureInfo.InvariantCulture,
                                            DateTimeStyles.None, out datrelease))
                {
                    throw new FormatException("Dit is geen geldige datum: dd/mm/yyyy");
                }

                if (titel == "" || lengte == "" || datumuitgebracht == "" || producer == "" || taal == "" || youtubelink == "")
                {
                    throw new NullReferenceException("Alle velden moeten worden ingevult.");
                }
                sqlService.Insert(
                    "INSERT INTO track (titel, datum_uitgebracht, producer, taal, youtube_link) VALUES ('" +
                    titel + "','" + datrelease + "','" + producer + "','" + taal + "','" + youtubelink + "')");
                 
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
