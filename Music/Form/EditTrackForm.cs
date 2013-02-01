using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private Categorie categorie = new Categorie();
        private Album album = new Album();
        private Band band = new Band();
        private Artiest artist = new Artiest();

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
            tbtrackimage.Text = list[8];

            // Comboboxen


            sql.Fillcombo("SELECT cat_naam  FROM categorie", cbCategorie, false);
            sql.Fillcombo("SELECT album_naam FROM album", cbAlbum, true);
            sql.Fillcombo("SELECT band_naam FROM band", cbBand, true);

            string catnaam = sql.ReturnFirstValue("SELECT categorie.cat_naam FROM Track INNER JOIN cat_tra ON Track.track_id = cat_tra.track_id INNER JOIN categorie ON cat_tra.cat_id = categorie.cat_id WHERE Track.track_id = " + track_id + "");
            cbCategorie.SelectedItem = catnaam;

            string albumnaam = sql.ReturnFirstValue("SELECT Album.album_naam FROM Track INNER JOIN alb_tra ON Track.track_id = alb_tra.track_id INNER JOIN Album ON alb_tra.album_id = Album.album_id WHERE Track.track_id = " + track_id + "");
            cbAlbum.SelectedItem = albumnaam;

            string bandnaam = sql.ReturnFirstValue("SELECT Band.band_naam FROM Track INNER JOIN band_tra ON Track.track_id = band_tra.track_id INNER JOIN Band ON band_tra.band_id = Band.band_id WHERE Track.track_id = " + track_id + "");
            cbBand.SelectedItem = bandnaam;


            // Checked listbox
            sql.FillCheckedList("SELECT artiest_naam FROM artiest", chkArtiest);



            
      
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {


                SQLService sqlService = new SQLService();
                // categorie, album en band comboxen value
                string catnaam = Convert.ToString(cbCategorie.Text);
                string albnaam = Convert.ToString(cbAlbum.Text);
                string bandnaam = Convert.ToString(cbBand.Text);
                




                //Datum format.
                string datumuitgebracht = tbDatrelease.Text;
                DateTime datrelease = new DateTime();
                string format = "dd/MM/yyyy";
                if (!DateTime.TryParseExact(datumuitgebracht, format, CultureInfo.InvariantCulture,
                                            DateTimeStyles.None, out datrelease))
                {
                    throw new FormatException("Dit is geen geldige datum: dd/mm/yyyy");
                }

                // Als deze noodzakelijk gegevens leeg zijn een exception throwen
                if (tbDatrelease.Text == "" || tbLengte.Text == "" || tbProducer.Text == "" || tbTaal.Text == "" ||
                    tbTitel.Text == "")
                {
                    throw new NullReferenceException("Allen noodzakelijke velden moeten worden ingevuld");
                }
                if (chkArtiest.CheckedItems.Count <= 0)
                {
                    throw new NullReferenceException("Er moet minstens 1 artiest worden gekozen.");
                }
                // BAND 
                // BAND is leeg maar bestaat wel:delete
                if (bandnaam == "" && (sqlService.Bestaat("SELECT track_id FROM band_tra WHERE track_id = " + track.GetTrackId() + " ")) )
                {
                    sqlService.Delete("DELETE FROM band_tra WHERE track_id = " + track.GetTrackId() + " ");
                }
                // BAND is niet leeg en bestond niet:insert
                if (bandnaam != "" && (sqlService.Bestaat("SELECT track_id FROM band_tra WHERE track_id = " + track.GetTrackId() + " ")) == false)
                {
                    sqlService.Insert("INSERT INTO band_tra (band_id, track_id) VALUES ('" + band.GetbandId(bandnaam) + "', '" + track.GetTrackId() + "') ");
                }
                // BAND is niet leeg en bestaat wel:update
                if (bandnaam != "" && (sqlService.Bestaat("SELECT track_id FROM band_tra WHERE track_id = " + track.GetTrackId() + " ")))
                {
                    sqlService.Update("UPDATE band_tra SET band_id =" + band.GetbandId(bandnaam) + " WHERE track_id = " + track.GetTrackId() + " ");
                }

                // ALBUM
                // ALBUM is leeg maar bestaat wel:delete
                if (albnaam == "" && (sqlService.Bestaat("SELECT track_id FROM alb_tra WHERE track_id = " + track.GetTrackId() + " ")))
                {
                    sqlService.Delete("DELETE FROM alb_tra WHERE track_id = " + track.GetTrackId() + " ");
                }

                // ALBUM is niet leeg en bestond niet:insert
                if (albnaam != "" && (sqlService.Bestaat("SELECT track_id FROM alb_tra WHERE track_id = " + track.GetTrackId() + " ")) == false)
                {
                    sqlService.Insert("INSERT INTO alb_tra (album_id, track_id) VALUES ('" + album.GetAlbumId(bandnaam) + "', '" + track.GetTrackId() + "') ");
                }

                // ALBUM is niet leeg en bestaat wel:update
                if (albnaam != "" && (sqlService.Bestaat("SELECT track_id FROM alb_tra WHERE track_id = " + track.GetTrackId() + " ")))
                {
                    sqlService.Update("UPDATE alb_tra SET album_id =" + album.GetAlbumId(bandnaam) + " WHERE track_id = " + track.GetTrackId() + " ");
                }

               // ARTIEST
               // ARTIEST

               // artiesten
                int countArtieste = chkArtiest.Items.Count;
                string[] artiesten = new string[countArtieste];
                int i = 0;

                foreach (string itemChecked in chkArtiest.Items)
                {
                    artiesten[i] = itemChecked;
                    i++;
                }

                //artiesten check
                int countCheckedArtieste = chkArtiest.CheckedItems.Count;
                string[] artiestenChecked = new string[countCheckedArtieste];
                int u = 0;

                foreach (string itemChecked in chkArtiest.CheckedItems)
                {
                    artiestenChecked[u] = itemChecked;
                    u++;
                }

                    // niet gechecked en wel in database:delete
                foreach (string artiest2 in artiesten)
                {
                      sqlService.Delete("DELETE FROM art_tra WHERE track_id ='" +
                                              track.GetTrackId() + "' AND artiest_id = '" + artist.GetArtiestId(artiest2) + "' ");
                   
                }
                foreach (string artiest in artiestenChecked)
                    {

                        // ARTIEST is leeg maar bestaat niet:insert
                        if (
                            (sqlService.Bestaat("SELECT artiest_id FROM art_tra WHERE track_id = " + track.GetTrackId() +
                                                " and artiest_id = " + artist.GetArtiestId(artiest) + " ") == false))
                        {
                            sqlService.Insert("INSERT INTO art_tra (track_id, artiest_id) VALUES ('" +
                                              track.GetTrackId() + "', '" + artist.GetArtiestId(artiest) + "') ");
                            MessageBox.Show(artiest + "INSERT");
                        }
                        // WLE IN DATABASE NIET GECHECKED:delete

                    }







                    //CAT moet altijd bestaan:update
                sqlService.Update("UPDATE cat_tra SET cat_id = " + categorie.Getcatid(catnaam) + " WHERE track_id = " + track.GetTrackId() + " ");
                

                
               // sqlService.Update("UPDATE art_tra SET artiest_id =" + artiest.GetArtiestId(artiestnaam) + " WHERE track_id = " + track.GetTrackId() + " ");
            }
            catch (NullReferenceException obj)
                {
                    MessageBox.Show(obj.Message);
                }
                catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }

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
