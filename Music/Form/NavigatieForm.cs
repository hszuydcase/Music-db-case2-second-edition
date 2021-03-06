﻿using System;
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
        private Track track = Track.Instance;

        public NavigatieForm()
        {
            InitializeComponent();
            lbUsername.Text = "Username:" + user.GetUsername() + "\r\nId:" + Convert.ToString(user.GetId());
            dataGridView1.Width = this.Width;
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
            sqlService.FillTable("SELECT cat_id ID, cat_naam Naam FROM categorie", dataGridView1);
            GridviewClick = "categorie";
        }

        private void btAlbum_Click(object sender, EventArgs e)
        {
            SQLService sqlService = new SQLService();
            sqlService.FillTable("SELECT album_id ID, album_naam Naam, album_datum Uitgebracht, album_medium Medium FROM album", dataGridView1);
            GridviewClick = "album";
        }

        private void btartiest_Click(object sender, EventArgs e)
        {
            SQLService sqlService = new SQLService();
            sqlService.FillTable("SELECT artiest_id ID, artiest_naam Artiestennaam, voornaam Voornaam, achternaam Achternaam, geb_datum Geboortedatum, geb_plaats Geboorteplaats, geb_land Geboorteland FROM artiest" , dataGridView1);
            GridviewClick = "artiest";
        }

        private void bttrack_Click(object sender, EventArgs e)
        {
            SQLService sqlService = new SQLService();
            sqlService.FillTable("SELECT track_id ID, titel Titel, lengte Lengte, datum_uitgebracht Uitgebracht, producer Producer, taal Taal, youtube_link Link FROM track", dataGridView1);
            GridviewClick = "track";
        }

        private void btbandview_Click(object sender, EventArgs e)
        {
            SQLService sqlService = new SQLService();
            sqlService.FillTable("SELECT band_id ID, band_naam Naam, band_opgericht_datum Opgericht, band_stop_datum Gestopt, band_oorsprong Oorsprong FROM band", dataGridView1);
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

        }

        private void NavigatieForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            user.Logout();
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
        }

        private void dataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show("Row Header Double click");
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_row_clicked;
            id_row_clicked = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            
            switch (GridviewClick)
            {
                case "band":
                    MessageBox.Show("band");
                    break;
                case "track":
                    track.SetTrackId(id_row_clicked);
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
    }
}
