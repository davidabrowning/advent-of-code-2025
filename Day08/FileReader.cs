

namespace Day08
{
    public class FileReader
    {
        public IEnumerable<JunctionBox> GetJunctionBoxes(string filename)
        {
            List<JunctionBox> junctionBoxes = new();
            foreach (string row in GetRows(filename))
            {
                string[] coords = row.Split(",");
                int x = Convert.ToInt32(coords[0]);
                int y = Convert.ToInt32(coords[1]);
                int z = Convert.ToInt32(coords[2]);
                JunctionBox junctionBox = new(x, y, z);
                junctionBoxes.Add(junctionBox);
            }
            return junctionBoxes;
        }

        public IEnumerable<string> GetRows(string filename)
        {
            return File.ReadLines(filename);
        }
    }
}
