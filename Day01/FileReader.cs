namespace Day01
{
    public static class FileReader
    {
        public static IEnumerable<string> GetRows(string filename)
        {
            return File.ReadAllLines(filename);
        }

        public static IEnumerable<int> GetRotations(string filename)
        {
            List<int> rotations = new();
            IEnumerable<string> rows = GetRows(filename);
            foreach (string row in rows)
            {
                int rotationValue = Convert.ToInt32(row.Substring(1));
                if (row.First() == 'L')
                    rotationValue *= -1;
                rotations.Add(rotationValue);
            }
            return rotations;
        }
    }
}
