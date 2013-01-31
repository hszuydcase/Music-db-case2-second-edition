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
    public partial class EditTrackForm : Form
    {
        // Class instance aanroepen.
        private User user = User.Instance;
        private Track track = Track.Instance;

        public EditTrackForm()
        {
            InitializeComponent();

            SQLService sql = new SQLService();

            int track_id = track.GetTrackId();
            string gebruikersnaam = user.GetUsername();

            // Track en Categorie
            string command = "SELECT Track.track_id, Track.titel, Track.lengte, Track.datum_uitgebracht, Track.producer, Track.taal, Track.youtube_link, categorie.cat_naam, Track.track_image " +
                            "FROM Track INNER JOIN cat_tra ON Track.track_id = cat_tra.track_id INNER JOIN categorie ON cat_tra.cat_id = categorie.cat_id " +
                            "WHERE (Track.track_id = " + track_id + ")";

            string[] list = sql.GetAllElements(command);

            tbTitel.Text = list[1];
            this.Text = list[1];
            tbLengte.Text = list[2];
            tbDatrelease.Text = list[3];
            tbProducer.Text = list[4];
            tbTaal.Text = list[5];
            tbYoutube.Text = list[6];

            // Comboboxen

            
            sql.Fillcombo("SELECT categorie.cat_naam FROM Track INNER JOIN cat_tra ON Track.track_id = cat_tra.track_id INNER JOIN categorie ON cat_tra.cat_id = categorie.cat_id WHERE Track.track_id = "+ track_id + "", cbCategorie, "cat_naam");
            sql.Fillcombo("SELECT album_naam album_id FROM album", cbalbum, "album_naam", "album_id");
            sql.Fillcombo("SELECT artiest_naam artiest_id FROM artiest", cbartiest, "artiest_naam", "artiest_id");
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            SQLService sqlService = new SQLService();
            int track_id = track.GetTrackId();
            
            string deleteCommand = "DELETE FROM track WHERE track_id = " + track_id + "";

            sqlService.Delete(deleteCommand);
        }
    }
}
