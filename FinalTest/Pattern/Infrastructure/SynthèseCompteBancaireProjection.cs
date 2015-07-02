using System;
using FinalTest.Pattern.Evenements;
using FinalTest.Tests;

namespace FinalTest.Pattern
{
    public class Synth�seCompteBancaireProjection
    {
        private readonly IRepository _repository;

        public Synth�seCompteBancaireProjection(IRepository repository)
        {
            _repository = repository;
        }

        public void Handle(RetraitR�alis� retraitR�alis�)
        {
            _repository.Save(retraitR�alis�);
        }
    }
}