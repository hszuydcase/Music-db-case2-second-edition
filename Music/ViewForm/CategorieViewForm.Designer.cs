﻿namespace Music
{
    partial class CategorieViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musicIndexDataSetDataSet = new Music.MusicIndexDataSetDataSet();
            this.musicIndexDataSetDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicIndexDataSetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicIndexDataSetDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.musicIndexDataSetDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(801, 468);
            this.dataGridView1.TabIndex = 0;
            // 
            // musicIndexDataSetDataSet
            // 
            this.musicIndexDataSetDataSet.DataSetName = "MusicIndexDataSetDataSet";
            this.musicIndexDataSetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musicIndexDataSetDataSetBindingSource
            // 
            this.musicIndexDataSetDataSetBindingSource.DataSource = this.musicIndexDataSetDataSet;
            this.musicIndexDataSetDataSetBindingSource.Position = 0;
            // 
            // CategorieViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 466);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CategorieViewForm";
            this.Text = "CategorieView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicIndexDataSetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicIndexDataSetDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource musicIndexDataSetDataSetBindingSource;
        private MusicIndexDataSetDataSet musicIndexDataSetDataSet;
    }
}