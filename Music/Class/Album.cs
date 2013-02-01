using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    class Album
    {
        
        public void CreateAlbum(string datum, string naam, string medium, string image)
        {
            try
            {
                SQLService sqlService = new SQLService();
                
                DateTime albumdat;
                string format = "dd/MM/yyyy";
                
                if (!DateTime.TryParseExact(datum, format, CultureInfo.InvariantCulture,
                    DateTimeStyles.None, out albumdat))
                {
                    throw new FormatException("Dit is geen geldige datum: dd/mm/yyyy");
                } 
         
                if (naam == "" || medium == "")
                {
                    throw new NullReferenceException("Alle velden moeten worden ingevult.");
                }
             
                

                    sqlService.Insert("INSERT INTO album (album_naam,album_datum,album_medium, album_image) VALUES ('" + naam + "','" +
                                      albumdat + "','" + medium + "', '"+ image +"')");
            }

            catch (NullReferenceException obj)
            {
                MessageBox.Show(obj.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
        public int GetAlbumId(string combo)
        {
            SQLService sqlService = new SQLService();

            int albid;

            if (combo == "" || combo == " ")
            {
                albid = 0;
            }
            else
            {
                albid =
                    Convert.ToInt32(
                        sqlService.ReturnFirstValue(
                            "SELECT album_id, album_naam FROM album WHERE (album_naam = '" +
                            combo + "')"));
                
            }
            return albid;
        }

    }
}
