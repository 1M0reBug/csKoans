using System;

namespace FinalTest.Pattern
{
    public class RetraitNonAutoris� : Exception
    {
        public RetraitNonAutoris�()
        {
        }

        public RetraitNonAutoris�(string message) : base(message)
        {
        }

        public RetraitNonAutoris�(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}