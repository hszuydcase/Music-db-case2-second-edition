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
    public partial class NavigatieForm : Form
    {
        public NavigatieForm()
        {
            InitializeComponent();
        }

        private void NavigatieForm_Load(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.ShowDialog();
            
        }
    }
}
