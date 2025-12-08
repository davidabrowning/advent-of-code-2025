using System.Numerics;

namespace Day06
{
    public class RightMathElf
    {
        public BigInteger Calculate(IEnumerable<IEnumerable<int>> integerLists, IEnumerable<string> operators)
        {
            BigInteger total = 0;
            for (int i = 0; i < operators.Count(); i++)
            {
                if (operators.ElementAt(i) == "+")
                    total += GetSum(integerLists.ElementAt(i));
                if (operators.ElementAt(i) == "*")
                    total += GetProduct(integerLists.ElementAt(i));
            }
            return total;
        }

        private BigInteger GetProduct(IEnumerable<int> integers)
        {
            BigInteger subtotal = 1;
            foreach (int integer in integers)
                subtotal *= integer;
            return subtotal;
        }

        private BigInteger GetSum(IEnumerable<int> integers)
        {
            BigInteger subtotal = 0;
            foreach (int integer in integers)
                subtotal += integer;
            return subtotal;
        }
    }
}
