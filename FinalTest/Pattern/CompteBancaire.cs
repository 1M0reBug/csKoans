using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using FinalTest.Pattern.Evenements;
using FinalTest.Tests;

namespace FinalTest.Pattern
{
    
    public class CompteBancaire
    {
        private List<IEv�nementM�tier> _evenements;

        private string _numeroDeCompte;

        private Montant _montant;
        private int _autorisationDeCr�dit;


        public CompteBancaire(CompteCr�� compte)
        {
            _evenements = new List<IEv�nementM�tier>();
            _numeroDeCompte = compte.Num�roDeCompte;
            _autorisationDeCr�dit = compte.AutorisationDeCr�dit;
            _montant = new Montant(0);
        }

        public CompteBancaire(CompteCr�� compte, D�potR�alis� d�potR�alis�)
        {
            _evenements = new List<IEv�nementM�tier>();
            _numeroDeCompte = compte.Num�roDeCompte;
            _autorisationDeCr�dit = compte.AutorisationDeCr�dit;
            _montant = new Montant(d�potR�alis�.MontantDepot.Montant1);

        }


        public static IEnumerable<IEv�nementM�tier> Ouvrir(string num�roDeCompte, int autorisationDeCr�dit)
        {
            yield return new CompteCr��(num�roDeCompte, autorisationDeCr�dit);

        }

        public IEnumerable<IEv�nementM�tier> FaireUnDepot(Montant montantDepot, DateTime dateDepot)
        {
            D�potR�alis� depot = new D�potR�alis�(_numeroDeCompte, montantDepot, dateDepot);
            _montant.Add(montantDepot);
            yield return depot;
        }

        public IEnumerable<IEv�nementM�tier> FaireUnRetrait(Montant montantRetrait, DateTime dateRetrait)
        {
            RetraitR�alis� retrait = new RetraitR�alis�(_numeroDeCompte, montantRetrait, dateRetrait);
            _evenements.Add(retrait);
            if (montantRetrait.Montant1 > _autorisationDeCr�dit)
            {
                throw new RetraitNonAutoris�("La valeur du retrait est sup�rieurs � la valeure maximale autoris�e !");
            }

            if (montantRetrait.Montant1 > _montant.Montant1)
            {
                Montant mt = new Montant(Math.Abs(_montant.Montant1 - montantRetrait.Montant1));
                _evenements.Add(new BalanceN�gativeD�tect�e(_numeroDeCompte, mt, dateRetrait));
            }

            _montant.Sub(montantRetrait);

            return _evenements;
        }
    }
}