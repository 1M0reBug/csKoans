﻿namespace FinalTest.BaseCSharp
{
    public struct TypeValeur
    {

        private readonly int _valeur;
        public TypeValeur(int i)
        {
            _valeur = i;
        }

        public int Valeur
        {
            get { return _valeur; }
        }

    }
}