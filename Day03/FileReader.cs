
using System.Data;

namespace Day03
{
    public static class FileReader
    {
        public static IEnumerable<string> GetRows(string filename)
        {
            return File.ReadAllLines(filename);
        }

        public static List<BatteryBank> GetBatteryBanks(string filename)
        {
            IEnumerable<string> rows = GetRows(filename);
            List<BatteryBank> powerBanks = new();
            foreach (string row in rows)
            {
                powerBanks.Add(new BatteryBank() { Batteries = row });
            }
            return powerBanks;
        }
    }
}
