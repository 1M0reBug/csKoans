using System;

namespace FinalTest.Tests
{
    public class Montant
    {
        private int _montant;
        public Montant(int montant)
        {
            this._montant = montant;
        }

        protected bool Equals(Montant other)
        {
            return _montant == other._montant;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Montant) obj);
        }

        public override int GetHashCode()
        {
            return _montant;
        }
    }
}