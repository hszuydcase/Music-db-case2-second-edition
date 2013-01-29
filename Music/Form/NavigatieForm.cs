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
    public partial class NavigatieForm : Form
    {
        private string GridviewClick;
        private User user = User.Instance;
        public NavigatieForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            lbUsername.Text = user.GetUsername();
        }

        private void btart_Click(object sender, EventArgs e)
        {
            ArtiestForm form = new ArtiestForm();
            form.ShowDialog();
        }

        private void btband_Click(object sender, EventArgs e)
        {
            BandForm form = new BandForm();
            form.ShowDialog();
        }

        private void btcat_Click(object sender, EventArgs e)
        {
            CategorieForm form = new CategorieForm();
            form.ShowDialog();
        }

        private void bttra_Click(object sender, EventArgs e)
        {
            TrackForm form = new TrackForm();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            user.Logout();
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumForm form = new AlbumForm();
            form.ShowDialog();
        }

        private void btcatview_Click(object sender, EventArgs e)
        {
            SQLService sqlService = new SQLService();
            sqlService.FillTable("SELECT cat_id, cat_naam FROM categorie", dataGridView1);
            GridviewClick = "categorie";
        }

        private void btAlbum_Click(object sender, EventArgs e)
        {
            SQLService sqlService = new SQLService();
            sqlService.FillTable("SELECT album_id, album_naam, album_datum, album_medium FROM album", dataGridView1);
            GridviewClick = "album";
        }

        private void btartiest_Click(object sender, EventArgs e)
        {
            SQLService sqlService = new SQLService();
            sqlService.FillTable("SELECT artiest_id, artiest_naam, voornaam, achternaam, geb_datum, geb_plaats, geb_land FROM artiest" , dataGridView1);
            GridviewClick = "artiest";
        }

        private void bttrack_Click(object sender, EventArgs e)
        {
            SQLService sqlService = new SQLService();
            sqlService.FillTable("SELECT track_id, titel, lengte, datum_uitgebracht, producer, taal, youtube_link FROM track", dataGridView1);
            GridviewClick = "track";
        }

        private void btbandview_Click(object sender, EventArgs e)
        {
            SQLService sqlService = new SQLService();
            sqlService.FillTable("SELECT band_id, band_naam, band_opgericht_datum, band_stop_datum, band_oorsprong FROM band", dataGridView1);
            GridviewClick = "band";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void NavigatieForm_Load(object sender, EventArgs e)
        {

            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user.Logout();
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
        }

        private void btDatagvTest_Click(object sender, EventArgs e)
        {
            DatagridviewTest form = new DatagridviewTest();
            form.ShowDialog();
        }

        private void NavigatieForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            switch (GridviewClick)
            {
                case "band":
                    MessageBox.Show("band");
                    break;
                case "track":
                    MessageBox.Show("track");
                    ViewTrackForm form = new ViewTrackForm();
                    form.ShowDialog();
                   
                    break;
                case "artiest":
                    MessageBox.Show("artiest");
                    break;
                case "album":
                    MessageBox.Show("album");
                    break;
                case "categorie":
                    MessageBox.Show("Categorie");
                    break;
            }
        }

        private void NavigatieForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            user.Logout();
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
        }
    }
}
