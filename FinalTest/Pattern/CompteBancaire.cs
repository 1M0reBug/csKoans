using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using FinalTest.Tests;

namespace FinalTest.Pattern
{
    
    public class CompteBancaire
    {
        private List<IEvenementMetier> _evenements;

        private string _numeroDeCompte;

        public CompteBancaire(CompteCr�� compte)
        {
            _evenements = new List<IEvenementMetier>();
            _numeroDeCompte = compte.Num�roDeCompte;
        }


        public static IEnumerable<IEvenementMetier> Ouvrir(string num�roDeCompte, int autorisationDeCr�dit)
        {
            yield return new CompteCr��(num�roDeCompte, autorisationDeCr�dit);

        }

        public IEnumerable<IEvenementMetier> FaireUnDepot(Montant montantDepot, DateTime dateDepot)
        {
            D�potR�alis� depot = new D�potR�alis�(_numeroDeCompte, montantDepot, dateDepot);
            _evenements.Add(depot);

            return _evenements;
        }
    }
}