using System;

namespace FinalTest.Pattern
{
    public class RetraitNonAutorisť : Exception
    {
        public RetraitNonAutorisť()
        {
        }

        public RetraitNonAutorisť(string message) : base(message)
        {
        }

        public RetraitNonAutorisť(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}