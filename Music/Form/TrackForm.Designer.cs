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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.chkArtiest = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
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
            this.label5.Location = new System.Drawing.Point(319, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Producer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Taal";
            // 
            // cbalbum
            // 
            this.cbalbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbalbum.FormattingEnabled = true;
            this.cbalbum.Location = new System.Drawing.Point(391, 118);
            this.cbalbum.Name = "cbalbum";
            this.cbalbum.Size = new System.Drawing.Size(156, 21);
            this.cbalbum.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 121);
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
            this.tbproducer.Location = new System.Drawing.Point(391, 31);
            this.tbproducer.Name = "tbproducer";
            this.tbproducer.Size = new System.Drawing.Size(156, 20);
            this.tbproducer.TabIndex = 13;
            // 
            // tbtaal
            // 
            this.tbtaal.Location = new System.Drawing.Point(391, 76);
            this.tbtaal.Name = "tbtaal";
            this.tbtaal.Size = new System.Drawing.Size(156, 20);
            this.tbtaal.TabIndex = 14;
            // 
            // tbyoutube
            // 
            this.tbyoutube.Location = new System.Drawing.Point(391, 248);
            this.tbyoutube.Name = "tbyoutube";
            this.tbyoutube.Size = new System.Drawing.Size(156, 20);
            this.tbyoutube.TabIndex = 15;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(540, 304);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 16;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btannuleren
            // 
            this.btannuleren.Location = new System.Drawing.Point(621, 304);
            this.btannuleren.Name = "btannuleren";
            this.btannuleren.Size = new System.Drawing.Size(75, 23);
            this.btannuleren.TabIndex = 17;
            this.btannuleren.Text = "Annuleren";
            this.btannuleren.UseVisualStyleBackColor = true;
            this.btannuleren.Click += new System.EventHandler(this.btannuleren_Click);
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
            this.tblengte.Mask = "00:00:00";
            this.tblengte.Name = "tblengte";
            this.tblengte.Size = new System.Drawing.Size(128, 20);
            this.tblengte.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(319, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Artiest";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 21);
            this.button2.TabIndex = 26;
            this.button2.Text = "new";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(569, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 21);
            this.button3.TabIndex = 27;
            this.button3.Text = "new";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(569, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 21);
            this.button4.TabIndex = 28;
            this.button4.Text = "new";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(207, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "http://www.youtube.com/watch?v=";
            // 
            // chkArtiest
            // 
            this.chkArtiest.FormattingEnabled = true;
            this.chkArtiest.Location = new System.Drawing.Point(391, 160);
            this.chkArtiest.Name = "chkArtiest";
            this.chkArtiest.Size = new System.Drawing.Size(156, 79);
            this.chkArtiest.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(251, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(251, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(251, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 17);
            this.label13.TabIndex = 38;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(251, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 17);
            this.label14.TabIndex = 39;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(550, 160);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 17);
            this.label15.TabIndex = 40;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(550, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 17);
            this.label16.TabIndex = 41;
            this.label16.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(550, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 17);
            this.label17.TabIndex = 42;
            this.label17.Text = "*";
            // 
            // TrackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 339);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.chkArtiest);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
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
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox chkArtiest;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}