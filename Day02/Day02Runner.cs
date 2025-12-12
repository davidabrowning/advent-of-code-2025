
using System.Numerics;

namespace Day02
{
    public static class Day02Runner
    {
        public static void Run()
        {
            string filename = "Day02PuzzleInput.txt";
            IEnumerable<IdRange> idRanges = FileReader.GetIdRanges(filename);

            // Part 1
            Console.WriteLine("Sum: " + IdMath.SumInvalidIds(idRanges));

            // Part 2
            Console.WriteLine("Sum (advanced): " + IdMath.SumInvalidIdsAdvanced(idRanges));
        }
    }
}
