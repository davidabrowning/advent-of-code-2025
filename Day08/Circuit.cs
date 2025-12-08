namespace Day08
{
    public class Circuit
    {
        public List<JunctionBox> JunctionBoxes { get; set; } = new ();

        public override string? ToString()
        {
            string output = "";
            foreach (JunctionBox box in JunctionBoxes)
                output += box.ToString();
            return output;
        }
    }
}
