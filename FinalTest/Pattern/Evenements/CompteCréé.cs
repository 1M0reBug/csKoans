namespace FinalTest.Pattern.Evenements
{
    public class CompteCréé : IEvénementMétier
    {
        private readonly string _numéroDeCompte;
        private readonly int _autorisationDeCrédit;

        public CompteCréé(string numéroDeCompte, int autorisationDeCrédit)
        {
            _numéroDeCompte = numéroDeCompte;
            _autorisationDeCrédit = autorisationDeCrédit;
        }

        public string NuméroDeCompte
        {
            get { return _numéroDeCompte; }
        }

        public int AutorisationDeCrédit
        {
            get { return _autorisationDeCrédit; }
        }

        protected bool Equals(CompteCréé other)
        {
            return string.Equals(_numéroDeCompte, other._numéroDeCompte) && _autorisationDeCrédit == other._autorisationDeCrédit;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((CompteCréé) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((_numéroDeCompte != null ? _numéroDeCompte.GetHashCode() : 0)*397) ^ _autorisationDeCrédit;
            }
        }
    }
}