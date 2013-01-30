using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    // hier wordt gebruik gemaakt van het zogehete SingeleTon Model/Patroon.
    public sealed class User
    {
        private static readonly User instance = new User();
        private string _username;
        private int _id;


        // Explicit static constructor to tell C# compiler 
        // not to mark type as beforefieldinit
        static User()
        {
        }

        private User()
        {
        }

        public static User Instance
        {
            get { return instance; }
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
       /// <summary>
       /// Module om in te loggen en de gegevens van de gebruiker op te slaan.
       /// </summary>
       /// <param name="username">username</param>
       /// <param name="password">Password </param>
       /// <returns>Returned een bool</returns>
        public bool Login(string username, string password)
        {

            try
            {
                SQLService sqlService = new SQLService();
                bool bestaat = sqlService.Bestaat("SELECT * FROM gebruiker WHERE username = '" + username + "' AND password = '" + password + "' ");
                bool ingelogd = false;
                if (bestaat == false)
                {
                    MessageBox.Show("Gegevens zijn niet bekend.");

                }
                else
                {
                    this._username = username;
                    this._id = Convert.ToInt32(sqlService.ReturnFirstValue("Select user_id FROM gebruiker WHERE username = '" + username + "'"));
                    ingelogd = true;
                }
                return ingelogd;
            }
            catch (ArgumentNullException)
            {

                MessageBox.Show("U moet een gebruikersnaam en wachtwoord invoeren. Als u niet geregistreerd bent klink dan op de knop \"registreer\".");
                return false;
            }
        }

        public string GetUsername()
        {
            return this._username;
        }

        public int GetId()
        {
            return this._id;
        }

        public void Logout()
        {
            this._username = "";
            this._id = 0;

        }

    }
}