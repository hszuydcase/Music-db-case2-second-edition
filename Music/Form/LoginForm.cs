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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

 


     private void btLogin_Click_1(object sender, EventArgs e)
     {
         User user = User.Instance;
         bool ingelogd = user.Login(inputUsername.Text, inputPassword.Text);
         
         if (ingelogd == true)
         {
             NavigatieForm form = new NavigatieForm();
             form.Show();
             this.Hide();
         }
     }

      private void btRegistreer_Click(object sender, EventArgs e)
      {
          RegistreerForm form = new RegistreerForm();
          form.ShowDialog();
      }

      private void btCancel_Click(object sender, EventArgs e)
      {
          this.Close();
      }

    }
}
