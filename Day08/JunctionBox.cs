namespace Day08
{
    public class JunctionBox
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }
        public JunctionBox? ClosestJunctionBox { get; set; }

        public JunctionBox(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string? ToString()
        {
            return $"({X}, {Y}, {Z})";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != typeof(JunctionBox)) 
                return false;
            JunctionBox otherJunctionBox = (JunctionBox)obj;
            return otherJunctionBox.X == X && otherJunctionBox.Y == Y && otherJunctionBox.Z == Z;
        }
    }
}
