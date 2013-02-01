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
            sqlService.Fillcombo("SELECT cat_naam FROM categorie", cbcategorie, false);
            sqlService.Fillcombo("SELECT album_naam  FROM album", cbalbum, true);
            sqlService.FillCheckedList("SELECT artiest_naam FROM artiest", chkArtiest);

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            
            int count = chkArtiest.CheckedItems.Count;
            string[] artiesten = new string[count];
            int i = 0;

            foreach (string itemChecked in chkArtiest.CheckedItems)
            {
                artiesten[i] = itemChecked;
                i++;
            }

            

            plaatje.Saveimage(openFileDialog1);
            track.CreateTrack(tbtitel.Text, tblengte.Text, tbdatrelease.Text, tbproducer.Text, tbtaal.Text,
                tbyoutube.Text, cbcategorie.Text, cbalbum.Text, name);
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


    }
}
