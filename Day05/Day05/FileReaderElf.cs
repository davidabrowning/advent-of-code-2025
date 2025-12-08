using System.Numerics;

namespace Day05
{
    public class FileReaderElf
    {
        private string GetFileText(string filename)
        {
            return File.ReadAllText(filename);
        }

        public List<IngredientIdRange> GetRanges(string filename)
        {
            string fileText = GetFileText(filename);
            List<IngredientIdRange> ranges = new();
            foreach (string line in fileText.Split("\r\n"))
            {
                if (!line.Contains("-"))
                    continue;
                string[] lineParts = line.Split("-");
                BigInteger min = BigInteger.Parse(lineParts[0]);
                BigInteger max = BigInteger.Parse(lineParts[1]);
                IngredientIdRange range = new(min, max);
                ranges.Add(range);
            }
            return ranges;
        }

        public List<BigInteger> GetIds(string filename)
        {
            string fileText = GetFileText(filename);
            List<BigInteger> ids = new();
            foreach (string line in fileText.Split("\r\n"))
            {
                if (line.Contains("-"))
                    continue;
                if (line == string.Empty)
                    continue;
                if (line == "\r")
                    continue;
                BigInteger id = BigInteger.Parse(line);
                ids.Add(id);
            }
            return ids;
        }
    }
}
