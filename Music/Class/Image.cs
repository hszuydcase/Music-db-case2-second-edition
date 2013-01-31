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
        private string image, path = Path.GetDirectoryName(Application.ExecutablePath) + @"\images";

        public void Saveimage(OpenFileDialog openFileDialog)
        {
            try
            {
                // Bron bestand en eind directory
                string sourceFile = openFileDialog.FileName;
                string destinationPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\images";
                
                // Hier verkrijgen we de path en file name
                FileInfo fInfo = new FileInfo(sourceFile);
                string strFileName = fInfo.Name;
                string strFilePath = fInfo.DirectoryName;

                // Als de directory images niet bestaat, aanmaken.
                if (!Directory.Exists(destinationPath)) 
                {
                Directory.CreateDirectory(destinationPath);
                }

                //Kopieren kan beginnen.
                File.Copy(sourceFile, Path.Combine(destinationPath, strFileName), true);
                this.image = strFileName;
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }
        }

        public string GetImage()
        {
            return this.image;
        }
        public string GetPath()
        {
            return this.path;
        }

    }
}