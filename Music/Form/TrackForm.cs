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
    public partial class TrackForm : Form
    {
        public TrackForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string startdir = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            //openFileDialog1.InitialDirectory = startdir;
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    MessageBox.Show(openFileDialog1.FileName);
            //    tbtrackimage.Text = openFileDialog1.FileName;
            //}
            DialogResult dlgres = openFileDialog1.ShowDialog();
            if (dlgres != DialogResult.Cancel)
            {
                tbtrackimage.Text = openFileDialog1.FileName;
            }
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            private Track track = Track.Instance;
            track.CreateTrack(tbtitel.Text, tblengte.Text, tbdatrelease.Text, tbproducer.Text, tbtaal.Text,
                              tbyoutube.Text);
        }

        private void btannuleren_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
