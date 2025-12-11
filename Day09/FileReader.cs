
namespace Day09
{
    public class FileReader
    {
        public List<Tile> GetRedTiles(string filename)
        {
            List<Tile> redTiles = new();
            foreach (string row in File.ReadAllLines(filename))
            {
                string[] rowParts = row.Split(",");
                int x = Convert.ToInt32(rowParts[0]);
                int y = Convert.ToInt32(rowParts[1]);
                Tile redTile = new(x, y);
                redTiles.Add(redTile);
            }
            return redTiles;
        }
    }
}
