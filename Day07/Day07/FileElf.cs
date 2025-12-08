namespace Day07
{
    public class FileElf
    {
        public Manifold GetManifoldFromFile(string filename)
        {
            Manifold manifold = new();
            List<string> rows = File.ReadLines(filename).ToList();
            for (int y = 0; y < rows.Count(); y++)
            {
                for (int x = 0; x < rows[y].Length; x++)
                {
                    manifold.Add(new Location() { 
                        X = x,
                        Y = y,
                        Value = rows[y][x]
                    });
                }
            }
            return manifold;
        }
    }
}
