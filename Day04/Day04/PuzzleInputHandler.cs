namespace Day04
{
    public static class PuzzleInputHandler
    {
        public static PrintingDepartmentFloor HandlePuzzleInput(string puzzleInput)
        {
            string[] rows = puzzleInput.Split("\r\n");
            int width = rows[0].Length;
            int height = rows.Length;
            PrintingDepartmentFloor floor = new (width, height);
            int y = 0;
            foreach (string row in rows)
            {
                int x = 0;
                foreach (char c in row)
                {
                    floor.RollDiagram[x, y] = c.ToString();
                    x++;
                }
                y++;
            }
            return floor;
        }
    }
}
