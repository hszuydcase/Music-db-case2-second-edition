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
            string from = cbFrom.SelectedText;
            string select = cbselect.SelectedText;
            string where = cbwhere.SelectedText;

            string query = "SELECT" + select + "FROM" + From + "WHERE" + where;

            switch (from)
            {
                case cbFrom.SelectedText = "Artiest")
                    cbselect.Text = "Artiest_naam";
                    break;
            }
        }
    }
}
