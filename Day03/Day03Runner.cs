using System.Numerics;

namespace Day03
{
    public static class Day03Runner
    {
        public static void Run()
        {
            string filename = "Day03PuzzleInput.txt";
            IEnumerable<BatteryBank> batteryBanks = FileReader.GetBatteryBanks(filename);
            
            // Part 1
            Console.WriteLine("Total output joltage choosing 2: " + SumJoltages(batteryBanks, 2));

            // Part 2
            Console.WriteLine("Total output joltage choosing 12: " + SumJoltages(batteryBanks, 12));
        }

        private static BigInteger SumJoltages(IEnumerable<BatteryBank> batteryBanks, int numBatteries)
        {
            BigInteger totalOutputJoltage = 0;
            foreach (BatteryBank batteryBank in batteryBanks)
                totalOutputJoltage += batteryBank.MaxJoltage(numBatteries);
            return totalOutputJoltage;
        }
    }
}
