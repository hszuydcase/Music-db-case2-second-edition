using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public partial class AlbumForm : Form
    {
        public AlbumForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Album album = new Album();
            Image plaatje = new Image();

            string name = plaatje.GetPath();

            album.CreateAlbum(inputDatum.Text,inputNaam.Text, inputMedium.SelectedText, name);
            plaatje.Saveimage(openFileDialog1);
            
        }

        private void btbrowse_Click(object sender, EventArgs e)
        {
            string startdir = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog1.InitialDirectory = startdir;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbalbumimage.Text = openFileDialog1.FileName;
            }
        }
        
        }
    }
