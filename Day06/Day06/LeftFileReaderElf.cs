namespace Day06
{
    public class LeftFileReaderElf
    {
        public List<List<string>> Read(string filename)
        {
            string fileText = File.ReadAllText(filename);
            List<List<string>> results = new();
            foreach (string line in fileText.Split("\r\n"))
            {
                List<string> rowContents = new();
                foreach (string item in line.Split(" "))
                {
                    if (item == "")
                        continue;
                    rowContents.Add(item);
                }
                results.Add(rowContents);
            }
            return results;
        }
    }
}
