using System.Numerics;

namespace Day06
{
    public class LeftMathElf
    {
        public BigInteger Calculate(IEnumerable<IEnumerable<int>> integersArray, IEnumerable<string> operators)
        {
            BigInteger total = 0;
            for (int i = 0; i < operators.Count(); i++)
            {
                BigInteger subtotal = 0;
                if (operators.ElementAt(i) == "*")
                {
                    subtotal = 1;
                    foreach (IEnumerable<int> integersRow in integersArray)
                    {
                        subtotal *= integersRow.ElementAt(i);
                    }
                }
                if (operators.ElementAt(i) == "+")
                {
                    foreach (IEnumerable<int> integersRow in integersArray)
                    {
                        subtotal += integersRow.ElementAt(i);
                    }
                }
                total += subtotal;
            }
            return total;
        }
    }
}
