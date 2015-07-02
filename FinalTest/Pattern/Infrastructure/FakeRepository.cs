using System;
using System.Collections.Generic;
using FinalTest.Pattern.Evenements;
using FinalTest.Tests;

namespace FinalTest.Pattern
{
    public class FakeRepository : IRepository
    {
        private readonly List<SynthèseCompteBancaire> _synthèses;

        public FakeRepository()
        {
        }

        public List<SynthèseCompteBancaire> Synthèses
        {
            get { return _synthèses; }
        }

        public void Save(RetraitRéalisé retraitRéalisé)
        {
        }

        public Montant GetMontantFromNumeroCompte(string numeroCompte)
        {
            throw new NotImplementedException();
        }
    }
}