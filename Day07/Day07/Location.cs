using System.Numerics;

namespace Day07
{
    public class Location
    {
        public int X;
        public int Y;
        public char Value = '.';
        public BigInteger BeamCount;

        public bool HasBeamStart()
        {
            return Value == 'S';
        }

        public bool HasBeamContinuation()
        {
            return Value == '|';
        }

        public bool HasBeam()
        {
            return HasBeamStart() || HasBeamContinuation();
        }

        public bool HasSplitter()
        {
            return Value == '^';
        }

        public bool IsEmpty()
        {
            return Value == '.';
        }
    }
}
