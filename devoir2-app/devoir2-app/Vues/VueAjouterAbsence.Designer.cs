
namespace devoir2_app.Vues
{
    partial class VueAjouterAbsence
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
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.dateTimePickerDateDebut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateFin = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMotif = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(99, 57);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(62, 13);
            this.lblDateDebut.TabIndex = 0;
            this.lblDateDebut.Text = "Date Début";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(99, 99);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(47, 13);
            this.lblDateFin.TabIndex = 1;
            this.lblDateFin.Text = "Date Fin";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(99, 143);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(30, 13);
            this.lblMotif.TabIndex = 2;
            this.lblMotif.Text = "Motif";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(102, 183);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(228, 183);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 7;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDateDebut
            // 
            this.dateTimePickerDateDebut.Location = new System.Drawing.Point(184, 51);
            this.dateTimePickerDateDebut.Name = "dateTimePickerDateDebut";
            this.dateTimePickerDateDebut.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateDebut.TabIndex = 8;
            // 
            // dateTimePickerDateFin
            // 
            this.dateTimePickerDateFin.Location = new System.Drawing.Point(184, 92);
            this.dateTimePickerDateFin.Name = "dateTimePickerDateFin";
            this.dateTimePickerDateFin.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateFin.TabIndex = 9;
            // 
            // comboBoxMotif
            // 
            this.comboBoxMotif.FormattingEnabled = true;
            this.comboBoxMotif.Location = new System.Drawing.Point(182, 135);
            this.comboBoxMotif.Name = "comboBoxMotif";
            this.comboBoxMotif.Size = new System.Drawing.Size(202, 21);
            this.comboBoxMotif.TabIndex = 10;
            // 
            // VueAjouterAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 261);
            this.Controls.Add(this.comboBoxMotif);
            this.Controls.Add(this.dateTimePickerDateFin);
            this.Controls.Add(this.dateTimePickerDateDebut);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.lblDateDebut);
            this.Name = "VueAjouterAbsence";
            this.Text = "VueAjouterAbsence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateDebut;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateFin;
        private System.Windows.Forms.ComboBox comboBoxMotif;
    }
}