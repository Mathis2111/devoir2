
namespace devoir2_app.Vues
{
    partial class VueConfirmationModificationPersonnel
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnNon = new System.Windows.Forms.Button();
            this.btnOui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(237, 73);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(249, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Confirmez-vous la modification de l\'enregistrement ?";
            // 
            // btnNon
            // 
            this.btnNon.Location = new System.Drawing.Point(262, 113);
            this.btnNon.Name = "btnNon";
            this.btnNon.Size = new System.Drawing.Size(75, 23);
            this.btnNon.TabIndex = 1;
            this.btnNon.Text = "Non";
            this.btnNon.UseVisualStyleBackColor = true;
            // 
            // btnOui
            // 
            this.btnOui.Location = new System.Drawing.Point(376, 113);
            this.btnOui.Name = "btnOui";
            this.btnOui.Size = new System.Drawing.Size(75, 23);
            this.btnOui.TabIndex = 2;
            this.btnOui.Text = "Oui";
            this.btnOui.UseVisualStyleBackColor = true;
            // 
            // ConfirmationModificationPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 261);
            this.Controls.Add(this.btnOui);
            this.Controls.Add(this.btnNon);
            this.Controls.Add(this.lblQuestion);
            this.Name = "ConfirmationModificationPersonnel";
            this.Text = "ConfirmationModificationPersonnel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnNon;
        private System.Windows.Forms.Button btnOui;
    }
}