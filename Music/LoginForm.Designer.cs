﻿namespace Music
{
    partial class LoginForm
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
            this.btLogin = new System.Windows.Forms.Button();
            this.btRegistreer = new System.Windows.Forms.Button();
            this.inputUsername = new System.Windows.Forms.TextBox();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(35, 217);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 1;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            // 
            // btRegistreer
            // 
            this.btRegistreer.Location = new System.Drawing.Point(116, 217);
            this.btRegistreer.Name = "btRegistreer";
            this.btRegistreer.Size = new System.Drawing.Size(75, 23);
            this.btRegistreer.TabIndex = 2;
            this.btRegistreer.Text = "Registreer";
            this.btRegistreer.UseVisualStyleBackColor = true;
            // 
            // inputUsername
            // 
            this.inputUsername.Location = new System.Drawing.Point(15, 26);
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(257, 20);
            this.inputUsername.TabIndex = 3;
            // 
            // inputPassword
            // 
            this.inputPassword.Location = new System.Drawing.Point(15, 69);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(257, 20);
            this.inputPassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.inputUsername);
            this.Controls.Add(this.btRegistreer);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btRegistreer;
        private System.Windows.Forms.TextBox inputUsername;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Label label2;
    }
}

