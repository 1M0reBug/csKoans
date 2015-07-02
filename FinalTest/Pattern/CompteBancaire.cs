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
        private List<IEvénementMétier> _evenements;

        private string _numeroDeCompte;

        private Montant _montant;
        private int _autorisationDeCrédit;


        public CompteBancaire(CompteCréé compte)
        {
            _evenements = new List<IEvénementMétier>();
            _numeroDeCompte = compte.NuméroDeCompte;
            _autorisationDeCrédit = compte.AutorisationDeCrédit;
            _montant = new Montant(0);
        }

        public CompteBancaire(CompteCréé compte, DépotRéalisé dépotRéalisé)
        {
            _evenements = new List<IEvénementMétier>();
            _numeroDeCompte = compte.NuméroDeCompte;
            _autorisationDeCrédit = compte.AutorisationDeCrédit;
            _montant = new Montant(dépotRéalisé.MontantDepot.Montant1);

        }


        public static IEnumerable<IEvénementMétier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
            yield return new CompteCréé(numéroDeCompte, autorisationDeCrédit);

        }

        public IEnumerable<IEvénementMétier> FaireUnDepot(Montant montantDepot, DateTime dateDepot)
        {
            DépotRéalisé depot = new DépotRéalisé(_numeroDeCompte, montantDepot, dateDepot);
            _montant.Add(montantDepot);
            yield return depot;
        }

        public IEnumerable<IEvénementMétier> FaireUnRetrait(Montant montantRetrait, DateTime dateRetrait)
        {
            RetraitRéalisé retrait = new RetraitRéalisé(_numeroDeCompte, montantRetrait, dateRetrait);
            _evenements.Add(retrait);
            if (montantRetrait.Montant1 > _autorisationDeCrédit)
            {
                throw new RetraitNonAutorisé("La valeur du retrait est supérieurs à la valeure maximale autorisée !");
            }

            if (montantRetrait.Montant1 > _montant.Montant1)
            {
                Montant mt = new Montant(Math.Abs(_montant.Montant1 - montantRetrait.Montant1));
                _evenements.Add(new BalanceNégativeDétectée(_numeroDeCompte, mt, dateRetrait));
            }

            _montant.Sub(montantRetrait);

            return _evenements;
        }
    }
}