using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public class Favoriet
    {
        public Favoriet()
        {
            
        }

        public void BtFavoriet()
        {
            Track track = Track.Instance;
            User user = User.Instance;
            SQLService sqlservice = new SQLService();
            
            int track_id = track.GetTrackId();
            int user_id = user.GetId();

            if (sqlservice.Bestaat("SELECT user_id FROM favoriet WHERE user_id = '" + user_id + "' AND track_id = '" +
                                   track_id + "' "))
            {
                
                DialogResult dr = MessageBox.Show("Je hebt al favoriet van '"+ track.GetTrackName() +"', wil je deze verwijderen?","Je bent al favoriet", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (dr == DialogResult.OK)
                {
                    sqlservice.Delete("DELETE FROM favoriet WHERE user_id = '" + user_id + "' AND track_id = '" +
                                     track_id + "'");  
                }
                
                
            }
            else
            {
                
                MessageBox.Show("Je bent favoriet gemaakt");
                sqlservice.Insert("INSERT INTO favoriet (track_id, user_id) VALUES (" + track_id +", "+ user_id +") ");
            }

            

        }
    }
}
