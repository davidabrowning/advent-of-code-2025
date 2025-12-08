using System.Text;

namespace Day06
{
    public class RightFileReaderElf
    {
        public List<string> Read(string filename)
        {
            List<string> columns = new();
            string[] fileRows = File.ReadAllLines(filename);
            int numRows = fileRows.Length;
            int numCols = fileRows[0].Length;
            for (int colNum = 0; colNum < numCols; colNum++)
            {
                StringBuilder columnStringBuilder = new();
                for(int rowNum = 0; rowNum < numRows; rowNum++)
                {
                    char letter = fileRows[rowNum][colNum];
                    columnStringBuilder.Append(letter);
                }
                columns.Add(columnStringBuilder.ToString());
            }
            return columns;
        }
    }
}
