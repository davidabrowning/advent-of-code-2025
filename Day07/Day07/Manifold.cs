using System.Numerics;
using System.Text;

namespace Day07
{
    public class Manifold
    {
        private List<Location> _locations = new();
        private List<BeamPath> _beamPaths = new();

        public int Width()
        {
            return _locations.Max(l => l.X + 1);
        }

        public int Height()
        {
            return _locations.Max(l => l.Y + 1);
        }

        public void Add(Location location)
        {
            _locations.Add(location);
        }

        public IEnumerable<Location> Locations()
        {
            return _locations.ToList();
        }

        public Location GetLocation(int x, int y)
        {
            return _locations
                .Where(l => l.X == x && l.Y == y)
                .FirstOrDefault() ?? new Location();
        }

        public Location Above(Location location)
        {
            return GetLocation(location.X, location.Y - 1);
        }

        public Location Below(Location location)
        {
            return GetLocation(location.X, location.Y + 1);
        }

        public Location Left(Location location)
        {
            return GetLocation(location.X - 1, location.Y);
        }

        public Location Right(Location location)
        {
            return GetLocation(location.X + 1, location.Y);
        }

        public void ProcessBeam()
        {
            for (int y = 0; y < Height(); y++)
            {
                for (int x = 0; x < Width(); x++)
                {
                    Location location = GetLocation(x, y);

                    if (!location.IsEmpty())
                        continue;

                    if (Above(location).HasBeam())
                        location.Value = '|';

                    if (Left(location).HasSplitter() && Above(Left(location)).HasBeam())
                        location.Value = '|';

                    if (Right(location).HasSplitter() && Above(Right(location)).HasBeam())
                        location.Value = '|';
                }
            }
        }

        public int CountSplits()
        {
            int splitCount = 0;
            foreach (Location location in _locations)
            {
                if (location.HasSplitter() && Above(location).HasBeam())
                    splitCount++;
            }
            return splitCount;
        }

        public void ProcessBeamPathsMathematically()
        {
            for (int y = 0; y < Height(); y++)
            {
                for (int x = 0; x < Width(); x++)
                {
                    Location location = GetLocation(x, y);

                    if (!location.IsEmpty())
                        continue;

                    if (Above(location).HasBeamStart())
                    {
                        location.BeamCount = 1;
                    }

                    location.BeamCount += Above(location).BeamCount;

                    if (Right(location).HasSplitter())
                        location.BeamCount += Above(Right(location)).BeamCount;

                    if (Left(location).HasSplitter())
                        location.BeamCount += Above(Left(location)).BeamCount;
                }
            }
        }

        public BigInteger CountBeamPathsMathematically()
        {
            BigInteger beamPaths = 0;
            int y = Height() - 1;
            for (int x = 0; x < Width(); x++)
            {
                beamPaths += GetLocation(x, y).BeamCount;
            }
            return beamPaths;
        }
    }
}
