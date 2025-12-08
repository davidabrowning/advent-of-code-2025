using System.Text;

namespace Day07
{
    public class BeamPath
    {
        public List<Location> _locations = new();
        public string StringRepresentation { get { return ToString();  } }

        public void Add(Location location)
        {
            _locations.Add(location);
        }

        public void Add(IEnumerable<Location> locations)
        {
            foreach (Location location in locations)
                _locations.Add(location);
        }

        public List<Location> GetLocations()
        {
            return _locations.ToList();
        }

        public bool Contains(Location location)
        {
            return _locations.Where(l => l.X == location.X && l.Y == location.Y).Any();
        }

        public bool ContainsYValue(int yValue)
        {
            return _locations.Where(l => l.Y == yValue).Any();
        }

        public override string ToString()
        {
            string output = "";
            foreach(Location location in _locations)
            {
                output += $"({location.X}, {location.Y}) ";
            }
            return output;
        }
    }
}
