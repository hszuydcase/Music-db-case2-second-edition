namespace Music
{
    partial class TrackForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbalbum = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbtitel = new System.Windows.Forms.TextBox();
            this.tbtrackimage = new System.Windows.Forms.TextBox();
            this.tbproducer = new System.Windows.Forms.TextBox();
            this.tbtaal = new System.Windows.Forms.TextBox();
            this.tbyoutube = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btannuleren = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.cbcategorie = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbdatrelease = new System.Windows.Forms.MaskedTextBox();
            this.tblengte = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lengte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Track image";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum release";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Producer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Taal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Youtube link";
            // 
            // cbalbum
            // 
            this.cbalbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbalbum.FormattingEnabled = true;
            this.cbalbum.Location = new System.Drawing.Point(391, 164);
            this.cbalbum.Name = "cbalbum";
            this.cbalbum.Size = new System.Drawing.Size(156, 21);
            this.cbalbum.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Album";
            // 
            // tbtitel
            // 
            this.tbtitel.Location = new System.Drawing.Point(117, 34);
            this.tbtitel.Name = "tbtitel";
            this.tbtitel.Size = new System.Drawing.Size(128, 20);
            this.tbtitel.TabIndex = 9;
            // 
            // tbtrackimage
            // 
            this.tbtrackimage.Location = new System.Drawing.Point(117, 120);
            this.tbtrackimage.Name = "tbtrackimage";
            this.tbtrackimage.Size = new System.Drawing.Size(128, 20);
            this.tbtrackimage.TabIndex = 11;
            // 
            // tbproducer
            // 
            this.tbproducer.Location = new System.Drawing.Point(391, 37);
            this.tbproducer.Name = "tbproducer";
            this.tbproducer.Size = new System.Drawing.Size(156, 20);
            this.tbproducer.TabIndex = 13;
            // 
            // tbtaal
            // 
            this.tbtaal.Location = new System.Drawing.Point(391, 83);
            this.tbtaal.Name = "tbtaal";
            this.tbtaal.Size = new System.Drawing.Size(156, 20);
            this.tbtaal.TabIndex = 14;
            // 
            // tbyoutube
            // 
            this.tbyoutube.Location = new System.Drawing.Point(391, 120);
            this.tbyoutube.Name = "tbyoutube";
            this.tbyoutube.Size = new System.Drawing.Size(156, 20);
            this.tbyoutube.TabIndex = 15;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(294, 250);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 16;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btannuleren
            // 
            this.btannuleren.Location = new System.Drawing.Point(173, 250);
            this.btannuleren.Name = "btannuleren";
            this.btannuleren.Size = new System.Drawing.Size(75, 23);
            this.btannuleren.TabIndex = 17;
            this.btannuleren.Text = "Annuleren";
            this.btannuleren.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 21);
            this.button1.TabIndex = 18;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbcategorie
            // 
            this.cbcategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcategorie.FormattingEnabled = true;
            this.cbcategorie.Location = new System.Drawing.Point(117, 203);
            this.cbcategorie.Name = "cbcategorie";
            this.cbcategorie.Size = new System.Drawing.Size(131, 21);
            this.cbcategorie.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Categorie";
            // 
            // tbdatrelease
            // 
            this.tbdatrelease.Location = new System.Drawing.Point(117, 161);
            this.tbdatrelease.Mask = "00/00/0000";
            this.tbdatrelease.Name = "tbdatrelease";
            this.tbdatrelease.Size = new System.Drawing.Size(128, 20);
            this.tbdatrelease.TabIndex = 22;
            this.tbdatrelease.ValidatingType = typeof(System.DateTime);
            // 
            // tblengte
            // 
            this.tblengte.Location = new System.Drawing.Point(117, 76);
            this.tblengte.Mask = "00:00";
            this.tblengte.Name = "tblengte";
            this.tblengte.Size = new System.Drawing.Size(128, 20);
            this.tblengte.TabIndex = 23;
            // 
            // TrackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 285);
            this.Controls.Add(this.tblengte);
            this.Controls.Add(this.tbdatrelease);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbcategorie);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btannuleren);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbyoutube);
            this.Controls.Add(this.tbtaal);
            this.Controls.Add(this.tbproducer);
            this.Controls.Add(this.tbtrackimage);
            this.Controls.Add(this.tbtitel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbalbum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TrackForm";
            this.Text = "Track";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbalbum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbtitel;
        private System.Windows.Forms.TextBox tbtrackimage;
        private System.Windows.Forms.TextBox tbproducer;
        private System.Windows.Forms.TextBox tbtaal;
        private System.Windows.Forms.TextBox tbyoutube;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btannuleren;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbcategorie;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox tbdatrelease;
        private System.Windows.Forms.MaskedTextBox tblengte;
    }
}