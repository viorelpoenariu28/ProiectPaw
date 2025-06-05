namespace WindowsFormsApp1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbVenitLunar = new System.Windows.Forms.TextBox();
            this.tbScorCredit = new System.Windows.Forms.TextBox();
            this.btnAdaugaClient = new System.Windows.Forms.Button();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.gbCredit = new System.Windows.Forms.GroupBox();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.numericSuma = new System.Windows.Forms.NumericUpDown();
            this.numericDobanda = new System.Windows.Forms.NumericUpDown();
            this.numericPerioada = new System.Windows.Forms.NumericUpDown();
            this.dateTimeDataAcordarii = new System.Windows.Forms.DateTimePicker();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnAdaugaCredit = new System.Windows.Forms.Button();
            this.dgvClienti = new System.Windows.Forms.DataGridView();
            this.dgvCredite = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IncarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartCredite = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPrintClienti = new System.Windows.Forms.Button();
            this.detaliiClientControl1 = new WindowsFormsApp1.DetaliiClientControl();
            this.gbClient.SuspendLayout();
            this.gbCredit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSuma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDobanda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPerioada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredite)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCredite)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(52, 38);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(199, 20);
            this.tbNume.TabIndex = 0;
            this.tbNume.Text = "Nume";
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(52, 74);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(199, 20);
            this.tbPrenume.TabIndex = 1;
            this.tbPrenume.Text = "Prenume";
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(52, 109);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(199, 20);
            this.tbCNP.TabIndex = 2;
            this.tbCNP.Text = "CNP";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(52, 144);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(199, 20);
            this.tbTelefon.TabIndex = 3;
            this.tbTelefon.Text = "Telefon";
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(52, 214);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(199, 20);
            this.tbAdresa.TabIndex = 4;
            this.tbAdresa.Text = "Adresa";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(52, 179);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(199, 20);
            this.tbEmail.TabIndex = 5;
            this.tbEmail.Text = "Email";
            // 
            // tbVenitLunar
            // 
            this.tbVenitLunar.Location = new System.Drawing.Point(52, 250);
            this.tbVenitLunar.Name = "tbVenitLunar";
            this.tbVenitLunar.Size = new System.Drawing.Size(199, 20);
            this.tbVenitLunar.TabIndex = 6;
            this.tbVenitLunar.Text = "Venit Lunar";
            // 
            // tbScorCredit
            // 
            this.tbScorCredit.Location = new System.Drawing.Point(52, 290);
            this.tbScorCredit.Name = "tbScorCredit";
            this.tbScorCredit.Size = new System.Drawing.Size(199, 20);
            this.tbScorCredit.TabIndex = 7;
            this.tbScorCredit.Text = "Scor Credit";
            // 
            // btnAdaugaClient
            // 
            this.btnAdaugaClient.Location = new System.Drawing.Point(52, 340);
            this.btnAdaugaClient.Name = "btnAdaugaClient";
            this.btnAdaugaClient.Size = new System.Drawing.Size(105, 33);
            this.btnAdaugaClient.TabIndex = 8;
            this.btnAdaugaClient.Text = "Adauga Client";
            this.btnAdaugaClient.UseVisualStyleBackColor = true;
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.btnPrintClienti);
            this.gbClient.Controls.Add(this.tbNume);
            this.gbClient.Controls.Add(this.tbPrenume);
            this.gbClient.Controls.Add(this.tbCNP);
            this.gbClient.Controls.Add(this.tbTelefon);
            this.gbClient.Controls.Add(this.tbAdresa);
            this.gbClient.Controls.Add(this.tbEmail);
            this.gbClient.Controls.Add(this.tbVenitLunar);
            this.gbClient.Controls.Add(this.tbScorCredit);
            this.gbClient.Controls.Add(this.btnAdaugaClient);
            this.gbClient.Location = new System.Drawing.Point(19, 47);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(298, 393);
            this.gbClient.TabIndex = 4;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Client nou";
            // 
            // gbCredit
            // 
            this.gbCredit.Controls.Add(this.cbClient);
            this.gbCredit.Controls.Add(this.numericSuma);
            this.gbCredit.Controls.Add(this.numericDobanda);
            this.gbCredit.Controls.Add(this.numericPerioada);
            this.gbCredit.Controls.Add(this.dateTimeDataAcordarii);
            this.gbCredit.Controls.Add(this.cbStatus);
            this.gbCredit.Controls.Add(this.btnAdaugaCredit);
            this.gbCredit.Location = new System.Drawing.Point(758, 47);
            this.gbCredit.Name = "gbCredit";
            this.gbCredit.Size = new System.Drawing.Size(298, 393);
            this.gbCredit.TabIndex = 9;
            this.gbCredit.TabStop = false;
            this.gbCredit.Text = "Credit Nou";
            // 
            // cbClient
            // 
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(52, 63);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(198, 21);
            this.cbClient.TabIndex = 0;
            // 
            // numericSuma
            // 
            this.numericSuma.Location = new System.Drawing.Point(94, 133);
            this.numericSuma.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericSuma.Name = "numericSuma";
            this.numericSuma.Size = new System.Drawing.Size(120, 20);
            this.numericSuma.TabIndex = 1;
            // 
            // numericDobanda
            // 
            this.numericDobanda.Location = new System.Drawing.Point(94, 169);
            this.numericDobanda.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericDobanda.Name = "numericDobanda";
            this.numericDobanda.Size = new System.Drawing.Size(120, 20);
            this.numericDobanda.TabIndex = 2;
            // 
            // numericPerioada
            // 
            this.numericPerioada.Location = new System.Drawing.Point(94, 204);
            this.numericPerioada.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericPerioada.Name = "numericPerioada";
            this.numericPerioada.Size = new System.Drawing.Size(120, 20);
            this.numericPerioada.TabIndex = 3;
            // 
            // dateTimeDataAcordarii
            // 
            this.dateTimeDataAcordarii.Location = new System.Drawing.Point(52, 98);
            this.dateTimeDataAcordarii.Name = "dateTimeDataAcordarii";
            this.dateTimeDataAcordarii.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDataAcordarii.TabIndex = 4;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Activ",
            "Rambursat",
            "Restant",
            "Refuzat",
            "Inchis"});
            this.cbStatus.Location = new System.Drawing.Point(52, 240);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(198, 21);
            this.cbStatus.TabIndex = 5;
            // 
            // btnAdaugaCredit
            // 
            this.btnAdaugaCredit.Location = new System.Drawing.Point(109, 327);
            this.btnAdaugaCredit.Name = "btnAdaugaCredit";
            this.btnAdaugaCredit.Size = new System.Drawing.Size(105, 33);
            this.btnAdaugaCredit.TabIndex = 6;
            this.btnAdaugaCredit.Text = "Acorda Credit";
            this.btnAdaugaCredit.UseVisualStyleBackColor = true;
            // 
            // dgvClienti
            // 
            this.dgvClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienti.Location = new System.Drawing.Point(52, 466);
            this.dgvClienti.Name = "dgvClienti";
            this.dgvClienti.Size = new System.Drawing.Size(298, 393);
            this.dgvClienti.TabIndex = 10;
            this.dgvClienti.SelectionChanged += new System.EventHandler(this.dgvClienti_SelectionChanged);
            // 
            // dgvCredite
            // 
            this.dgvCredite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCredite.Location = new System.Drawing.Point(758, 479);
            this.dgvCredite.Name = "dgvCredite";
            this.dgvCredite.Size = new System.Drawing.Size(298, 336);
            this.dgvCredite.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1937, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaToolStripMenuItem,
            this.IncarcaToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // salveazaToolStripMenuItem
            // 
            this.salveazaToolStripMenuItem.Name = "salveazaToolStripMenuItem";
            this.salveazaToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.salveazaToolStripMenuItem.Text = "merge";
            this.salveazaToolStripMenuItem.Click += new System.EventHandler(this.SalveazaToolStripMenuItem_Click);
            // 
            // IncarcaToolStripMenuItem
            // 
            this.IncarcaToolStripMenuItem.Name = "IncarcaToolStripMenuItem";
            this.IncarcaToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.IncarcaToolStripMenuItem.Text = "merge";
            this.IncarcaToolStripMenuItem.Click += new System.EventHandler(this.IncarcaToolStripMenuItem_Click);
            // 
            // chartCredite
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCredite.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCredite.Legends.Add(legend1);
            this.chartCredite.Location = new System.Drawing.Point(1580, 426);
            this.chartCredite.Name = "chartCredite";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCredite.Series.Add(series1);
            this.chartCredite.Size = new System.Drawing.Size(300, 300);
            this.chartCredite.TabIndex = 15;
            this.chartCredite.Text = "chart1";
            // 
            // btnPrintClienti
            // 
            this.btnPrintClienti.Location = new System.Drawing.Point(163, 340);
            this.btnPrintClienti.Name = "btnPrintClienti";
            this.btnPrintClienti.Size = new System.Drawing.Size(98, 33);
            this.btnPrintClienti.TabIndex = 16;
            this.btnPrintClienti.Text = "Printare Clienti";
            this.btnPrintClienti.UseVisualStyleBackColor = true;
            this.btnPrintClienti.Click += new System.EventHandler(this.btnPrintClienti_Click);
            // 
            // detaliiClientControl1
            // 
            this.detaliiClientControl1.Location = new System.Drawing.Point(356, 544);
            this.detaliiClientControl1.Name = "detaliiClientControl1";
            this.detaliiClientControl1.Size = new System.Drawing.Size(176, 234);
            this.detaliiClientControl1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1937, 1035);
            this.Controls.Add(this.detaliiClientControl1);
            this.Controls.Add(this.chartCredite);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvCredite);
            this.Controls.Add(this.dgvClienti);
            this.Controls.Add(this.gbCredit);
            this.Controls.Add(this.gbClient);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            this.gbCredit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericSuma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDobanda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPerioada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredite)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCredite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbVenitLunar;
        private System.Windows.Forms.TextBox tbScorCredit;
        private System.Windows.Forms.Button btnAdaugaClient;
        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.GroupBox gbCredit;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.NumericUpDown numericSuma;
        private System.Windows.Forms.NumericUpDown numericDobanda;
        private System.Windows.Forms.NumericUpDown numericPerioada;
        private System.Windows.Forms.DateTimePicker dateTimeDataAcordarii;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnAdaugaCredit;
        private System.Windows.Forms.DataGridView dgvClienti;
        private System.Windows.Forms.DataGridView dgvCredite;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IncarcaToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCredite;
        private System.Windows.Forms.Button btnPrintClienti;
        private DetaliiClientControl detaliiClientControl1;
    }
}