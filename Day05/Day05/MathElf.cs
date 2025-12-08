using System.Numerics;

namespace Day05
{
    public class MathElf
    {
        public List<IngredientIdRange> CombineRanges(IEnumerable<IngredientIdRange> ranges)
        {
            for (int i = 0; i < ranges.Count(); i++)
            {
                for (int j = i + 1; j < ranges.Count(); j++)
                {
                    if (Overlap(ranges.ElementAt(i), ranges.ElementAt(j)))
                    {
                        ranges.ElementAt(j).Min = BigInteger.Min(ranges.ElementAt(i).Min, ranges.ElementAt(j).Min);
                        ranges.ElementAt(j).Max = BigInteger.Max(ranges.ElementAt(i).Max, ranges.ElementAt(j).Max);
                        ranges.ElementAt(i).Min = -1;
                        ranges.ElementAt(i).Max = -1;
                    }
                }
            }
            List<IngredientIdRange> uniqueRanges = new();
            foreach (IngredientIdRange range in ranges)
            {
                if (range.Min > 0)
                    uniqueRanges.Add(range);
            }
            return uniqueRanges;
        }

        private bool Overlap(IngredientIdRange a, IngredientIdRange b)
        {
            if (a.Max < b.Min)
                return false;
            if (b.Max < a.Min)
                return false;
            return true;
        }

        public BigInteger CountFreshIds(IEnumerable<IngredientIdRange> ranges)
        {
            IEnumerable<IngredientIdRange> uniqueRanges = CombineRanges(ranges);
            BigInteger count = 0;
            foreach (IngredientIdRange range in uniqueRanges)
            {
                count += 1 + range.Max - range.Min;
            }
            return count;
        }
    }
}
