namespace Day06
{
    public class LeftParserElf
    {
        public List<List<int>> ParseIntegers(IEnumerable<IEnumerable<string>> input)
        {
            List<List<int>> result = new();
            for (int rowNum = 0; rowNum < input.Count() - 1; rowNum++)
            {
                IEnumerable<string> row = input.ElementAt(rowNum);
                List<int> rowIntegers = new();
                foreach (string item in row)
                {
                    int integer = Convert.ToInt32(item);
                    rowIntegers.Add(integer);
                }
                result.Add(rowIntegers);
            }
            return result;
        }

        public List<string> ParseOperations(IEnumerable<IEnumerable<string>> input)
        {
            return input.Last().ToList();
        }
    }
}
