namespace Day06
{
    public class RightParserElf
    {
        public void Parse(IEnumerable<string> columns, List<List<int>> integerLists, List<string> operators)
        {
            List<int> integerList = new();
            for (int i = columns.Count() - 1; i >= 0; i--)
            {
                string column = columns.ElementAt(i);
                if (column.Trim() == string.Empty)
                    continue;
                string integerAsString = string.Empty;
                if (column.Contains("*"))
                {
                    operators.Add("*");
                    integerAsString = column.Substring(0, column.Length - 1).Trim();
                    int integer = Convert.ToInt32(integerAsString);
                    integerList.Add(integer);
                    integerLists.Add(integerList.ToList());
                    integerList = new();
                }
                else if (column.Contains("+"))
                {
                    operators.Add("+");
                    integerAsString = column.Substring(0, column.Length - 1).Trim();
                    int integer = Convert.ToInt32(integerAsString);
                    integerList.Add(integer);
                    integerLists.Add(integerList.ToList());
                    integerList = new();
                }
                else
                {
                    integerAsString = column.Trim();
                    int integer = Convert.ToInt32(integerAsString);
                    integerList.Add(integer);
                }

            }
        }
    }
}
