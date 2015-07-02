using System;
using FinalTest.Pattern.Evenements;
using FinalTest.Tests;

namespace FinalTest.Pattern
{
    public class SynthèseCompteBancaireProjection
    {
        private readonly IRepository _repository;

        public SynthèseCompteBancaireProjection(IRepository repository)
        {
            _repository = repository;
        }

        public void Handle(RetraitRéalisé retraitRéalisé)
        {
            SynthèseCompteBancaire synthese = new SynthèseCompteBancaire(retraitRéalisé.NuméroDeCompte, );
            _repository.Save(retraitRéalisé);
        }
    }
}