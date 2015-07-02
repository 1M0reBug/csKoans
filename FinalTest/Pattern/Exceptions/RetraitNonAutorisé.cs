using System;

namespace FinalTest.Pattern
{
    public class RetraitNonAutorisé : Exception
    {
        public RetraitNonAutorisé()
        {
        }

        public RetraitNonAutorisé(string message) : base(message)
        {
        }

        public RetraitNonAutorisé(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}