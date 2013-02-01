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
    public partial class ArtiestForm : Form
    {
        public ArtiestForm()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            Artiest artiest = new Artiest();
            artiest.CreateArtist(tbartiestennaam.Text, tbvoornaam.Text, tbachternaam.Text, tbgebdat.Text,
                                 tbgebplaats.Text, tbgebland.Text);
        }

        private void bt_annuleren_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }   
}
