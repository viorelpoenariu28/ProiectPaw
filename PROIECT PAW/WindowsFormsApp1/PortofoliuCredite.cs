using System;
using System.Collections;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    internal class PortofoliuCredite : ICloneable, IComparable<PortofoliuCredite>, IEnumerable<Credit>
    {
        private Credit[] credite;
        private int numarCredite;
        private int capacitateMaxima;

        public PortofoliuCredite()
        {
            capacitateMaxima = 10;
            credite = new Credit[capacitateMaxima];
            numarCredite = 0;
        }

        public PortofoliuCredite(int capacitateMaxima)
        {
            this.capacitateMaxima = capacitateMaxima;
            credite = new Credit[capacitateMaxima];
            numarCredite = 0;
        }

        public int NumarCredite => numarCredite;
        public int CapacitateMaxima => capacitateMaxima;

        // Proprietate pentru valoarea totală a creditelor
        public decimal ValoareTotala
        {
            get
            {
                decimal total = 0;
                for (int i = 0; i < numarCredite; i++)
                {
                    if (credite[i] != null)
                        total += credite[i].SumaPrincipala;
                }
                return total;
            }
        }

        // Indexer
        public Credit this[int index]
        {
            get
            {
                if (index >= 0 && index < numarCredite)
                    return credite[index];
                else
                    return null;
            }
            set
            {
                if (index >= 0 && index < numarCredite)
                    credite[index] = value;
                else
                    throw new IndexOutOfRangeException();
            }
        }

        // Adaugă un credit în portofoliu
        public void AdaugaCredit(Credit credit)
        {
            if (numarCredite >= capacitateMaxima)
            {
                Array.Resize(ref credite, capacitateMaxima * 2);
                capacitateMaxima *= 2;
            }
            credite[numarCredite++] = credit;
        }

        // Elimină un credit după index
        public void EliminaCredit(int index)
        {
            if (index >= 0 && index < numarCredite)
            {
                for (int i = index; i < numarCredite - 1; i++)
                {
                    credite[i] = credite[i + 1];
                }
                credite[numarCredite - 1] = null;
                numarCredite--;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        // Găsește toate creditele pentru un client
        public List<Credit> GasesteCrediteClient(int idClient)
        {
            var lista = new List<Credit>();
            for (int i = 0; i < numarCredite; i++)
            {
                if (credite[i] != null && credite[i].IdClient == idClient)
                    lista.Add(credite[i]);
            }
            return lista;
        }

        // IEnumerable pentru foreach
        public IEnumerator<Credit> GetEnumerator()
        {
            for (int i = 0; i < numarCredite; i++)
            {
                yield return credite[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        // ICloneable
        public object Clone()
        {
            var clone = new PortofoliuCredite(this.capacitateMaxima);
            for (int i = 0; i < this.numarCredite; i++)
            {
                clone.AdaugaCredit((Credit)this.credite[i].Clone());
            }
            return clone;
        }

        // IComparable după valoarea totală
        public int CompareTo(PortofoliuCredite other)
        {
            if (other == null) return 1;
            return this.ValoareTotala.CompareTo(other.ValoareTotala);
        }

        // Operator > și <
        public static bool operator >(PortofoliuCredite p1, PortofoliuCredite p2)
        {
            if (p1 == null && p2 != null) return false;
            if (p1 != null && p2 == null) return true;
            if (p1 == null && p2 == null) return false;
            return p1.ValoareTotala > p2.ValoareTotala;
        }

        public static bool operator <(PortofoliuCredite p1, PortofoliuCredite p2)
        {
            if (p1 == null && p2 != null) return true;
            if (p1 != null && p2 == null) return false;
            if (p1 == null && p2 == null) return false;
            return p1.ValoareTotala < p2.ValoareTotala;
        }

        // Operator + (combină două portofolii)
        public static PortofoliuCredite operator +(PortofoliuCredite p1, PortofoliuCredite p2)
        {
            int totalCapacitate = (p1?.numarCredite ?? 0) + (p2?.numarCredite ?? 0);
            var rezultat = new PortofoliuCredite(Math.Max(totalCapacitate, 10));
            if (p1 != null)
            {
                for (int i = 0; i < p1.numarCredite; i++)
                    rezultat.AdaugaCredit((Credit)p1.credite[i].Clone());
            }
            if (p2 != null)
            {
                for (int i = 0; i < p2.numarCredite; i++)
                    rezultat.AdaugaCredit((Credit)p2.credite[i].Clone());
            }
            return rezultat;
        }

        // Operator ++ (adaugă un credit gol)
        public static PortofoliuCredite operator ++(PortofoliuCredite p)
        {
            p.AdaugaCredit(new Credit());
            return p;
        }
    }
}