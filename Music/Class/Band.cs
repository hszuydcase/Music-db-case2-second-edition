using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Music
{
    public class Band
    {
        public void CreateBand(string bandnaam, string bandopgerichtdatum, string bandstopdatum, string oorsprong)
        {
            try
            {
                SQLService sqlService = new SQLService();

                DateTime bandopgdat = new DateTime();
                DateTime bandstopdat = new DateTime();
                string format = "dd/MM/yyyy";

                if (!DateTime.TryParseExact(bandopgerichtdatum, format, CultureInfo.InvariantCulture,
                                            DateTimeStyles.None, out bandopgdat))
                {
                    throw new FormatException("Dit is geen geldige datum: dd/mm/yyyy");
                }
                if (!DateTime.TryParseExact(bandstopdatum, format, CultureInfo.InvariantCulture,
                                            DateTimeStyles.None, out bandstopdat))
                {
                    throw new FormatException("Dit is geen geldige datum: dd/mm/yyyy");
                }

                if (bandnaam == "" || oorsprong == "")
                {
                    throw new NullReferenceException("Alle velden moeten worden ingevult.");
                }
                sqlService.Insert(
                    "INSERT INTO band (band_naam,band_opgericht_datum,band_stop_datum,band_oorsprong) VALUES ('" +
                    bandnaam + "','" +
                    bandopgerichtdatum + "','" + bandstopdatum + "','" + oorsprong + "')");
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


