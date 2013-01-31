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
    public partial class ViewTrackForm : Form
    {
        // Class instance aanroepen.
        private User user = User.Instance;
        private Track track = Track.Instance;


        public ViewTrackForm()
        {
            InitializeComponent();
            
            SQLService sql = new SQLService();

            int track_id = track.GetTrackId();
            string gebruikersnaam = user.GetUsername();

            // Track en Categorie
            string command ="SELECT Track.track_id, Track.titel, Track.lengte, Track.datum_uitgebracht, Track.producer, Track.taal, Track.youtube_link, categorie.cat_naam, Track.track_image " +
                            "FROM Track INNER JOIN cat_tra ON Track.track_id = cat_tra.track_id INNER JOIN categorie ON cat_tra.cat_id = categorie.cat_id " +
                            "WHERE (Track.track_id = "+ track_id +")";
   
            string [] list = sql.GetAllElements(command);

            lbTitel.Text = list[1];
            this.Text = list[1];
            lbLengte.Text = list[2];
            lbDatum.Text = list[3];
            lbProducer.Text = list[4];
            lbTaal.Text = list[5];
            lbCategorie.Text = list[7];
            
         
            //Image

            if (list[8] != "")
            {
                Image plaatje = new Image();
                string path = plaatje.GetPath() + "\\"+ list[8];
                trackImage.SizeMode = PictureBoxSizeMode.StretchImage;
                trackImage.Image = new Bitmap(path);
            }
            else
            {
                trackImage.Hide();
            }

            //Youtube
            if (list[6] != "")
            {
                wbYoutube.Navigate("http://www.youtube.com/embed/"+ list[6] +"");
            }
            else
            {
                this.Height = this.Height -300;
                wbYoutube.Hide();
            }
            

            // Album

            string command2 = " SELECT Album.album_naam FROM Track INNER JOIN alb_tra ON Track.track_id = alb_tra.track_id INNER JOIN Album ON alb_tra.album_id = Album.album_id WHERE (Track.track_id = " + track_id + ")";
            
            string [] list2 = sql.GetAllElements(command2);
            lbAlbum.Text = list2[0];

            // Artiesten

            sql.FillListBox("SELECT artiest.artiest_naam FROM Track INNER JOIN art_tra ON Track.track_id = art_tra.track_id INNER JOIN artiest ON art_tra.artiest_id = artiest.artiest_id WHERE (Track.track_id = " + track_id + ")", lbArtiest, "artiest_naam");


            // Rating

            string command4 =
                "SELECT AVG(Rating.rating_cijfer) AS Expr1 FROM Track INNER JOIN Rating ON Track.track_id = Rating.track_id " +
                "WHERE (Track.track_id = " + track_id + ")";
            string[] list4 = sql.GetAllElements(command4);
            lbRating.Text = list4[0];

            // Favorieten

            string command5 = "SELECT        COUNT(favoriet.track_id) AS Expr1 " +
                              "FROM Track INNER JOIN favoriet ON Track.track_id = favoriet.track_id" +
                              " WHERE (Track.track_id = " + track_id + ")";
            string[] list5 = sql.GetAllElements(command5);
            lbFavoriet.Text = list5[0];

            // Band

            string command6 = "SELECT Band.band_naam " +
                              "FROM Track INNER JOIN band_tra ON Track.track_id = band_tra.track_id INNER JOIN Band ON band_tra.band_id = Band.band_id " +
                              "WHERE (Track.track_id = " + track_id + ")";
            string[] list6 = sql.GetAllElements(command6);
            lbband.Text = list6[0];

        }

        private void btFavoriet_Click(object sender, EventArgs e)
        {
            Favoriet fav = new Favoriet();
            fav.BtFavoriet();
        }
    }
}
