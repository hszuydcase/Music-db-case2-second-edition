using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public class User
    {
        private string _username, _password, _voornaam, _achternaam, _email;
        private int _admin_level, _id;

        // Constructor
        public User()
        {

        }
        /// <summary>
        /// Methode om een gebruiker aan te maken
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <param name="voornaam">Voornaam</param>
        /// <param name="achternaam">Achternaam</param>
        /// <param name="email">email adres</param>
        public void CreateUser(string username, string password, string voornaam, string achternaam, string email)
        {
            try
            {
                SQLService sqlService = new SQLService();
                if (sqlService.Bestaat("SELECT username FROM gebruiker WHERE username = '" + username + "' ") == true)
                {
                    throw new ExistsException("username");
                }
                else if (sqlService.Bestaat("SELECT username FROM gebruiker WHERE email = '" + email + "'") == true)
                {
                    throw new ExistsException("email adres");
                }
                else if (username.Length <= 6)
                {
                    throw new FormatException("Username moet langer dan 6 tekens zijn");
                }
                else if (username.Length <= 6)
                {
                    throw new FormatException("Password moet langer dan 6 tekens zijn");
                }
                else
                {
                    sqlService.Insert("INSERT INTO gebruiker (username,password,user_voornaam,user_achternaam,email,admin_level) VALUES ('" + username + "', '" + password + "','" + voornaam + "','" + achternaam + "','" + email + "',1) ");
                }


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

        public void Login(string username, string password)
        {
            
            try
            {
                SQLService sqlService = new SQLService();
                bool bestaat = sqlService.Bestaat("SELECT * FROM gebruiker WHERE username = '" + username + "' AND password = '" + password + "' ");
                if (bestaat == false)
                {
                    MessageBox.Show("Gegevens zijn niet bekend.");
                }
                else
                {

                    MessageBox.Show("Welkom " + username + "");
                        
                }
            }
            catch (ArgumentNullException)
            {

                MessageBox.Show("U moet een gebruikersnaam en wachtwoord invoeren. Als u niet geregistreerd bent klink dan op de knop \"registreer\".");
            }
        }

        public string GetUsername()
        {
            return this._username;
        }

        public void Logout()
        {
            this._id = 0;
        }
    }
}
