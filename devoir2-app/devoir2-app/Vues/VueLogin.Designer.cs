﻿
namespace devoir2_app.Vues
{
    partial class VueLogin
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
            this.lblUtilisateur = new System.Windows.Forms.Label();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.txtBoxMotDePasse = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUtilisateur
            // 
            this.lblUtilisateur.AutoSize = true;
            this.lblUtilisateur.Location = new System.Drawing.Point(12, 43);
            this.lblUtilisateur.Name = "lblUtilisateur";
            this.lblUtilisateur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUtilisateur.Size = new System.Drawing.Size(84, 13);
            this.lblUtilisateur.TabIndex = 0;
            this.lblUtilisateur.Text = "Nom d\'utilisateur";
            this.lblUtilisateur.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(12, 73);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(71, 13);
            this.lblMotDePasse.TabIndex = 1;
            this.lblMotDePasse.Text = "Mot de passe";
            this.lblMotDePasse.Click += new System.EventHandler(this.lblMotDePasse_Click);
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Location = new System.Drawing.Point(111, 43);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(140, 20);
            this.txtBoxLogin.TabIndex = 2;
            this.txtBoxLogin.Text = "login";
            // 
            // txtBoxMotDePasse
            // 
            this.txtBoxMotDePasse.Location = new System.Drawing.Point(111, 73);
            this.txtBoxMotDePasse.Name = "txtBoxMotDePasse";
            this.txtBoxMotDePasse.Size = new System.Drawing.Size(140, 20);
            this.txtBoxMotDePasse.TabIndex = 3;
            this.txtBoxMotDePasse.Text = "Password";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(176, 109);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // VueLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtBoxMotDePasse);
            this.Controls.Add(this.txtBoxLogin);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.lblUtilisateur);
            this.Name = "VueLogin";
            this.Text = "VueLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUtilisateur;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.TextBox txtBoxMotDePasse;
        private System.Windows.Forms.Button btnValider;
    }
}