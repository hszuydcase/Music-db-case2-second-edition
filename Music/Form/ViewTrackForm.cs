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
            string command =
                "SELECT track_id, titel, lengte, datum_uitgebracht, producer, taal, youtube_link FROM track  WHERE track_id = "+ track_id +";";

            string [] list = sql.GetAllElements(command);

            lbTitel.Text = list[1];
            lbLengte.Text = list[2];
            lbDatum.Text = list[3];
            lbProducer.Text = list[4];
            lbTaal.Text = list[5];
            lbYoutube.Text = list[6];
        }
    }
}
