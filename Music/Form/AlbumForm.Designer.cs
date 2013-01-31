namespace Music
{
    partial class AlbumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputDatum = new System.Windows.Forms.MaskedTextBox();
            this.tbalbumimage = new System.Windows.Forms.TextBox();
            this.inputNaam = new System.Windows.Forms.TextBox();
            this.btAnnuleren = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btbrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.inputMedium = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum release";
            // 
            // inputDatum
            // 
            this.inputDatum.Location = new System.Drawing.Point(118, 86);
            this.inputDatum.Mask = "00/00/0000";
            this.inputDatum.Name = "inputDatum";
            this.inputDatum.Size = new System.Drawing.Size(68, 20);
            this.inputDatum.TabIndex = 4;
            this.inputDatum.ValidatingType = typeof(System.DateTime);
            // 
            // tbalbumimage
            // 
            this.tbalbumimage.Location = new System.Drawing.Point(118, 123);
            this.tbalbumimage.Name = "tbalbumimage";
            this.tbalbumimage.Size = new System.Drawing.Size(261, 20);
            this.tbalbumimage.TabIndex = 5;
            // 
            // inputNaam
            // 
            this.inputNaam.Location = new System.Drawing.Point(118, 50);
            this.inputNaam.Name = "inputNaam";
            this.inputNaam.Size = new System.Drawing.Size(146, 20);
            this.inputNaam.TabIndex = 6;
            // 
            // btAnnuleren
            // 
            this.btAnnuleren.Location = new System.Drawing.Point(336, 237);
            this.btAnnuleren.Name = "btAnnuleren";
            this.btAnnuleren.Size = new System.Drawing.Size(75, 23);
            this.btAnnuleren.TabIndex = 7;
            this.btAnnuleren.Text = "Annuleren";
            this.btAnnuleren.UseVisualStyleBackColor = true;
            this.btAnnuleren.Click += new System.EventHandler(this.button1_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(255, 237);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btbrowse
            // 
            this.btbrowse.Location = new System.Drawing.Point(376, 123);
            this.btbrowse.Name = "btbrowse";
            this.btbrowse.Size = new System.Drawing.Size(28, 20);
            this.btbrowse.TabIndex = 9;
            this.btbrowse.Text = "...";
            this.btbrowse.UseVisualStyleBackColor = true;
            this.btbrowse.Click += new System.EventHandler(this.btbrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Medium";
            // 
            // inputMedium
            // 
            this.inputMedium.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputMedium.FormattingEnabled = true;
            this.inputMedium.Items.AddRange(new object[] {
            "Vynil",
            "Casette",
            "CD"});
            this.inputMedium.Location = new System.Drawing.Point(118, 160);
            this.inputMedium.Name = "inputMedium";
            this.inputMedium.Size = new System.Drawing.Size(121, 21);
            this.inputMedium.TabIndex = 14;
            // 
            // AlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 273);
            this.Controls.Add(this.inputMedium);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btbrowse);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btAnnuleren);
            this.Controls.Add(this.inputNaam);
            this.Controls.Add(this.tbalbumimage);
            this.Controls.Add(this.inputDatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlbumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Album";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox inputDatum;
        private System.Windows.Forms.TextBox tbalbumimage;
        private System.Windows.Forms.TextBox inputNaam;
        private System.Windows.Forms.Button btAnnuleren;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btbrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox inputMedium;
    }
}