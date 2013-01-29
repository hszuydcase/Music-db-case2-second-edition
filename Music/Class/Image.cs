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
        public void Saveimage()

        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                string sourceFile = openFileDialog.FileName;
                string destinationFile = @"Source=|DataDirectory|\images";
                File.Copy(sourceFile, destinationFile);
            }
            catch (Exception exc)
            {
                            
                throw;
            }


            // To move a file or folder to a new location:
            

            // To move an entire directory. To programmatically modify or combine 
            // path strings, use the System.IO.Path class.
            //Directory.Move(@"C:\Users\Public\public\test\", @"C:\Users\Public\private");
        }
    }
}