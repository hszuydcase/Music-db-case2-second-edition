using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public partial class ArtiestForm : Form
    {
        public ArtiestForm()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            try
            {
                SQLService sqlService = new SQLService();
                if (
                    sqlService.Bestaat("SELECT artiest_naam FROM artiest WHERE artiest_naam = '" + tbartiestennaam.Text +
                                       "' ") == true)
                {
                    throw new ExistsException("artiest");
                }
                sqlService.Insert(
    "INSERT INTO artiest(artiest_naam,voornaam,achternaam,geb_dat,geb_plaats,geb_land,biografie) VALUES ('" +
    tbartiestennaam.Text + "','" + tbvoornaam.Text + "','" + tbachternaam.Text + "','" + tbgebdat.Text + "','" + tbgebplaats.Text + "','" + tbgebland.Text + "','" + tbbiografie.Text + "')");
            }
            catch (ExistsException obj)
            {
                MessageBox.Show(obj.Message + " is al reeds in gebruik", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
