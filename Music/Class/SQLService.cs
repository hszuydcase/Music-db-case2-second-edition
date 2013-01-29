using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Collections;


namespace Music
{
    public class SQLService
    {
        // gegevens vooraf declareren
        private string databaseString = @"Provider=Microsoft.SQLSERVER.CE.OLEDB.4.0;Data Source=|DataDirectory|\MusicIndexDataSet.sdf";

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
        /// <summary>
        /// methode om de datagridview te vullen met de aangegeven database gegevens.
        /// </summary>
        /// <param name="command">SQL query waarmee je de opdracht geeft</param>
        /// <param name="dataGridView">het object datagridview die gevult wordt met de data</param>
        public void FillTable(string command, DataGridView dataGridView)
        {
            try
            {
                OleDbDataAdapter adapter;
                DataTable table = new DataTable();
                adapter = new OleDbDataAdapter(command,databaseString);
                adapter.Fill(table);
                dataGridView.DataSource = table;
            }
            catch (Exception obj)
            {

                MessageBox.Show(obj.Message);
            }
        }

        public void GetAllElements(string sqlcommand)
        {
            try
            {
                OleDbCommand Olecommand = new OleDbCommand();
                connectie.Open();

                Olecommand.Connection = connectie;
                Olecommand.CommandText = sqlcommand;
                OleDbDataReader reader = Olecommand.ExecuteReader();

                int RowCount = reader.VisibleFieldCount;
                string[] list = new string[RowCount];
                int i = 0;
                string value;

                while (reader.Read())
                {
                    for (int j = 0; j < RowCount; j++)
                    {
                        value = Convert.ToString(reader.GetValue(i));
                        list[i] = value;
                        i++;
                    } 
                }
                
                    

              
                reader.Close();
                Olecommand.Dispose();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connectie.Close();
            }
        }
    }
}