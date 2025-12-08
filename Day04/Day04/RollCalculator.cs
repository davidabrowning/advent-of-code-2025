namespace Day04
{
    public static class RollCalculator
    {
        public static bool HasRoll(PrintingDepartmentFloor floor, int x, int y)
        {
            try
            {
                return floor.RollDiagram[x, y] == "@";
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
        }

        public static int AdjacentRollsCount(PrintingDepartmentFloor floor, int x, int y)
        {
            int adjacentRollsCount = 0;

            // Above
            if (HasRoll(floor, x - 1, y - 1))
                adjacentRollsCount++;
            if (HasRoll(floor, x + 0, y - 1))
                adjacentRollsCount++;
            if (HasRoll(floor, x + 1, y - 1))
                adjacentRollsCount++;

            // Beside
            if (HasRoll(floor, x - 1, y))
                adjacentRollsCount++;
            if (HasRoll(floor, x + 1, y))
                adjacentRollsCount++;

            // Below
            if (HasRoll(floor, x - 1, y + 1))
                adjacentRollsCount++;
            if (HasRoll(floor, x + 0, y + 1))
                adjacentRollsCount++;
            if (HasRoll(floor, x + 1, y + 1))
                adjacentRollsCount++;

            return adjacentRollsCount;
        }

        public static bool IsAccessible(PrintingDepartmentFloor floor, int x, int y)
        {
            return AdjacentRollsCount(floor, x, y) < 4;
        }

        public static bool HasAccessibleRoll(PrintingDepartmentFloor floor, int x, int y)
        {
            return HasRoll(floor, x, y) && IsAccessible(floor, x, y);
        }

        public static int AccessibleRollsCount(PrintingDepartmentFloor floor)
        {
            int accessibleRollCount = 0;
            for (int y = 0; y < floor.Height; y++)
            {
                for (int x = 0; x < floor.Width; x++)
                {
                    if (HasAccessibleRoll(floor, x, y))
                    {
                        accessibleRollCount++;
                    }
                }
            }
            return accessibleRollCount;
        }

        public static bool HasSomeAccessibleRolls(PrintingDepartmentFloor floor)
        {
            for (int y = 0; y < floor.Height; y++)
            {
                for (int x = 0; x < floor.Width; x++)
                {
                    if (HasAccessibleRoll(floor, x, y))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool HasRemovedRoll(PrintingDepartmentFloor floor, int x, int y)
        {
            return floor.RollDiagram[x, y] == "X";
        }

        public static int RemovedRollCount(PrintingDepartmentFloor floor)
        {
            int removedRollCount = 0;
            for (int y = 0; y < floor.Height; y++)
            {
                for (int x = 0; x < floor.Width; x++)
                {
                    if (HasRemovedRoll(floor, x, y))
                    {
                        removedRollCount++;
                    }
                }
            }
            return removedRollCount;
        }
    }
}
