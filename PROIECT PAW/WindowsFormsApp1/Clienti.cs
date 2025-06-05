using System;

namespace WindowsFormsApp1
{
     public class Clienti : ICloneable, IComparable<Clienti>
    {
        private int id;
        private string nume;
        private string prenume;
        private string cnp;
        private string telefon;
        private string email;
        private string adresa;
        private decimal venitLunar;
        private int scorCredit;

        public Clienti() { }

        public Clienti(int id, string nume, string prenume, string cnp, string telefon, string email, string adresa, decimal venitLunar, int scorCredit)
        {
            this.id = id;
            this.nume = nume;
            this.prenume = prenume;
            this.cnp = cnp;
            this.telefon = telefon;
            this.email = email;
            this.adresa = adresa;
            this.venitLunar = venitLunar;
            this.scorCredit = scorCredit;
        }

        public int Id { get => id; set => id = value; }
        public string Nume { get => nume; set => nume = value; }
        public string Prenume { get => prenume; set => prenume = value; }
        public string Cnp { get => cnp; set => cnp = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Email { get => email; set => email = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public decimal VenitLunar { get => venitLunar; set => venitLunar = value; }
        public int ScorCredit { get => scorCredit; set => scorCredit = value; }

        // Metodă: Nume complet
        public string NumeComplet() => $"{nume} {prenume}";

        // Metodă: Calculează vârsta din CNP (presupunem format corect)
        public int CalculeazaVarsta()
        {
            if (string.IsNullOrEmpty(cnp) || cnp.Length < 7) return 0;
            int an = int.Parse(cnp.Substring(1, 2));
            int luna = int.Parse(cnp.Substring(3, 2));
            int zi = int.Parse(cnp.Substring(5, 2));
            int secol = (cnp[0] == '1' || cnp[0] == '2') ? 1900 : 2000;
            an += secol;
            DateTime dataNasterii = new DateTime(an, luna, zi);
            int varsta = DateTime.Now.Year - dataNasterii.Year;
            if (DateTime.Now < dataNasterii.AddYears(varsta)) varsta--;
            return varsta;
        }

        // Metodă: Verifică dacă este major
        public bool EsteMajor() => CalculeazaVarsta() >= 18;

        // Metodă: Validare CNP simplă (doar lungime și cifre)
        public bool CnpValid()
        {
            if (string.IsNullOrEmpty(cnp) || cnp.Length != 13) return false;
            foreach (char c in cnp)
                if (!char.IsDigit(c)) return false;
            return true;
        }

        // Metodă: Actualizează scorul de credit
        public void ActualizeazaScorCredit(int puncte)
        {
            scorCredit += puncte;
            if (scorCredit > 1000) scorCredit = 1000;
            if (scorCredit < 0) scorCredit = 0;
        }

        // Metodă: Eligibilitate (poate fi refăcută după implementarea clasei Credit)
        public bool EsteEligibil(decimal sumaCredit, decimal rataLunara)
        {
            return scorCredit > 500 &&
                   sumaCredit <= (5 * venitLunar) &&
                   rataLunara <= (0.35m * venitLunar) &&
                   EsteMajor() &&
                   CnpValid();
        }

        public override string ToString()
        {
            return $"{nume} {prenume} (ID: {id}, Scor: {scorCredit}, Vârstă: {CalculeazaVarsta()})";
        }

        public object Clone()
        {
            return new Clienti(id, nume, prenume, cnp, telefon, email, adresa, venitLunar, scorCredit);
        }

        public int CompareTo(Clienti other)
        {
            if (other == null) return 1;
            return scorCredit.CompareTo(other.scorCredit);
        }

        public static bool operator >(Clienti c1, Clienti c2)
        {
            if (c1 == null && c2 != null) return false;
            if (c2 == null && c1 != null) return true;
            if (c1 != null && c2 != null) return c1.scorCredit > c2.scorCredit;
            return false;
        }

        public static bool operator <(Clienti c1, Clienti c2)
        {
            if (c1 == null && c2 != null) return true;
            if (c1 != null && c2 == null) return false;
            if (c1 != null && c2 != null) return c1.scorCredit < c2.scorCredit;
            return false;
        }

        public static bool operator ==(Clienti c1, Clienti c2)
        {
            if (ReferenceEquals(c1, c2)) return true;
            if (ReferenceEquals(c1, null) || ReferenceEquals(c2, null)) return false;
            return c1.id == c2.id;
        }

        public static bool operator !=(Clienti c1, Clienti c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Clienti other)
                return this == other;
            return false;
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
    }
}