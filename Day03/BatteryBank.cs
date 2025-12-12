
using System.Numerics;

namespace Day03
{
    public class BatteryBank
    {
        public required string Batteries { get; set; }

        public BigInteger MaxJoltage(int numBatteries)
        {
            BigInteger totalJoltage = 0;
            string availableBatteries = Batteries;

            for (int i = 0; i < numBatteries; i++)
            {
                List<int> individualJoltages = new();

                // Find max joltage
                foreach (char c in availableBatteries)
                    individualJoltages.Add(Convert.ToInt32(c.ToString()));
                for (int j = 0; j < (numBatteries - i - 1); j++)
                    individualJoltages.RemoveAt(individualJoltages.Count - 1);
                int maxIndividualJoltage = individualJoltages.Max();

                // Combine joltages
                totalJoltage += (BigInteger)(Math.Pow(10, (numBatteries - i - 1)) * maxIndividualJoltage);

                // Update remaining available batteries
                int index = individualJoltages.IndexOf(maxIndividualJoltage);
                availableBatteries = availableBatteries.Substring(index + 1);
            }
            return totalJoltage;
        }
    }
}
