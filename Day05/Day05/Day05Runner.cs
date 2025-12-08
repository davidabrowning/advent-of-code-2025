using System.Numerics;

namespace Day05
{
    public static class Day05Runner
    {
        public static void Run()
        {
            // Part 1
            string filename = "Day05PuzzleInput.txt";
            FileReaderElf readerElf = new();
            IEnumerable<IngredientIdRange> freshnessRanges = readerElf.GetRanges(filename);
            IEnumerable<BigInteger> idsInInventory = readerElf.GetIds(filename);
            FreshnessElf freshnessElf = new();
            IEnumerable<BigInteger> freshIdsInInventory = freshnessElf.GetFreshIngredients(freshnessRanges, idsInInventory);
            Console.WriteLine("Number of fresh ids in inventory: " + freshIdsInInventory.Count());

            // Part 2
            MathElf mathElf = new();
            BigInteger totalFreshIds = mathElf.CountFreshIds(freshnessRanges);
            Console.WriteLine("My total fresh ids count: " +  totalFreshIds);
        }
    }
}
