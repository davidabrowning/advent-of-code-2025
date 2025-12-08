namespace Day04
{
    public static class RollRemover
    {
        public static bool RemoveOneRoll(PrintingDepartmentFloor floor)
        {
            if (!RollCalculator.HasSomeAccessibleRolls(floor))
                return false;
            for (int y = 0; y < floor.Height; y++)
            {
                for (int x = 0; x < floor.Width; x++)
                {
                    if (RollCalculator.HasAccessibleRoll(floor, x, y))
                    {
                        floor.RollDiagram[x, y] = "X";
                        return true;
                    }
                }
            }
            return false;
        }

        public static void RemoveAllRolls(PrintingDepartmentFloor floor)
        {
            bool successfullyRemoveRoll = true;
            while (successfullyRemoveRoll)
            {
                successfullyRemoveRoll = RemoveOneRoll(floor);
                Console.WriteLine($"Remove roll count: {RollCalculator.RemovedRollCount(floor)}");
            }
        }
    }
}
