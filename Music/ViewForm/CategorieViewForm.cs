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
            SQLService sqlService = new SQLService();
            sqlService.fillDataGridView(dataGridView1, "SELECT * FROM categorie");
        }
    }
}
