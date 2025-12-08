using System.Numerics;

namespace Day08
{
    public class BoxDistance
    {
        public List<JunctionBox> JunctionBoxPair { get; }
        public BigInteger Distance { get; }
        public bool IsConnected { get; set; }
        public BoxDistance(JunctionBox boxA, JunctionBox boxB)
        {
            JunctionBoxPair = new() { boxA, boxB };
            Distance = GetDistance(boxA, boxB);
        }

        public BigInteger GetDistance(JunctionBox boxA, JunctionBox boxB)
        {
            BigInteger xDiff = boxA.X - boxB.X;
            BigInteger yDiff = boxA.Y - boxB.Y;
            BigInteger zDiff = boxA.Z - boxB.Z;
            return (BigInteger)Math.Sqrt((double)(xDiff * xDiff + yDiff * yDiff + zDiff * zDiff));
        }

        public override string? ToString()
        {
            string output = "";
            foreach (JunctionBox box in JunctionBoxPair)
            {
                output += box.ToString();
            }
            output += " - " + Distance;
            return output;
        }
    }
}
