using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;


namespace Music
{
    public class SQLService
    {
        // gegevens vooraf declareren
        private string databaseString =
            @"Provider=Microsoft.SQLSERVER.CE.OLEDB.4.0;Data Source=|DataDirectory|\MusicIndexDataSet.sdf";

        private OleDbConnection connectie;
        private DataTable tabel;

        //Verbinding maken met de database, gebruikmakende van de OleDbConnectie en de databasestring
        public SQLService()
        {
            try
            {
                connectie = new OleDbConnection(databaseString);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Het commando om een Insert query aan te maken
        /// </summary>
        /// <param name="commando">het INSERT commando</param>
        public void Insert(string commando)
        {
            try
            {
                // Definieer het command en de adapter
                OleDbCommand insertCommand = new OleDbCommand();
                OleDbDataAdapter adapter = new OleDbDataAdapter();

                // Open de connectie
                connectie.Open();

                // Zet het commando in de adapter
                insertCommand.Connection = connectie;
                insertCommand.CommandText = commando;
                adapter.InsertCommand = insertCommand;

                // Execute het commando
                adapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("SQL DONE\n\r" + commando);
            }

                // Catch de exception indien deze ontstaat.
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
                //Uiteindelijk de SQL Connectie weer sluiten
            finally
            {
                connectie.Close();
            }

        }

        /// <summary>
        /// Methode om een update SQL statement uit te voeren
        /// </summary>
        /// <param name="command">Typ hier het UPDATE commando in</param>
        public void Update(string command)
        {
            try
            {
                OleDbCommand updateCommand = new OleDbCommand();
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                connectie.Open();

                // put the command in the adapter
                updateCommand.Connection = connectie;
                updateCommand.CommandText = command;
                adapter.UpdateCommand = updateCommand;

                // do the update
                adapter.UpdateCommand.ExecuteNonQuery();
                connectie.Close();



            }
            catch (Exception obj)
            {
                MessageBox.Show(obj.Message);
            }
            finally
            {
                connectie.Close();
            }

        }

        /// <summary>
        /// Methode om te controleren of EEN variable bestaat of niet, returend een bool
        /// </summary>
        /// <param name="command">SELECT</param>
        public bool Bestaat(string command)
        {

            tabel = new DataTable();

            OleDbDataAdapter adapter = new OleDbDataAdapter(command, databaseString);
            tabel.Clear();
            int count = adapter.Fill(tabel);

            return count != 0;

        }

        public List<string[]> Gettabel(string commando)
        {
            tabel = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(commando, databaseString);
            tabel.Clear();
            adapter.Fill(tabel);

            List<string[]> inhoud = new List<string[]>();
            string[] veldnaam = new string[tabel.Columns.Count];
            for (int i = 0; i < tabel.Columns.Count; i++)
            {
                veldnaam[i] = tabel.Columns[i].ColumnName;
            }
            inhoud.Add(veldnaam);
            string[] rij;
            for (int i = 0; i < tabel.Rows.Count; i++)
            {
                rij = new string[tabel.Columns.Count];
                for (int j = 0; j < tabel.Columns.Count; j++)
                {
                    rij[j] = tabel.Rows[i][j].ToString();
                }
                inhoud.Add(rij);
            }
            return inhoud;
        }

        }
    }
