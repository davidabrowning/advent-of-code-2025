namespace Day01
{
    public static class Day01Runner
    {
        public static void Run()
        {
            // Part 1
            string filename = "Day01PuzzleInput.txt";
            IEnumerable<int> rotations = FileReader.GetRotations(filename);
            Dial dial = new();
            foreach (int rotation in rotations)
                dial.Rotate(rotation);
            Console.WriteLine("Password: " + dial.Password);

            // Part 2
            Console.WriteLine("PasswordMethodB: " + dial.PasswordMethodB);
        }
    }
}
