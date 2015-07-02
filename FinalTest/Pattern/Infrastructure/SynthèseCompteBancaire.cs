using System;

namespace FinalTest.Tests
{
    public class SynthèseCompteBancaire
    {
        private readonly string _numéroDeCompte;
        private readonly int _debits;
        private readonly int _credits;

        protected bool Equals(SynthèseCompteBancaire other)
        {
            return string.Equals(_numéroDeCompte, other._numéroDeCompte) && _credits == other._credits && _debits == other._debits;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((SynthèseCompteBancaire) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_numéroDeCompte != null ? _numéroDeCompte.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ _credits;
                hashCode = (hashCode*397) ^ _debits;
                return hashCode;
            }
        }

        public SynthèseCompteBancaire(string numéroDeCompte, int debits, int credits)
        {
            _numéroDeCompte = numéroDeCompte;
            _debits = debits;
            _credits = credits;
        }

    }
}