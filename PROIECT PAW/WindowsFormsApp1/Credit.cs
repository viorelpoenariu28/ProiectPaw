using System;

namespace WindowsFormsApp1
{
    internal class Credit : ICloneable, IComparable<Credit>
    {
        private int idCredit;
        private int idClient;
        private decimal sumaPrincipala;
        private decimal rataDobanzii;
        private int perioadaLunii;
        private DateTime dataAcordarii;
        private string statusCredit;

        public Credit() { }

        public Credit(int idCredit, int idClient, decimal sumaPrincipala, decimal rataDobanzii, int perioadaLunii, DateTime dataAcordarii, string statusCredit)
        {
            this.idCredit = idCredit;
            this.idClient = idClient;
            this.sumaPrincipala = sumaPrincipala;
            this.rataDobanzii = rataDobanzii;
            this.perioadaLunii = perioadaLunii;
            this.dataAcordarii = dataAcordarii;
            this.statusCredit = statusCredit;
        }

        public int IdCredit { get => idCredit; set => idCredit = value; }
        public int IdClient { get => idClient; set => idClient = value; }
        public decimal SumaPrincipala { get => sumaPrincipala; set => sumaPrincipala = value; }
        public decimal RataDobanzii { get => rataDobanzii; set => rataDobanzii = value; }
        public int PerioadaLunii { get => perioadaLunii; set => perioadaLunii = value; }
        public DateTime DataAcordarii { get => dataAcordarii; set => dataAcordarii = value; }
        public string StatusCredit { get => statusCredit; set => statusCredit = value; }

        // Metodă: Calculează rata lunară (formulă de credit cu dobândă fixă)
        public decimal CalculeazaRataLunara()
        {
            if (perioadaLunii == 0) return 0;
            decimal dobandaLunara = rataDobanzii / 12 / 100;
            if (dobandaLunara == 0)
                return Math.Round(sumaPrincipala / perioadaLunii, 2);

            decimal rata = sumaPrincipala * dobandaLunara / (1 - (decimal)Math.Pow(1 + (double)dobandaLunara, -perioadaLunii));
            return Math.Round(rata, 2);
        }

        // Metodă: Calculează suma totală de plată
        public decimal CalculeazaTotalDePlata()
        {
            return CalculeazaRataLunara() * perioadaLunii;
        }

        // Metodă: Verifică dacă creditul este activ
        public bool EsteActiv()
        {
            return statusCredit != null && statusCredit.ToLower() == "activ";
        }

        // Metodă: Data scadentă finală
        public DateTime DataScadentaFinala()
        {
            return dataAcordarii.AddMonths(perioadaLunii);
        }

        // Metodă: Validare sumă și perioadă
        public bool EsteValid()
        {
            return sumaPrincipala > 0 && perioadaLunii > 0 && rataDobanzii >= 0;
        }

        public override string ToString()
        {
            return $"ID: {idCredit} | Client: {idClient} | Suma: {sumaPrincipala} | Dobândă: {rataDobanzii}% | Perioadă: {perioadaLunii} luni | Acordat: {dataAcordarii.ToShortDateString()} | Status: {statusCredit}";
        }

        public object Clone()
        {
            return new Credit(idCredit, idClient, sumaPrincipala, rataDobanzii, perioadaLunii, dataAcordarii, statusCredit);
        }

        public int CompareTo(Credit other)
        {
            if (other == null) return 1;
            return sumaPrincipala.CompareTo(other.sumaPrincipala);
        }

        public static bool operator >(Credit c1, Credit c2)
        {
            if (c1 != null && c2 == null) return true;
            if (c1 == null && c2 != null) return false;
            if (c1 == null && c2 == null) return false;
            return c1.sumaPrincipala > c2.sumaPrincipala;
        }

        public static bool operator <(Credit c1, Credit c2)
        {
            if (c1 != null && c2 == null) return false;
            if (c1 == null && c2 != null) return true;
            if (c1 == null && c2 == null) return false;
            return c1.sumaPrincipala < c2.sumaPrincipala;
        }

        public static decimal operator +(Credit c1, Credit c2)
        {
            if (c1 == null && c2 == null) return 0;
            if (c1 == null) return c2.sumaPrincipala;
            if (c2 == null) return c1.sumaPrincipala;
            return c1.sumaPrincipala + c2.sumaPrincipala;
        }

        public static decimal operator -(Credit c1, Credit c2)
        {
            if (c1 == null && c2 == null) return 0;
            if (c1 == null) return -c2.sumaPrincipala;
            if (c2 == null) return c1.sumaPrincipala;
            return c1.sumaPrincipala - c2.sumaPrincipala;
        }

        
        public static bool operator ==(Credit c1, Credit c2)
        {
            if (ReferenceEquals(c1, c2)) return true;
            if (ReferenceEquals(c1, null) || ReferenceEquals(c2, null)) return false;
            return c1.idCredit == c2.idCredit;
        }

        public static bool operator !=(Credit c1, Credit c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Credit other)
                return this == other;
            return false;
        }

        public override int GetHashCode()
        {
            return idCredit.GetHashCode();
        }
    }
}