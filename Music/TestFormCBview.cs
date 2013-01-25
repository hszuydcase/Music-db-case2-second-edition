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
    public partial class TestFormCBview : Form
    {
        public TestFormCBview()
        {
            InitializeComponent();
        }

        private void btsearch_Click(object sender, EventArgs e)
        {

            string select = cbselect.SelectedText;
            string where = cbwhere.SelectedText;

            string query = "SELECT" + select + "FROM" + From + "WHERE" + where;

        }

        private void cbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string from = cbFrom.SelectedText;
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
