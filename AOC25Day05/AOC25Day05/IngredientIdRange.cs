using System.Numerics;

namespace Day05
{
    public class IngredientIdRange
    {
        public BigInteger Min;
        public BigInteger Max;

        public IngredientIdRange(BigInteger min, BigInteger max)
        {
            Min = min;
            Max = max;
        }

        public bool Contains(BigInteger num)
        {
            return Min <= num && num <= Max;
        }
    }
}
