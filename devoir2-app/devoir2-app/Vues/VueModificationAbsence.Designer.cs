
namespace devoir2_app.Vues
{
    partial class VueModificationAbsence
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
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.txtBoxDateDebut = new System.Windows.Forms.TextBox();
            this.txtBoxDateFin = new System.Windows.Forms.TextBox();
            this.txtBoxMotif = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(58, 33);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(62, 13);
            this.lblDateDebut.TabIndex = 0;
            this.lblDateDebut.Text = "Date Début";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(58, 72);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(47, 13);
            this.lblDateFin.TabIndex = 1;
            this.lblDateFin.Text = "Date Fin";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(58, 115);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(30, 13);
            this.lblMotif.TabIndex = 2;
            this.lblMotif.Text = "Motif";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(61, 153);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 3;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(180, 152);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // txtBoxDateDebut
            // 
            this.txtBoxDateDebut.Location = new System.Drawing.Point(139, 33);
            this.txtBoxDateDebut.Name = "txtBoxDateDebut";
            this.txtBoxDateDebut.Size = new System.Drawing.Size(116, 20);
            this.txtBoxDateDebut.TabIndex = 5;
            // 
            // txtBoxDateFin
            // 
            this.txtBoxDateFin.Location = new System.Drawing.Point(139, 72);
            this.txtBoxDateFin.Name = "txtBoxDateFin";
            this.txtBoxDateFin.Size = new System.Drawing.Size(116, 20);
            this.txtBoxDateFin.TabIndex = 6;
            // 
            // txtBoxMotif
            // 
            this.txtBoxMotif.Location = new System.Drawing.Point(139, 115);
            this.txtBoxMotif.Name = "txtBoxMotif";
            this.txtBoxMotif.Size = new System.Drawing.Size(116, 20);
            this.txtBoxMotif.TabIndex = 7;
            // 
            // VueModificationAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 261);
            this.Controls.Add(this.txtBoxMotif);
            this.Controls.Add(this.txtBoxDateFin);
            this.Controls.Add(this.txtBoxDateDebut);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.lblDateDebut);
            this.Name = "VueModificationAbsence";
            this.Text = "VueModificationAbsence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox txtBoxDateDebut;
        private System.Windows.Forms.TextBox txtBoxDateFin;
        private System.Windows.Forms.TextBox txtBoxMotif;
    }
}