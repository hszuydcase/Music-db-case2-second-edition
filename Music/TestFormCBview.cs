using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Music
{
    public partial class TestFormCBview : Form
    {
        public TestFormCBview()
        {
            InitializeComponent();
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            SQLService sqlService = new SQLService();
            sqlService.FillTable("SELECT Album_ID FROM Album", dataGridView1);
        }

        private void cbfrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string from = cbfrom.Text;
            TestClassView test = new TestClassView();
            switch (from)
            {
                case "Artiest":
                    cbselect.DataSource = test.Artiest();
                    break;
                case "Album":
                    cbselect.DataSource = test.Album();
                    break;
                case "Band":
                    cbselect.DataSource = test.Band();
                    break;
                case "Categorie":
                    cbselect.DataSource = test.Categorie();
                    break;
                case "Track":
                    cbselect.DataSource = test.Track();
                    break;
            }
        }
    }
}
