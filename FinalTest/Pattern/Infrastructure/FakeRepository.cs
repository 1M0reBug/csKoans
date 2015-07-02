using System;
using System.Collections.Generic;
using FinalTest.Pattern.Evenements;
using FinalTest.Tests;

namespace FinalTest.Pattern
{
    public class FakeRepository : IRepository
    {
        private readonly List<Synth�seCompteBancaire> _synth�ses;

        public FakeRepository()
        {
        }

        public List<Synth�seCompteBancaire> Synth�ses
        {
            get { return _synth�ses; }
        }

        public void Save(RetraitR�alis� retraitR�alis�)
        {
        }

        public Montant GetMontantFromNumeroCompte(string numeroCompte)
        {
            throw new NotImplementedException();
        }
    }
}