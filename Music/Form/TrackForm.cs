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
    public partial class TrackForm : Form
    {
        private Track track = Track.Instance;
        public TrackForm()
        {
            InitializeComponent();
            SQLService sqlService = new SQLService();
            sqlService.Fillcombo("SELECT cat_naam FROM categorie", cbcategorie, "cat_naam","cat_id", false);
            sqlService.Fillcombo("SELECT album_naam  FROM album", cbalbum, "album_naam","album_id", true);
            sqlService.Fillcombo("SELECT artiest_naam FROM artiest", cbartiest, "artiest_naam", "artiest_id", false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string startdir = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            //openFileDialog1.InitialDirectory = startdir;
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    MessageBox.Show(openFileDialog1.FileName);
            //    tbtrackimage.Text = openFileDialog1.FileName;
            //}
            DialogResult dlgres = openFileDialog1.ShowDialog();
            if (dlgres != DialogResult.Cancel)
            {
                tbtrackimage.Text = openFileDialog1.FileName;
            }
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            Image plaatje = new Image();

            string name = plaatje.GetImage();
            string aidsgedoe = cbalbum.Text;
            plaatje.Saveimage(openFileDialog1);
            track.CreateTrack(tbtitel.Text, tblengte.Text, tbdatrelease.Text, tbproducer.Text, tbtaal.Text,
                tbyoutube.Text, cbcategorie.Text, cbalbum.Text, name );
        }

        private void btannuleren_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AlbumForm form = new AlbumForm();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ArtiestForm form = new ArtiestForm();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategorieForm form = new CategorieForm();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
    }
}
