using System;
using FinalTest.Tests;

namespace FinalTest.Pattern
{
    public class D�potR�alis� : IEvenementMetier
    {
        private readonly string _numeroDeCompte;
        private readonly Montant _montantDepot;
        private readonly DateTime _dateDepot;

        public D�potR�alis�(string numeroDeCompte, Montant montantDepot, DateTime dateDepot)
        {
            _numeroDeCompte = numeroDeCompte;
            _montantDepot = montantDepot;
            _dateDepot = dateDepot;
        }

        protected bool Equals(D�potR�alis� other)
        {
            return string.Equals(_numeroDeCompte, other._numeroDeCompte) && Equals(_montantDepot, other._montantDepot) && _dateDepot.Equals(other._dateDepot);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((D�potR�alis�) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_numeroDeCompte != null ? _numeroDeCompte.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (_montantDepot != null ? _montantDepot.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ _dateDepot.GetHashCode();
                return hashCode;
            }
        }
    }
}