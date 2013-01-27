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

            User user = User.Instance;
            user.CreateUser(inputUsername.Text, inputPassword.Text, inputVoornaam.Text, inputAchternaam.Text, inputEmail.Text);
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
