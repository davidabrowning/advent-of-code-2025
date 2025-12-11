using System.Numerics;

namespace Day09
{
    public static class Day09Runner
    {
        public static void Run()
        {
            string filename = "Day09PuzzleInput.txt";
            FileReader fileReader = new();
            IEnumerable<Tile> redTiles = fileReader.GetRedTiles(filename);

            // Part 1
            BigInteger maxArea = TheaterMath.MaxArea(redTiles);
            Console.WriteLine("Max area: " + maxArea);

            // Part 2
            BigInteger maxAreaRedGreenOnly = TheaterMath.MaxAreaRedGreenOnly(redTiles);
            Console.WriteLine("Max area using only red and green tiles: " + maxAreaRedGreenOnly);
        }
    }
}
