namespace Music
{
    partial class TestFormCBview
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
            this.cbfrom = new System.Windows.Forms.ComboBox();
            this.cbselect = new System.Windows.Forms.ComboBox();
            this.cbwhere = new System.Windows.Forms.ComboBox();
            this.From = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btsearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.musicIndexDataSetDataSet = new Music.MusicIndexDataSetDataSet();
            this.musicIndexDataSetDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicIndexDataSetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicIndexDataSetDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.musicIndexDataSetDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 228);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbfrom
            // 
            this.cbfrom.AutoCompleteCustomSource.AddRange(new string[] {
            "Album",
            "Artiest",
            "Band",
            "Categorie",
            "Track"});
            this.cbfrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfrom.FormattingEnabled = true;
            this.cbfrom.Items.AddRange(new object[] {
            "Album",
            "Artiest",
            "Band",
            "Categorie",
            "Track"});
            this.cbfrom.Location = new System.Drawing.Point(12, 76);
            this.cbfrom.Name = "cbfrom";
            this.cbfrom.Size = new System.Drawing.Size(121, 21);
            this.cbfrom.TabIndex = 1;
            this.cbfrom.SelectedIndexChanged += new System.EventHandler(this.cbfrom_SelectedIndexChanged);
            // 
            // cbselect
            // 
            this.cbselect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbselect.FormattingEnabled = true;
            this.cbselect.Location = new System.Drawing.Point(174, 76);
            this.cbselect.Name = "cbselect";
            this.cbselect.Size = new System.Drawing.Size(121, 21);
            this.cbselect.TabIndex = 2;
            // 
            // cbwhere
            // 
            this.cbwhere.FormattingEnabled = true;
            this.cbwhere.Location = new System.Drawing.Point(341, 76);
            this.cbwhere.Name = "cbwhere";
            this.cbwhere.Size = new System.Drawing.Size(121, 21);
            this.cbwhere.TabIndex = 3;
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Location = new System.Drawing.Point(9, 60);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(30, 13);
            this.From.TabIndex = 4;
            this.From.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select";
            // 
            // btsearch
            // 
            this.btsearch.Location = new System.Drawing.Point(559, 76);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(75, 23);
            this.btsearch.TabIndex = 7;
            this.btsearch.Text = "search";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Where";
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
            // TestFormCBview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 380);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.From);
            this.Controls.Add(this.cbwhere);
            this.Controls.Add(this.cbselect);
            this.Controls.Add(this.cbfrom);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TestFormCBview";
            this.Text = "TestFormCBview";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicIndexDataSetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicIndexDataSetDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbfrom;
        private System.Windows.Forms.ComboBox cbselect;
        private System.Windows.Forms.ComboBox cbwhere;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource musicIndexDataSetDataSetBindingSource;
        private MusicIndexDataSetDataSet musicIndexDataSetDataSet;
    }
}