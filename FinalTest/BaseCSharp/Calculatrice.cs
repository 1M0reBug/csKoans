namespace FinalTest.BaseCSharp
{
    public class Calculatrice
    {
        private IOperation[] _operations;
        public Calculatrice(IOperation[] operations)
        {
            _operations = operations;
        }


        public int Calculer(string p0)
        {
            foreach (var operation in _operations)
            {
                if (operation.PeutCalculer(p0))
                {
                    return operation.Calculer(p0);
                }
            }

            return 0;
        }
    }
}