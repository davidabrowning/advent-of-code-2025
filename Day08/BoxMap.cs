namespace Day08
{
    public class BoxMap
    {
        public List<JunctionBox> JunctionBoxes { get; set; } = new();
        public List<BoxDistance> BoxDistances { get; set; } = new();
        public List<Circuit> Circuits { get; set; } = new();
        public List<JunctionBox> LatestConnection {  get; } = new();

        public void Add(IEnumerable<JunctionBox> boxes)
        {
            foreach (JunctionBox box in boxes)
                Add(box);
        }

        public void Add(JunctionBox box)
        {
            Circuit circuit = new();
            circuit.JunctionBoxes.Add(box);
            Circuits.Add(circuit);

            foreach (JunctionBox otherBox in JunctionBoxes)
                BoxDistances.Add(new BoxDistance(box, otherBox));

            JunctionBoxes.Add(box);
        }

        public BoxDistance GetShortestUnconnectedDistance()
        {
            return BoxDistances.Where(bd => !bd.IsConnected).OrderBy(bd => bd.Distance).First();
        }

        public void ConnectShortestUnconnected()
        {
            // Update connection status
            BoxDistance shortestDistance = GetShortestUnconnectedDistance();
            shortestDistance.IsConnected = true;

            // Update circuits
            JunctionBox boxA = shortestDistance.JunctionBoxPair.ElementAt(0);
            JunctionBox boxB = shortestDistance.JunctionBoxPair.ElementAt(1);
            Circuit circuitA = Circuits.Where(c => c.JunctionBoxes.Contains(boxA)).First();
            Circuit circuitB = Circuits.Where(c => c.JunctionBoxes.Contains(boxB)).First();

            // Update latest connection tracker
            LatestConnection.Clear();
            LatestConnection.Add(boxA);
            LatestConnection.Add(boxB);

            // If they are in the same circuit already, no circuit changes
            if (Circuits.Where(c => c.JunctionBoxes.Contains(boxA) && c.JunctionBoxes.Contains(boxB)).Any())
                return;

            // Otherwise, combine into one circuit
            foreach (JunctionBox box in circuitB.JunctionBoxes.ToList())
            {
                circuitA.JunctionBoxes.Add(box);
            }
            Circuits.Remove(circuitB);
            Console.WriteLine("Circuit count: " + Circuits.Count);
        }

        public List<Circuit> OrderedCircuits()
        {
            return Circuits.OrderByDescending(c => c.JunctionBoxes.Count).ToList();
        }
    }
}
