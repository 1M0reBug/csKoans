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

        public int Montant1
        {
            get { return _montant; }
        }

        public override string ToString()
        {
            return string.Format("Montant: {0}, Montant1: {1}", _montant, Montant1);
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

        public void Add(Montant montant)
        {
            _montant += montant.Montant1;
        }

        public void Sub(Montant montantRetrait)
        {
            _montant -= montantRetrait.Montant1;
        }
    }
}