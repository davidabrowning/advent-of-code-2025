namespace Day04
{
    public static class Day04Runner
    {
        public static void Run()
        {
            string myPuzzleInput = Day04PuzzleInput.MyPuzzleInput;
            PrintingDepartmentFloor floor = PuzzleInputHandler.HandlePuzzleInput(myPuzzleInput);
            int accessibleRollsCount = RollCalculator.AccessibleRollsCount(floor);
            Console.WriteLine($"Accessible rolls on my printing department floor: {accessibleRollsCount}.");
            RollRemover.RemoveAllRolls(floor);
            int removedRollsCount = RollCalculator.RemovedRollCount(floor);
            Console.WriteLine($"Removed rolls on my printing department floor: {removedRollsCount}.");
        }
    }
}
