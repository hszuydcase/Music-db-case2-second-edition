using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Music
{
    public class Track
    {
        public void CreateTrack(string titel, string lengte,string datumuitgebracht,string youtubelink)
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
                if (!DateTime.TryParseExact(lengte, lengteformat, CultureInfo.InvariantCulture,
                                            DateTimeStyles.None, out lengtetrack))
                {
                    throw new FormatException("Dit is geen geldige tijd: HH:MM:SS met een maximaal bereik van 23:59:59");
                }

                if (titel == "" || lengte == "" || datumuitgebracht == "" || youtubelink == "")
                {
                    throw new NullReferenceException("Alle velden moeten worden ingevult.");
                }
                sqlService.Insert(
                    "INSERT INTO band (band_naam,band_opgericht_datum,band_stop_datum,band_oorsprong) VALUES ('" +
                    titel + "','" + lengte + "','" + datumuitgebracht + "','" + youtubelink + "')");
                 
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
    }
}
