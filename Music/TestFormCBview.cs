﻿using System;
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
            SQLService sqlService = new SQLService();
            VulDGV(dataGridView1, "SELECT " + cbselect.Text + "FROM " +cbfrom.Text);

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

        private void VulDGV(DataGridView dgv, string sqlCommand)
        {
            SQLService sqlService = new SQLService();
            List<string[]> content = sqlService.Gettabel(sqlCommand);
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            for (int i = 0; i < content[0].Length; i++)
            {
                dgv.Columns.Add(content[0][i], content[0][i]);
            }
            for (int i = 1; i < content.Count; i++)
            {
                dgv.Rows.Add(content[i]);
            }
        }
    }
}
