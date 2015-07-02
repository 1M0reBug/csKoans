using System;
using FinalTest.Pattern.Evenements;

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
            _repository.Save(retraitRéalisé);
        }
    }
}