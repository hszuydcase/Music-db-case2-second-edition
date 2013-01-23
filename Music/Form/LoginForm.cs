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
         try
         {
             SQLService sqlService = new SQLService();
             bool bestaat = sqlService.Bestaat("SELECT * FROM gebruiker WHERE username = '" + inputUsername.Text + "' AND password = '" + inputPassword.Text + "' ");

             if (bestaat == false)
             {
                 MessageBox.Show("Gegevens zijn niet bekend.");
             }
             else
             {
                 
                MessageBox.Show("Welkom terug " + inputUsername.Text + "");
                
                 this.Close();
             }
         }
         catch (Exception)
         {

             throw;
         }
     }

      private void btRegistreer_Click(object sender, EventArgs e)
      {
          RegistreerForm form = new RegistreerForm();
          form.ShowDialog();
      }

    }
}
