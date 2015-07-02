using System;

namespace FinalTest
{
    public class TypeReference
    {
        private int _valeur;


        public TypeReference(int i)
        {
            _valeur = i;
        }

        protected bool Equals(TypeReference other)
        {
            return _valeur == other._valeur;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((TypeReference) obj);
        }

        public override int GetHashCode()
        {
            return _valeur;
        }
    }
}