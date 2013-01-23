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
    public partial class RegistreerForm : Form
    {
        public RegistreerForm()
        {
            InitializeComponent();
        }

        private void btRegistreer_Click(object sender, EventArgs e)
        {
            try
            {
                SQLService sqlService = new SQLService();
                sqlService.Insert(
                    "INSERT INTO gebruiker (username,password,user_voornaam,user_achternaam,email,admin_level) VALUES ('Josh', 'Josh','Josh','Josh','Josh',1) ");
            }
            catch (Exception obj)
            {

                MessageBox.Show(obj.Message);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
