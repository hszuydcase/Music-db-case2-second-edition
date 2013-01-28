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
            string gebruikersnaam = user.GetUsername();
            string id = null;

            SQLService sql = new SQLService();
            string datum_bezocht = DateTime.Now.ToString("dd:MM:yyyy HH:mm:ss tt");
            sql.Insert("INSERT INTO geschiedenis (user_id, track_id, datum_bezocht) VALUES  ");
        }
    }
}
