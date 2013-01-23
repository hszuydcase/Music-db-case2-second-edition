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
                if (sqlService.Bestaat("SELECT username FROM gebruiker WHERE username = '" + inputUsername.Text + "' ") == true)
                {
                    throw new ExistsException("username");
                }
                else if (sqlService.Bestaat("SELECT username FROM gebruiker WHERE email = '" + inputEmail.Text + "'") == true)
                {
                    throw new ExistsException("email adres");
                }
                else if (inputUsername.TextLength <= 6)
                {
                    throw new FormatException("Username moet langer dan 6 tekens zijn");
                }
                else if (inputPassword.TextLength <= 6)
                {
                    throw new FormatException("Password moet langer dan 6 tekens zijn");
                }
                

                sqlService.Insert("INSERT INTO gebruiker (username,password,user_voornaam,user_achternaam,email,admin_level) VALUES ('" + inputUsername.Text + "', '" + inputPassword.Text + "','" + inputVoornaam.Text + "','" + inputAchternaam.Text + "','" + inputEmail.Text + "',1) ");
            }
            catch (ExistsException obj)
            {
                MessageBox.Show(obj.Message + " is al reeds in gebruik", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (FormatException obj)
            {
                MessageBox.Show(obj.Message);
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
