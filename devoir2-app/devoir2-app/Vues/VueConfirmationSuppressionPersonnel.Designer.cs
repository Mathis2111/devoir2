
namespace devoir2_app.Vues
{
    partial class VueConfirmationSuppressionPersonnel
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
            this.btnNon = new System.Windows.Forms.Button();
            this.btnOui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirmez-vous la suppression du personnel sélectionné ?";
            // 
            // btnNon
            // 
            this.btnNon.Location = new System.Drawing.Point(240, 110);
            this.btnNon.Name = "btnNon";
            this.btnNon.Size = new System.Drawing.Size(75, 23);
            this.btnNon.TabIndex = 1;
            this.btnNon.Text = "Non";
            this.btnNon.UseVisualStyleBackColor = true;
            // 
            // btnOui
            // 
            this.btnOui.Location = new System.Drawing.Point(356, 110);
            this.btnOui.Name = "btnOui";
            this.btnOui.Size = new System.Drawing.Size(75, 23);
            this.btnOui.TabIndex = 2;
            this.btnOui.Text = "Oui";
            this.btnOui.UseVisualStyleBackColor = true;
            // 
            // VueConfirmationSuppressionPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 261);
            this.Controls.Add(this.btnOui);
            this.Controls.Add(this.btnNon);
            this.Controls.Add(this.label1);
            this.Name = "VueConfirmationSuppressionPersonnel";
            this.Text = "VueConfirmationSuppressionPersonnel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNon;
        private System.Windows.Forms.Button btnOui;
    }
}