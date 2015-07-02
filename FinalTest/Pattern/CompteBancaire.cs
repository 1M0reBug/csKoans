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

        public CompteBancaire(CompteCréé compte)
        {
            _evenements = new List<IEvenementMetier>();
            _numeroDeCompte = compte.NuméroDeCompte;
        }


        public static IEnumerable<IEvenementMetier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
            yield return new CompteCréé(numéroDeCompte, autorisationDeCrédit);

        }

        public IEnumerable<IEvenementMetier> FaireUnDepot(Montant montantDepot, DateTime dateDepot)
        {
            DépotRéalisé depot = new DépotRéalisé(_numeroDeCompte, montantDepot, dateDepot);
            _evenements.Add(depot);

            return _evenements;
        }
    }
}