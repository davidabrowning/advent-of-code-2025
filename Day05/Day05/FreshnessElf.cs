using System.Numerics;

namespace Day05
{
    public class FreshnessElf
    {
        public List<BigInteger> GetFreshIngredients(IEnumerable<IngredientIdRange> ranges, IEnumerable<BigInteger> ids)
        {
            List<BigInteger> freshIds = new();
            foreach (BigInteger id in ids)
                if (IsFresh(ranges, id))
                    freshIds.Add(id);
            return freshIds;
        }

        private bool IsFresh(IEnumerable<IngredientIdRange> ranges, BigInteger id)
        {
            foreach (IngredientIdRange range in ranges)
                if (range.Contains(id))
                    return true;
            return false;
        }
    }
}
