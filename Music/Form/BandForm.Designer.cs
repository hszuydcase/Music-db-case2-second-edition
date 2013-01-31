namespace Music
{
    partial class BandForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BandForm));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbbandbiografie = new System.Windows.Forms.RichTextBox();
            this.tbbandoorsprong = new System.Windows.Forms.TextBox();
            this.tbbandimage = new System.Windows.Forms.TextBox();
            this.tbbandnaam = new System.Windows.Forms.TextBox();
            this.bt_annuleren = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btopenfiledialog = new System.Windows.Forms.Button();
            this.tbbandopgericht = new System.Windows.Forms.MaskedTextBox();
            this.tbbandgestopt = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Band oorsprong";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Band image";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Band gestopt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Band opgericht";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Band naam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Biografie";
            // 
            // tbbandbiografie
            // 
            this.tbbandbiografie.Location = new System.Drawing.Point(305, 39);
            this.tbbandbiografie.Name = "tbbandbiografie";
            this.tbbandbiografie.Size = new System.Drawing.Size(250, 204);
            this.tbbandbiografie.TabIndex = 5;
            this.tbbandbiografie.Text = "";
            // 
            // tbbandoorsprong
            // 
            this.tbbandoorsprong.Location = new System.Drawing.Point(103, 219);
            this.tbbandoorsprong.Name = "tbbandoorsprong";
            this.tbbandoorsprong.Size = new System.Drawing.Size(147, 20);
            this.tbbandoorsprong.TabIndex = 4;
            // 
            // tbbandimage
            // 
            this.tbbandimage.Location = new System.Drawing.Point(103, 173);
            this.tbbandimage.Name = "tbbandimage";
            this.tbbandimage.Size = new System.Drawing.Size(147, 20);
            this.tbbandimage.TabIndex = 3;
            // 
            // tbbandnaam
            // 
            this.tbbandnaam.Location = new System.Drawing.Point(103, 39);
            this.tbbandnaam.Name = "tbbandnaam";
            this.tbbandnaam.Size = new System.Drawing.Size(147, 20);
            this.tbbandnaam.TabIndex = 0;
            // 
            // bt_annuleren
            // 
            this.bt_annuleren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_annuleren.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_annuleren.Location = new System.Drawing.Point(480, 278);
            this.bt_annuleren.Name = "bt_annuleren";
            this.bt_annuleren.Size = new System.Drawing.Size(75, 23);
            this.bt_annuleren.TabIndex = 6;
            this.bt_annuleren.Text = "Annuleren";
            this.bt_annuleren.UseVisualStyleBackColor = true;
            this.bt_annuleren.Click += new System.EventHandler(this.bt_annuleren_Click);
            // 
            // bt_add
            // 
            this.bt_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_add.Location = new System.Drawing.Point(399, 278);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 7;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btopenfiledialog
            // 
            this.btopenfiledialog.Location = new System.Drawing.Point(247, 173);
            this.btopenfiledialog.Name = "btopenfiledialog";
            this.btopenfiledialog.Size = new System.Drawing.Size(28, 20);
            this.btopenfiledialog.TabIndex = 31;
            this.btopenfiledialog.Text = "...";
            this.btopenfiledialog.UseVisualStyleBackColor = true;
            this.btopenfiledialog.Click += new System.EventHandler(this.btopenfiledialog_Click);
            // 
            // tbbandopgericht
            // 
            this.tbbandopgericht.Location = new System.Drawing.Point(103, 84);
            this.tbbandopgericht.Mask = "00/00/0000";
            this.tbbandopgericht.Name = "tbbandopgericht";
            this.tbbandopgericht.Size = new System.Drawing.Size(147, 20);
            this.tbbandopgericht.TabIndex = 1;
            this.tbbandopgericht.ValidatingType = typeof(System.DateTime);
            // 
            // tbbandgestopt
            // 
            this.tbbandgestopt.Location = new System.Drawing.Point(103, 130);
            this.tbbandgestopt.Mask = "00/00/0000";
            this.tbbandgestopt.Name = "tbbandgestopt";
            this.tbbandgestopt.Size = new System.Drawing.Size(147, 20);
            this.tbbandgestopt.TabIndex = 2;
            this.tbbandgestopt.ValidatingType = typeof(System.DateTime);
            // 
            // BandForm
            // 
            this.AcceptButton = this.bt_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_annuleren;
            this.ClientSize = new System.Drawing.Size(567, 317);
            this.Controls.Add(this.tbbandgestopt);
            this.Controls.Add(this.tbbandopgericht);
            this.Controls.Add(this.btopenfiledialog);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbbandbiografie);
            this.Controls.Add(this.tbbandoorsprong);
            this.Controls.Add(this.tbbandimage);
            this.Controls.Add(this.tbbandnaam);
            this.Controls.Add(this.bt_annuleren);
            this.Controls.Add(this.bt_add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BandForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Band";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tbbandbiografie;
        private System.Windows.Forms.TextBox tbbandoorsprong;
        private System.Windows.Forms.TextBox tbbandimage;
        private System.Windows.Forms.TextBox tbbandnaam;
        private System.Windows.Forms.Button bt_annuleren;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btopenfiledialog;
        private System.Windows.Forms.MaskedTextBox tbbandopgericht;
        private System.Windows.Forms.MaskedTextBox tbbandgestopt;
    }
}