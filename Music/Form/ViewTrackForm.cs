using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        private string databaseString = @"Provider=Microsoft.SQLSERVER.CE.OLEDB.4.0;Data Source=|DataDirectory|\MusicIndexDataSet.sdf";

        public ViewTrackForm()
        {
            InitializeComponent();

            SQLService sql = new SQLService();

            string gebruikersnaam = user.GetUsername();
            string id = null;
            string command =
                "SELECT user_id, password, user_voornaam, user_achternaam, email FROM gebruiker where username = '" +
                gebruikersnaam + "' ";

            sql.GetAllElements(command);
           
            


            

            //string datum_bezocht = DateTime.Now.ToString("dd:MM:yyyy HH:mm:ss tt");
            //sql.Insert("INSERT INTO geschiedenis (user_id, track_id, datum_bezocht) VALUES  ");
        }
    }
}
