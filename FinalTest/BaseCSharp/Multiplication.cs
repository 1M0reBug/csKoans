using System;
using System.Linq;

namespace FinalTest.BaseCSharp
{
    public class Multiplication : IOperation
    {
        public Multiplication()
        {
        }

        public Boolean PeutCalculer(string p0)
        {
            return p0.Contains("*");
        }

        public int Calculer(int[] values)
        {
            return values.Aggregate(1, (current, value) => current * value);
        }

        public int Calculer(string s)
        {

            var valuesToMultiply = s.Split('*').Select(
                s2 =>
                {
                    var value = s2.Replace(" ", String.Empty);
                    return int.Parse(value);
                }).ToArray();
            return this.Calculer(valuesToMultiply);
        }
    }
}