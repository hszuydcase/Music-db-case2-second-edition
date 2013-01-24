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
              try
            {
                DateTime albumdat = DateTime.ParseExact(tbalbumdat.Text, "dd/MM/yyyy", null);

                SQLService sqlService = new SQLService();
                if (
                    sqlService.Bestaat("SELECT album_naam FROM album WHERE album_naam = '" + tbalbumnaam.Text +"' ") == true)
                {
                    throw new ExistsException("album");
                }
                sqlService.Insert("INSERT INTO album (album_naam,album_datum,album_image,album_medium) VALUES ('" + tbalbumnaam.Text + "','" + albumdat + "','" + tbalbumimage.Text + "','" + cbmedium.Text + "')");
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
