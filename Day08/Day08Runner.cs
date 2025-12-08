using System.Numerics;

namespace Day08
{
    public static class Day08Runner
    {
        public static void Run()
        {
            // Part 1
            string filename = "Day08PuzzleInput.txt";
            FileReader fileReader = new();
            IEnumerable<JunctionBox> junctionBoxes = fileReader.GetJunctionBoxes(filename);
            BoxMap boxMap = new BoxMap();
            boxMap.Add(junctionBoxes);
            for (int i = 0; i < 1000; i++)
            {
                // boxMap.ConnectShortestUnconnected();
            }
            IEnumerable<Circuit> orderedCircuits = boxMap.OrderedCircuits();
            BigInteger product = 1;
            for (int i = 0; i < 3; i++)
            {
                product *= orderedCircuits.ElementAt(i).JunctionBoxes.Count;
            }
            Console.WriteLine("Product of the sizes of the three largest circuits: " + product);

            // Part 2
            while (boxMap.Circuits.Count > 1)
                boxMap.ConnectShortestUnconnected();
            BigInteger xProduct = boxMap.LatestConnection.ElementAt(0).X
                * boxMap.LatestConnection.ElementAt(1).X;
            Console.WriteLine("Product of the last two boxes' X coordinates: " + xProduct);
        }
    }
}
