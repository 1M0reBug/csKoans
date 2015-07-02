using System;

namespace FinalTest.Tests
{
    public class Synth�seCompteBancaire
    {
        private readonly string _num�roDeCompte;
        private readonly int _debits;
        private readonly int _credits;

        protected bool Equals(Synth�seCompteBancaire other)
        {
            return string.Equals(_num�roDeCompte, other._num�roDeCompte) && _credits == other._credits && _debits == other._debits;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Synth�seCompteBancaire) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_num�roDeCompte != null ? _num�roDeCompte.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ _credits;
                hashCode = (hashCode*397) ^ _debits;
                return hashCode;
            }
        }

        public Synth�seCompteBancaire(string num�roDeCompte, int debits, int credits)
        {
            _num�roDeCompte = num�roDeCompte;
            _debits = debits;
            _credits = credits;
        }

    }
}