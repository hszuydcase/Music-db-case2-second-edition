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
    public partial class CategorieViewForm : Form
    {
        public CategorieViewForm()
        {
            InitializeComponent();

        }
        private void fillDataGridView(DataGridView dgv, string sqlcommando)
        {
            SQLService sqlService = new SQLService();
            List<string[]> content = sqlService.Gettabel(sqlcommando);
            dgv.Rows.Clear();
            dgv.Columns.Clear();

        }
    }
}
