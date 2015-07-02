using System;
using FinalTest.Tests;

namespace FinalTest.Pattern.Evenements
{
    public class BalanceNégativeDétectée : IEvénementMétier
    {
        private readonly string _numéroDeCompte;
        private readonly Montant _montant;
        private readonly DateTime _dateRetrait;

        public BalanceNégativeDétectée(string numéroDeCompte, Montant montant, DateTime dateRetrait)
        {
            _numéroDeCompte = numéroDeCompte;
            _montant = montant;
            _dateRetrait = dateRetrait;
        }

        protected bool Equals(BalanceNégativeDétectée other)
        {
            return string.Equals(_numéroDeCompte, other._numéroDeCompte) && Equals(_montant, other._montant) && _dateRetrait.Equals(other._dateRetrait);
        }

        public override string ToString()
        {
            return string.Format("NuméroDeCompte: {0}, Montant: {1}, DateRetrait: {2}", _numéroDeCompte, _montant, _dateRetrait);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((BalanceNégativeDétectée) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_numéroDeCompte != null ? _numéroDeCompte.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (_montant != null ? _montant.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ _dateRetrait.GetHashCode();
                return hashCode;
            }
        }
    }
}