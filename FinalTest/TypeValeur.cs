namespace FinalTest
{
    public struct TypeValeur
    {

        private int _valeur;
        public TypeValeur(int i)
        {
            _valeur = i;
        }

        public int Valeur
        {
            get { return _valeur; }
            set { _valeur = value; }
        }
    }
}