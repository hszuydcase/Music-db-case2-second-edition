using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Music
{
   public class Image
    {
        //Open file in to a filestream and read data in a byte array.
        public static byte[] ReadFile(string sPath)
        {
            //Initialize byte array with a null value initially.
            byte[] data = null;

            //Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to supply number of bytes to read from file.
            //In this case we want to read entire file. So supplying total number of bytes.
            data = br.ReadBytes((int)numBytes);
            return data;
        }

       public void Save(string insertintotable, string inserintocolumn, TextBox imageTextBox)
       {
           try
           {
               //Read Image Bytes into a byte array
               byte[] imageData = ReadFile(imageTextBox.Text);

               //Initialize SQL Server Connection
               SqlConnection CN = new SqlConnection(@"Provider=Microsoft.SQLSERVER.CE.OLEDB.4.0;Data Source=|DataDirectory|\MusicIndexDataSet.sdf");

               //Set insert query
               string qry = "insert into "+ insertintotable +" ("+ inserintocolumn +") values(@OriginalPath, @ImageData)";

               //Initialize SqlCommand object for insert.
               SqlCommand SqlCom = new SqlCommand(qry, CN);

               //We are passing Original Image Path and Image byte data as sql parameters.
               SqlCom.Parameters.Add(new SqlParameter("@OriginalPath", (object)imageTextBox.Text));
               SqlCom.Parameters.Add(new SqlParameter("@ImageData", (object)imageData));

               //Open connection and execute insert query.
               CN.Open();
               SqlCom.ExecuteNonQuery();
               CN.Close();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString());
           }
       }
    }
}
