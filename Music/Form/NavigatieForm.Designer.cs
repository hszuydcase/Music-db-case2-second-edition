﻿namespace Music
{
    partial class NavigatieForm
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
            this.btcat = new System.Windows.Forms.Button();
            this.bttra = new System.Windows.Forms.Button();
            this.btband = new System.Windows.Forms.Button();
            this.btart = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btcat
            // 
            this.btcat.Location = new System.Drawing.Point(91, 135);
            this.btcat.Name = "btcat";
            this.btcat.Size = new System.Drawing.Size(75, 23);
            this.btcat.TabIndex = 0;
            this.btcat.Text = "Categorie";
            this.btcat.UseVisualStyleBackColor = true;
            this.btcat.Click += new System.EventHandler(this.btcat_Click);
            // 
            // bttra
            // 
            this.bttra.Location = new System.Drawing.Point(91, 164);
            this.bttra.Name = "bttra";
            this.bttra.Size = new System.Drawing.Size(75, 23);
            this.bttra.TabIndex = 1;
            this.bttra.Text = "Track";
            this.bttra.UseVisualStyleBackColor = true;
            this.bttra.Click += new System.EventHandler(this.bttra_Click);
            // 
            // btband
            // 
            this.btband.Location = new System.Drawing.Point(91, 106);
            this.btband.Name = "btband";
            this.btband.Size = new System.Drawing.Size(75, 23);
            this.btband.TabIndex = 2;
            this.btband.Text = "Band";
            this.btband.UseVisualStyleBackColor = true;
            this.btband.Click += new System.EventHandler(this.btband_Click);
            // 
            // btart
            // 
            this.btart.Location = new System.Drawing.Point(91, 77);
            this.btart.Name = "btart";
            this.btart.Size = new System.Drawing.Size(75, 23);
            this.btart.TabIndex = 3;
            this.btart.Text = "Artiest";
            this.btart.UseVisualStyleBackColor = true;
            this.btart.Click += new System.EventHandler(this.btart_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(293, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inserts";
            // 
            // NavigatieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 416);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btart);
            this.Controls.Add(this.btband);
            this.Controls.Add(this.bttra);
            this.Controls.Add(this.btcat);
            this.Name = "NavigatieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NavigatieForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcat;
        private System.Windows.Forms.Button bttra;
        private System.Windows.Forms.Button btband;
        private System.Windows.Forms.Button btart;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
    }
}