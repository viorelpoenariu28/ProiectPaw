namespace WindowsFormsApp1
{
    partial class DetaliiClientControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNume = new System.Windows.Forms.Label();
            this.lblCNP = new System.Windows.Forms.Label();
            this.lblVarsta = new System.Windows.Forms.Label();
            this.lblVenit = new System.Windows.Forms.Label();
            this.lblScor = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(30, 32);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // lblCNP
            // 
            this.lblCNP.AutoSize = true;
            this.lblCNP.Location = new System.Drawing.Point(30, 54);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(29, 13);
            this.lblCNP.TabIndex = 1;
            this.lblCNP.Text = "CNP";
            // 
            // lblVarsta
            // 
            this.lblVarsta.AutoSize = true;
            this.lblVarsta.Location = new System.Drawing.Point(30, 76);
            this.lblVarsta.Name = "lblVarsta";
            this.lblVarsta.Size = new System.Drawing.Size(37, 13);
            this.lblVarsta.TabIndex = 2;
            this.lblVarsta.Text = "Varsta";
            // 
            // lblVenit
            // 
            this.lblVenit.AutoSize = true;
            this.lblVenit.Location = new System.Drawing.Point(30, 99);
            this.lblVenit.Name = "lblVenit";
            this.lblVenit.Size = new System.Drawing.Size(31, 13);
            this.lblVenit.TabIndex = 3;
            this.lblVenit.Text = "Venit";
            // 
            // lblScor
            // 
            this.lblScor.AutoSize = true;
            this.lblScor.Location = new System.Drawing.Point(30, 122);
            this.lblScor.Name = "lblScor";
            this.lblScor.Size = new System.Drawing.Size(29, 13);
            this.lblScor.TabIndex = 4;
            this.lblScor.Text = "Scor";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(30, 148);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(43, 13);
            this.lblTelefon.TabIndex = 5;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 171);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // DetaliiClientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblScor);
            this.Controls.Add(this.lblVenit);
            this.Controls.Add(this.lblVarsta);
            this.Controls.Add(this.lblCNP);
            this.Controls.Add(this.lblNume);
            this.Name = "DetaliiClientControl";
            this.Size = new System.Drawing.Size(263, 234);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblCNP;
        private System.Windows.Forms.Label lblVarsta;
        private System.Windows.Forms.Label lblVenit;
        private System.Windows.Forms.Label lblScor;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEmail;
    }
}
