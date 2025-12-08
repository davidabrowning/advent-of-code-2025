using System.Numerics;

namespace Day07
{
    public static class Day07Runner
    {
        public static void Run()
        {
            string filename = "Day07PuzzleInput.txt";
            FileElf fileElf = new();

            // Part 1
            Manifold manifold1 = fileElf.GetManifoldFromFile(filename);
            manifold1.ProcessBeam();
            int splitCount = manifold1.CountSplits();
            Console.WriteLine("Split count: " + splitCount);

            // Part 2
            Manifold manifold2 = fileElf.GetManifoldFromFile(filename);
            manifold2.ProcessBeamPathsMathematically();
            BigInteger beamPathCount = manifold2.CountBeamPathsMathematically();
            Console.WriteLine("Beam path count: " +  beamPathCount);
        }
    }
}
