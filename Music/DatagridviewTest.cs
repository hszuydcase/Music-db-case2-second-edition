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
    public partial class DatagridviewTest : Form
    {
        public int author;

        public DatagridviewTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Product ID";
            dataGridView1.Columns[1].Name = "Product Name";
            dataGridView1.Columns[2].Name = "Product Price";

            string[] row = new string[] { "1", "Product 1", "1000" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "2", "Product 2", "2000" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "3", "Product 3", "3000" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "4", "Product 4", "4000" };
            dataGridView1.Rows.Add(row);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string test;
            test = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);

            label1.Text = Convert.ToString(test);
        }
    }
}
