using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Music
{
    public class Categorie
    {
        public void CreateCategorie(string categorienaam)
        {
            try
            {
                SQLService sqlService = new SQLService();
      
                if (categorienaam == "" )
                {
                    throw new NullReferenceException("Alle velden moeten worden ingevult.");
                }
                    sqlService.Insert("INSERT INTO categorie (cat_naam) VALUES ('" + categorienaam +"')");
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
                    public int Getcatid(ComboBox combo)
                    {
                        SQLService sqlService = new SQLService();
                        int catid =
                            Convert.ToInt32(
                                sqlService.ReturnFirstValue(
                                    "SELECT cat_id, cat_naam FROM categorie WHERE (cat_naam = '" +
                                    combo.SelectedValue + "')"));
                        return catid;
                    }
    }
}
