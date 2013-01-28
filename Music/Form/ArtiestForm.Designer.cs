namespace Music
{
    partial class ArtiestForm
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
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_annuleren = new System.Windows.Forms.Button();
            this.tbartiestennaam = new System.Windows.Forms.TextBox();
            this.tbvoornaam = new System.Windows.Forms.TextBox();
            this.tbachternaam = new System.Windows.Forms.TextBox();
            this.tbgebplaats = new System.Windows.Forms.TextBox();
            this.tbgebland = new System.Windows.Forms.TextBox();
            this.tbbiografie = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbgebdat = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(313, 328);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 0;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_annuleren
            // 
            this.bt_annuleren.Location = new System.Drawing.Point(164, 328);
            this.bt_annuleren.Name = "bt_annuleren";
            this.bt_annuleren.Size = new System.Drawing.Size(75, 23);
            this.bt_annuleren.TabIndex = 1;
            this.bt_annuleren.Text = "Annuleren";
            this.bt_annuleren.UseVisualStyleBackColor = true;
            this.bt_annuleren.Click += new System.EventHandler(this.bt_annuleren_Click);
            // 
            // tbartiestennaam
            // 
            this.tbartiestennaam.Location = new System.Drawing.Point(112, 30);
            this.tbartiestennaam.Name = "tbartiestennaam";
            this.tbartiestennaam.Size = new System.Drawing.Size(147, 20);
            this.tbartiestennaam.TabIndex = 2;
            // 
            // tbvoornaam
            // 
            this.tbvoornaam.Location = new System.Drawing.Point(112, 72);
            this.tbvoornaam.Name = "tbvoornaam";
            this.tbvoornaam.Size = new System.Drawing.Size(147, 20);
            this.tbvoornaam.TabIndex = 3;
            // 
            // tbachternaam
            // 
            this.tbachternaam.Location = new System.Drawing.Point(112, 118);
            this.tbachternaam.Name = "tbachternaam";
            this.tbachternaam.Size = new System.Drawing.Size(147, 20);
            this.tbachternaam.TabIndex = 4;
            // 
            // tbgebplaats
            // 
            this.tbgebplaats.Location = new System.Drawing.Point(112, 210);
            this.tbgebplaats.Name = "tbgebplaats";
            this.tbgebplaats.Size = new System.Drawing.Size(147, 20);
            this.tbgebplaats.TabIndex = 6;
            // 
            // tbgebland
            // 
            this.tbgebland.Location = new System.Drawing.Point(112, 256);
            this.tbgebland.Name = "tbgebland";
            this.tbgebland.Size = new System.Drawing.Size(147, 20);
            this.tbgebland.TabIndex = 7;
            // 
            // tbbiografie
            // 
            this.tbbiografie.Location = new System.Drawing.Point(287, 76);
            this.tbbiografie.Name = "tbbiografie";
            this.tbbiografie.Size = new System.Drawing.Size(250, 204);
            this.tbbiografie.TabIndex = 8;
            this.tbbiografie.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Biografie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Artiesten naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Voornaam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Achternaam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Geboorte datum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Geboorteplaats";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Geboorteland";
            // 
            // tbgebdat
            // 
            this.tbgebdat.Location = new System.Drawing.Point(112, 164);
            this.tbgebdat.Mask = "00/00/0000";
            this.tbgebdat.Name = "tbgebdat";
            this.tbgebdat.Size = new System.Drawing.Size(147, 20);
            this.tbgebdat.TabIndex = 16;
            this.tbgebdat.ValidatingType = typeof(System.DateTime);
            // 
            // ArtiestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 375);
            this.Controls.Add(this.tbgebdat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbbiografie);
            this.Controls.Add(this.tbgebland);
            this.Controls.Add(this.tbgebplaats);
            this.Controls.Add(this.tbachternaam);
            this.Controls.Add(this.tbvoornaam);
            this.Controls.Add(this.tbartiestennaam);
            this.Controls.Add(this.bt_annuleren);
            this.Controls.Add(this.bt_add);
            this.Name = "ArtiestForm";
            this.Text = "Artiest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_annuleren;
        private System.Windows.Forms.TextBox tbartiestennaam;
        private System.Windows.Forms.TextBox tbvoornaam;
        private System.Windows.Forms.TextBox tbachternaam;
        private System.Windows.Forms.TextBox tbgebplaats;
        private System.Windows.Forms.TextBox tbgebland;
        private System.Windows.Forms.RichTextBox tbbiografie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox tbgebdat;
    }
}