using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
