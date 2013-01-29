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
            Band band = new Band();
            band.CreateBand(tbbandnaam.Text,tbbandopgericht.Text,tbbandgestopt.Text,tbbandoorsprong.Text);
            Image image = new Image();
            image.Saveimage();
        }
    }
}
