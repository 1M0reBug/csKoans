using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalTest
{
    public class Nombres
    {
        private readonly IEnumerable<KeyValuePair<string, int>> _keyValuePairs;

        public Nombres(IEnumerable<KeyValuePair<string, int>> keyValuePairs)
        {
            _keyValuePairs = keyValuePairs;
        }

        public IEnumerable<int> NombresPairs
        {
            get { return _keyValuePairs.Select(s => s.Value).Where(v => v%2 == 0); }
        }


        public string TexteNombresImpairs
        {
            get
            {
                return
                    _keyValuePairs.Select(s => s)
                        .Where(s => s.Value % 2 != 0)
                        .OrderBy(a => a.Value)
                        .Select(s => s.Key)
                        .Aggregate((a, b) => a + ", " + b);
            }
        }

        public string PremierNombreDontLeTexteContientPlusDe5Caractères
        {
            get { return _keyValuePairs.First(s => s.Key.Length > 5).Key; }
        }

        public IEnumerable<int> QuatreNombresSupérieursSuivant3
        {
            get { return _keyValuePairs.Select(s => s.Value).OrderBy(s => s).Where(s => s > 3).Take(4); }
        }
    }
}