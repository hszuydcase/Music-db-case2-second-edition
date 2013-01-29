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
        private User user = User.Instance;
        public ViewTrackForm()
        {
            InitializeComponent();
            SQLService sql = new SQLService();

            string gebruikersnaam = user.GetUsername();
            string id = null;
            string command =
                "SELECT track_id, titel, lengte, datum_uitgebracht, producer, taal, youtube_link FROM track WHERE track_id = 1;";

            string [] list = sql.GetAllElements(command);

            
        }
    }
}
