
using System;
using System.Windows.Forms;

namespace devoir2_app.Vues
{
    partial class VuePersonnel : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Controllers.PersonnelController controller;


        public VuePersonnel(Controllers.PersonnelController controller)
        {
            this.controller = controller;
            InitializeComponent();
        }
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
            this.NomPrénomService = new System.Windows.Forms.ListBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAbsences = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NomPrénomService
            // 
            this.NomPrénomService.AccessibleName = "lstBoxInfosPerso";
            this.NomPrénomService.FormattingEnabled = true;
            this.NomPrénomService.Location = new System.Drawing.Point(30, 53);
            this.NomPrénomService.Name = "NomPrénomService";
            this.NomPrénomService.Size = new System.Drawing.Size(409, 134);
            this.NomPrénomService.TabIndex = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(482, 64);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(482, 93);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(75, 23);
            this.btnSuppr.TabIndex = 2;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(482, 122);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAbsences
            // 
            this.btnAbsences.Location = new System.Drawing.Point(482, 151);
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.Size = new System.Drawing.Size(75, 23);
            this.btnAbsences.TabIndex = 4;
            this.btnAbsences.Text = "Absences";
            this.btnAbsences.UseVisualStyleBackColor = true;
            // 
            // VuePersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 261);
            this.Controls.Add(this.btnAbsences);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSuppr);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.NomPrénomService);
            this.Name = "VuePersonnel";
            this.Text = "VuePersonnel";
            this.ResumeLayout(false);

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            controller.AfficherAjouterPersonnel();
        }

        #endregion

        private System.Windows.Forms.ListBox NomPrénomService;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAbsences;
    }
}