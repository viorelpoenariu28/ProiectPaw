using System;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    internal class Banca : ICloneable, IComparable<Banca>
    {
        private string numeBanca;
        private string codBanca;
        private List<Clienti> clienti;
        private PortofoliuCredite portofoliu;

        public Banca(string numeBanca, string codBanca)
        {
            this.numeBanca = numeBanca;
            this.codBanca = codBanca;
            this.clienti = new List<Clienti>();
            this.portofoliu = new PortofoliuCredite();
        }

        public string NumeBanca { get => numeBanca; set => numeBanca = value; }
        public string CodBanca { get => codBanca; set => codBanca = value; }
        public List<Clienti> Clienti { get => clienti; }
        public PortofoliuCredite Portofoliu { get => portofoliu; }

        // ICloneable
        public object Clone()
        {
            Banca clone = new Banca(this.numeBanca, this.codBanca);
            foreach (var client in this.clienti)
                clone.clienti.Add((Clienti)client.Clone());
            clone.portofoliu = (PortofoliuCredite)this.portofoliu.Clone();
            return clone;
        }

        // IComparable<Banca> - compară după suma totală a creditelor
        public int CompareTo(Banca other)
        {
            if (other == null) return 1;
            return this.portofoliu.ValoareTotala.CompareTo(other.portofoliu.ValoareTotala);
        }

        // Operator > și <
        public static bool operator >(Banca b1, Banca b2)
        {
            if (b1 == null && b2 != null) return false;
            if (b1 != null && b2 == null) return true;
            if (b1 == null && b2 == null) return false;
            return b1.portofoliu.ValoareTotala > b2.portofoliu.ValoareTotala;
        }

        public static bool operator <(Banca b1, Banca b2)
        {
            if (b1 == null && b2 != null) return true;
            if (b1 != null && b2 == null) return false;
            if (b1 == null && b2 == null) return false;
            return b1.portofoliu.ValoareTotala < b2.portofoliu.ValoareTotala;
        }

        // Operator + (combină două bănci)
        public static Banca operator +(Banca b1, Banca b2)
        {
            string numeNou = b1.numeBanca + "-" + b2.numeBanca;
            string codNou = b1.codBanca + "-" + b2.codBanca;
            Banca rezultat = new Banca(numeNou, codNou);

            foreach (var client in b1.clienti)
                rezultat.clienti.Add((Clienti)client.Clone());
            foreach (var client in b2.clienti)
                rezultat.clienti.Add((Clienti)client.Clone());

            rezultat.portofoliu = b1.portofoliu + b2.portofoliu;
            return rezultat;
        }

        // Operator == și != (după codBanca)
        public static bool operator ==(Banca b1, Banca b2)
        {
            if (ReferenceEquals(b1, b2)) return true;
            if (ReferenceEquals(b1, null) || ReferenceEquals(b2, null)) return false;
            return b1.codBanca == b2.codBanca;
        }

        public static bool operator !=(Banca b1, Banca b2)
        {
            return !(b1 == b2);
        }

        // Suprascrie Equals și GetHashCode pentru == și !=
        public override bool Equals(object obj)
        {
            if (obj is Banca other)
                return this == other;
            return false;
        }

        public override int GetHashCode()
        {
            return codBanca.GetHashCode();
        }

        // Metode de prelucrare
        public void AdaugaClient(Clienti client)
        {
            clienti.Add(client);
        }

        public Clienti GasesteClientDupaId(int id)
        {
            return clienti.Find(c => c.Id == id);
        }

        public void AcordaCredit(Credit credit)
        {
            portofoliu.AdaugaCredit(credit);
        }

        public List<Credit> CrediteClient(int idClient)
        {
            return portofoliu.GasesteCrediteClient(idClient);
        }

        public decimal SumaTotalaCredite()
        {
            return portofoliu.ValoareTotala;
        }

        public override string ToString()
        {
            return $"Banca: {numeBanca} ({codBanca})\n" +
                   $"Număr clienți: {clienti.Count}\n" +
                   $"Număr credite: {portofoliu.NumarCredite}\n" +
                   $"Suma totală credite: {portofoliu.ValoareTotala}";
        }
    }
}