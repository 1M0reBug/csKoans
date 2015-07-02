using System;
using FinalTest.Tests;

namespace FinalTest.Pattern.Evenements
{
    public class RetraitRéalisé : IEvénementMétier
    {
        private readonly string _numéroDeCompte;
        private readonly Montant _montantRetrait;
        private readonly DateTime _dateRetrait;

        public RetraitRéalisé(string numéroDeCompte, Montant montantRetrait, DateTime dateRetrait)
        {
            _numéroDeCompte = numéroDeCompte;
            _montantRetrait = montantRetrait;
            _dateRetrait = dateRetrait;
        }

        public string NuméroDeCompte
        {
            get { return _numéroDeCompte; }
        }

        public Montant MontantRetrait
        {
            get { return _montantRetrait; }
        }

        public DateTime DateRetrait
        {
            get { return _dateRetrait; }
        }

        protected bool Equals(RetraitRéalisé other)
        {
            return string.Equals(_numéroDeCompte, other._numéroDeCompte) && Equals(_montantRetrait, other._montantRetrait) && _dateRetrait.Equals(other._dateRetrait);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((RetraitRéalisé) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_numéroDeCompte != null ? _numéroDeCompte.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (_montantRetrait != null ? _montantRetrait.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ _dateRetrait.GetHashCode();
                return hashCode;
            }
        }
    }
}