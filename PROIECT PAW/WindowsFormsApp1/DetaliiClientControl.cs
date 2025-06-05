using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms;

namespace WindowsFormsApp1 // să fie namespace-ul tău!
{
    public partial class DetaliiClientControl : UserControl
    {
        public DetaliiClientControl()
        {
            InitializeComponent();
        }

        public void SetClient(Clienti client)
        {
            if (client == null)
            {
                lblNume.Text = "Nume: ";
                lblCNP.Text = "CNP: ";
                lblVarsta.Text = "Vârstă: ";
                lblVenit.Text = "Venit lunar: ";
                lblScor.Text = "Scor credit: ";
                lblTelefon.Text = "Telefon: ";
                lblEmail.Text = "Email: ";
                return;
            }

            lblNume.Text = $"Nume: {client.NumeComplet()}";
            lblCNP.Text = $"CNP: {client.Cnp}";
            lblVarsta.Text = $"Vârstă: {client.CalculeazaVarsta()}";
            lblVenit.Text = $"Venit lunar: {client.VenitLunar}";
            lblScor.Text = $"Scor credit: {client.ScorCredit}";
            lblTelefon.Text = $"Telefon: {client.Telefon}";
            lblEmail.Text = $"Email: {client.Email}";
        }
    }
}

