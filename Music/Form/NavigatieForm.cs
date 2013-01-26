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
    public partial class NavigatieForm : Form
    {
        public NavigatieForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            lbUsername.Text = User.GetUsername();


        }

        private void btart_Click(object sender, EventArgs e)
        {
            ArtiestForm form = new ArtiestForm();
            form.ShowDialog();
        }

        private void btband_Click(object sender, EventArgs e)
        {
            BandForm form = new BandForm();
            form.ShowDialog();
        }

        private void btcat_Click(object sender, EventArgs e)
        {
            CategorieForm form = new CategorieForm();
            form.ShowDialog();
        }

        private void bttra_Click(object sender, EventArgs e)
        {
            TrackForm form = new TrackForm();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Logout();
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumForm form = new AlbumForm();
            form.ShowDialog();
        }

        private void btcatview_Click(object sender, EventArgs e)
        {
            CategorieViewForm form = new CategorieViewForm();
            form.ShowDialog();
        }

        private void NavigatieForm_Load(object sender, EventArgs e)
        {

        }
    }
}
