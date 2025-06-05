using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Printing;
using System.Drawing;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Clienti> listaClienti = new List<Clienti>();
        private List<Credit> listaCredite = new List<Credit>();
        private int nextClientId = 1;
        private int nextCreditId = 1;

        public Form1()
        {
            InitializeComponent();

            // Setează maximum pentru numeric up-down-uri
            numericSuma.Maximum = 1000000;
            numericDobanda.Maximum = 100;
            numericPerioada.Maximum = 360;

            // Populează statusuri credit
            cbStatus.Items.AddRange(new string[] { "Activ", "Rambursat", "Restant", "Refuzat", "Inchis" });
            cbStatus.SelectedIndex = 0;

            // Inițializează DataGridView-uri
            dgvClienti.AutoGenerateColumns = true;
            dgvClienti.DataSource = listaClienti;
            dgvCredite.AutoGenerateColumns = true;
            dgvCredite.DataSource = listaCredite;

            // Populează ComboBox clienți
            ActualizeazaComboBoxClienti();

            // Leagă evenimentele pentru context menu
            salveazaToolStripMenuItem.Click += SalveazaToolStripMenuItem_Click;
            IncarcaToolStripMenuItem.Click += IncarcaToolStripMenuItem_Click;

            // Leagă evenimentele pentru butoane
            btnAdaugaClient.Click += btnAdaugaClient_Click;
            btnAdaugaCredit.Click += btnAdaugaCredit_Click;

            dgvClienti.SelectionChanged += dgvClienti_SelectionChanged;
        }

        private void ActualizeazaComboBoxClienti()
        {
            cbClient.Items.Clear();
            foreach (var client in listaClienti)
            {
                cbClient.Items.Add($"{client.Id} - {client.Nume} {client.Prenume}");
            }
            if (cbClient.Items.Count > 0)
                cbClient.SelectedIndex = 0;
        }

        private void btnAdaugaClient_Click(object sender, EventArgs e)
        {

            // Validare
            bool valid = true;
            tbNume.BackColor = tbPrenume.BackColor = tbCNP.BackColor = tbVenitLunar.BackColor = tbScorCredit.BackColor = Color.White;

            if (string.IsNullOrWhiteSpace(tbNume.Text)) { tbNume.BackColor = Color.LightCoral; valid = false; }
            if (string.IsNullOrWhiteSpace(tbPrenume.Text)) { tbPrenume.BackColor = Color.LightCoral; valid = false; }
            if (tbCNP.Text.Length != 13 || !tbCNP.Text.All(char.IsDigit)) { tbCNP.BackColor = Color.LightCoral; valid = false; }
            if (!decimal.TryParse(tbVenitLunar.Text, out decimal venitLunar) || venitLunar <= 0) { tbVenitLunar.BackColor = Color.LightCoral; valid = false; }
            if (!int.TryParse(tbScorCredit.Text, out int scorCredit) || scorCredit < 0 || scorCredit > 1000) { tbScorCredit.BackColor = Color.LightCoral; valid = false; }

            if (!valid)
            {
                MessageBox.Show("Date client invalide!");
                return;
            }

            // Creează clientul
            var client = new Clienti(
                nextClientId++,
                tbNume.Text.Trim(),
                tbPrenume.Text.Trim(),
                tbCNP.Text.Trim(),
                tbTelefon.Text.Trim(),
                tbEmail.Text.Trim(),
                tbAdresa.Text.Trim(),
                venitLunar,
                scorCredit
            );

            listaClienti.Add(client);

            // Actualizează DataGridView și ComboBox
            dgvClienti.DataSource = null;
            dgvClienti.DataSource = listaClienti;
            ActualizeazaComboBoxClienti();

            // Golește câmpurile
            tbNume.Clear();
            tbPrenume.Clear();
            tbCNP.Clear();
            tbTelefon.Clear();
            tbEmail.Clear();
            tbAdresa.Clear();
            tbVenitLunar.Clear();
            tbScorCredit.Clear();
        }

        private void btnAdaugaCredit_Click(object sender, EventArgs e)
        {
            if (cbClient.SelectedIndex == -1)
            {
                MessageBox.Show("Selectează un client!");
                return;
            }

            if (numericSuma.Value <= 0 ||
                numericDobanda.Value < 0 || numericDobanda.Value > 100 ||
                numericPerioada.Value <= 0)
            {
                MessageBox.Show("Date credit invalide!");
                return;
            }

            // Extrage ID-ul clientului selectat
            string selected = cbClient.SelectedItem.ToString();
            int idClient = int.Parse(selected.Split('-')[0].Trim());

            // Creează creditul
            var credit = new Credit(
                nextCreditId++,
                idClient,
                numericSuma.Value,
                numericDobanda.Value,
                (int)numericPerioada.Value,
                dateTimeDataAcordarii.Value,
                cbStatus.SelectedItem.ToString()
            );

            listaCredite.Add(credit);

            // Actualizează DataGridView
            dgvCredite.DataSource = null;
            dgvCredite.DataSource = listaCredite;

            // Golește selecția
            numericSuma.Value = 0;
            numericDobanda.Value = 0;
            numericPerioada.Value = 0;
            cbStatus.SelectedIndex = 0;

            ActualizeazaGraficCredite();
        }

        // Salvare clienți
        private void SalveazaClientiInFisier(string caleFisier)
        {
            using (StreamWriter sw = new StreamWriter(caleFisier))
            {
                foreach (var client in listaClienti)
                {
                    sw.WriteLine($"{client.Id},{client.Nume},{client.Prenume},{client.Cnp},{client.Telefon},{client.Email},{client.Adresa},{client.VenitLunar},{client.ScorCredit}");
                }
            }
        }

        // Încărcare clienți
        private void IncarcaClientiDinFisier(string caleFisier)
        {
            listaClienti.Clear();
            using (StreamReader sr = new StreamReader(caleFisier))
            {
                string linie;
                while ((linie = sr.ReadLine()) != null)
                {
                    var valori = linie.Split(',');
                    var client = new Clienti(
                        int.Parse(valori[0]),
                        valori[1],
                        valori[2],
                        valori[3],
                        valori[4],
                        valori[5],
                        valori[6],
                        decimal.Parse(valori[7]),
                        int.Parse(valori[8])
                    );
                    listaClienti.Add(client);
                }
            }
            dgvClienti.DataSource = null;
            dgvClienti.DataSource = listaClienti;
            ActualizeazaComboBoxClienti();
        }

        // Salvare credite
        private void SalveazaCrediteInFisier(string caleFisier)
        {
            using (StreamWriter sw = new StreamWriter(caleFisier))
            {
                foreach (var credit in listaCredite)
                {
                    sw.WriteLine($"{credit.IdCredit},{credit.IdClient},{credit.SumaPrincipala},{credit.RataDobanzii},{credit.PerioadaLunii},{credit.DataAcordarii:yyyy-MM-dd},{credit.StatusCredit}");
                }
            }
        }

        // Încărcare credite
        private void IncarcaCrediteDinFisier(string caleFisier)
        {
            listaCredite.Clear();
            using (StreamReader sr = new StreamReader(caleFisier))
            {
                string linie;
                while ((linie = sr.ReadLine()) != null)
                {
                    var valori = linie.Split(',');
                    var credit = new Credit(
                        int.Parse(valori[0]),
                        int.Parse(valori[1]),
                        decimal.Parse(valori[2]),
                        decimal.Parse(valori[3]),
                        int.Parse(valori[4]),
                        DateTime.Parse(valori[5]),
                        valori[6]
                    );
                    listaCredite.Add(credit);
                }
            }
            dgvCredite.DataSource = null;
            dgvCredite.DataSource = listaCredite;
        }

        // Eveniment pentru context menu: Salvează
        private void SalveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            dlg.Filter = "Fișiere text|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                SalveazaClientiInFisier(dlg.FileName);
                SalveazaCrediteInFisier(Path.ChangeExtension(dlg.FileName, ".credite.txt"));
                MessageBox.Show("Datele au fost salvate!");
            }
        }

        // Eveniment pentru context menu: Încarcă
        private void IncarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Fișiere text|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                IncarcaClientiDinFisier(dlg.FileName);
                string fileCredite = Path.ChangeExtension(dlg.FileName, ".credite.txt");
                if (File.Exists(fileCredite))
                    IncarcaCrediteDinFisier(fileCredite);
                MessageBox.Show("Datele au fost încărcate!");
            }
        }
        private void ActualizeazaGraficCredite()
        {
            chartCredite.Series.Clear();
            var serie = new Series("Statusuri") { ChartType = SeriesChartType.Pie };
            var grupare = listaCredite
                .GroupBy(c => c.StatusCredit)
                .Select(g => new { Status = g.Key, Count = g.Count() });

            foreach (var elem in grupare)
                serie.Points.AddXY(elem.Status, elem.Count);

            chartCredite.Series.Add(serie);
        }
        private void btnPrintClienti_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDocument;
            previewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int y = 100;
            e.Graphics.DrawString("Lista clienți", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 100, y);
            y += 40;
            foreach (var client in listaClienti)
            {
                e.Graphics.DrawString(client.ToString(), new Font("Arial", 10), Brushes.Black, 100, y);
                y += 25;
                if (y > e.MarginBounds.Height - 100) break; // doar primii X clienți dacă sunt mulți
            }
        }
        private void dgvClienti_SelectionChanged(object sender, EventArgs e)
        {
            // Defensive: check if there are any rows and a valid selection
            if (dgvClienti.DataSource == null || dgvClienti.Rows.Count == 0)
            {
                detaliiClientControl1.SetClient(null);
                return;
            }

            // Find the first selected row that is not a new row
            DataGridViewRow selectedRow = null;
            foreach (DataGridViewRow row in dgvClienti.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    selectedRow = row;
                    break;
                }
            }

            if (selectedRow == null || selectedRow.DataBoundItem == null)
            {
                detaliiClientControl1.SetClient(null);
                return;
            }

            if (selectedRow.DataBoundItem is Clienti client)
                detaliiClientControl1.SetClient(client);
            else
                detaliiClientControl1.SetClient(null);
        }






        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void dasdaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}