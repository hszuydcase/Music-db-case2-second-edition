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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbalbumdat = new System.Windows.Forms.MaskedTextBox();
            this.tbalbumimage = new System.Windows.Forms.TextBox();
            this.tbalbumnaam = new System.Windows.Forms.TextBox();
            this.btannuleren = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.btbrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.cbmedium = new System.Windows.Forms.ComboBox();
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
            // tbalbumdat
            // 
            this.tbalbumdat.Location = new System.Drawing.Point(118, 86);
            this.tbalbumdat.Mask = "00/00/0000";
            this.tbalbumdat.Name = "tbalbumdat";
            this.tbalbumdat.Size = new System.Drawing.Size(146, 20);
            this.tbalbumdat.TabIndex = 4;
            this.tbalbumdat.ValidatingType = typeof(System.DateTime);
            // 
            // tbalbumimage
            // 
            this.tbalbumimage.Location = new System.Drawing.Point(118, 123);
            this.tbalbumimage.Name = "tbalbumimage";
            this.tbalbumimage.Size = new System.Drawing.Size(261, 20);
            this.tbalbumimage.TabIndex = 5;
            // 
            // tbalbumnaam
            // 
            this.tbalbumnaam.Location = new System.Drawing.Point(118, 50);
            this.tbalbumnaam.Name = "tbalbumnaam";
            this.tbalbumnaam.Size = new System.Drawing.Size(146, 20);
            this.tbalbumnaam.TabIndex = 6;
            // 
            // btannuleren
            // 
            this.btannuleren.Location = new System.Drawing.Point(146, 237);
            this.btannuleren.Name = "btannuleren";
            this.btannuleren.Size = new System.Drawing.Size(75, 23);
            this.btannuleren.TabIndex = 7;
            this.btannuleren.Text = "Annuleren";
            this.btannuleren.UseVisualStyleBackColor = true;
            this.btannuleren.Click += new System.EventHandler(this.button1_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(255, 237);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(75, 23);
            this.btadd.TabIndex = 8;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.button2_Click);
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
            // cbmedium
            // 
            this.cbmedium.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmedium.FormattingEnabled = true;
            this.cbmedium.Items.AddRange(new object[] {
            "Vynil",
            "Casette",
            "CD"});
            this.cbmedium.Location = new System.Drawing.Point(118, 160);
            this.cbmedium.Name = "cbmedium";
            this.cbmedium.Size = new System.Drawing.Size(121, 21);
            this.cbmedium.TabIndex = 14;
            // 
            // AlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 273);
            this.Controls.Add(this.cbmedium);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btbrowse);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.btannuleren);
            this.Controls.Add(this.tbalbumnaam);
            this.Controls.Add(this.tbalbumimage);
            this.Controls.Add(this.tbalbumdat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AlbumForm";
            this.Text = "Album";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tbalbumdat;
        private System.Windows.Forms.TextBox tbalbumimage;
        private System.Windows.Forms.TextBox tbalbumnaam;
        private System.Windows.Forms.Button btannuleren;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btbrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbmedium;
    }
}