namespace Day09
{
    public class Tile
    {
        public int X { get; }
        public int Y { get; }

        public Tile(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Tile))
                return false;
            Tile otherTile = (Tile)obj;
            if (otherTile.X != X)
                return false;
            if (otherTile.Y != Y) 
                return false;
            return true;
        }
    }
}
