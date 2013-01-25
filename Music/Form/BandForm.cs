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
    public partial class BandForm : Form
    {
        public BandForm()
        {
            InitializeComponent();
        }

        private void btopenfiledialog_Click(object sender, EventArgs e)
        {
            string startdir = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog1.InitialDirectory = startdir;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbbandimage.Text = openFileDialog1.FileName;
            }
        }

        private void bt_annuleren_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime bandopgericht = DateTime.ParseExact(tbbandopgericht.Text, "dd/MM/yyyy", null);
                DateTime bandgestopt = DateTime.ParseExact(tbbandgestopt.Text, "dd/MM/yyyy", null);

                SQLService sqlService = new SQLService();
                if (
                    sqlService.Bestaat("SELECT band_naam FROM band WHERE band_naam = '" + tbbandnaam.Text +"' ") == true)
                {
                    throw new ExistsException("band");
                }
                sqlService.Insert("INSERT INTO band (band_naam,band_opgericht_datum,band_stop_datum,band_biografie,band_oorsprong) VALUES ('" + tbbandnaam.Text + "','" + bandopgericht + "','" + bandgestopt + "','" + tbbandbiografie.Text + "','" + tbbandoorsprong.Text + "')");
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

        private void BandForm_Load(object sender, EventArgs e)
        {
        

        }
    }
}
