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
    public partial class CategorieForm : Form
    {
        public CategorieForm()
        {
            InitializeComponent();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            SQLService sqlService = new SQLService();
            sqlService.Insert("INSERT INTO categorie (cat_naam) VALUES ('" + tbcategorie.Text + "')");
        }
    }
}
