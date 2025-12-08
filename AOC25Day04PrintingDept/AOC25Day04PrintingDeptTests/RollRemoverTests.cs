using Day04;

namespace AOC25Day04PrintingDeptTests
{
    public class RollRemoverTests
    {
        [Fact]
        public void RollsRemoved_StartsAt0()
        {
            // Arrange
            string puzzleInput = """
                ..@@@
                .....
                """;
            PrintingDepartmentFloor floor = PuzzleInputHandler.HandlePuzzleInput(puzzleInput);

            // Act
            int rollsRemoved = RollCalculator.RemovedRollCount(floor);

            // Assert
            Assert.Equal(0, rollsRemoved);
        }

        [Fact]
        public void RemoveOneRoll_ReducesAccessibleRollsByOne()
        {
            // Arrange
            string puzzleInput = """
                ..@@@
                .....
                """;
            PrintingDepartmentFloor floor = PuzzleInputHandler.HandlePuzzleInput(puzzleInput);
            int initialAccessibleRolls = RollCalculator.AccessibleRollsCount(floor);

            // Act
            RollRemover.RemoveOneRoll(floor);
            int finalAccessibleRolls = RollCalculator.AccessibleRollsCount(floor);

            // Assert
            Assert.Equal(initialAccessibleRolls - 1, finalAccessibleRolls);
        }

        [Fact]
        public void RollsRemovedCount_Is4_AfterRemovingFourRolls()
        {
            // Arrange
            string puzzleInput = """
                ..@@@
                @....
                """;
            PrintingDepartmentFloor floor = PuzzleInputHandler.HandlePuzzleInput(puzzleInput);
            int initialAccessibleRolls = RollCalculator.AccessibleRollsCount(floor);

            // Act
            RollRemover.RemoveAllRolls(floor);
            int removedRolls = RollCalculator.RemovedRollCount(floor);

            // Assert
            Assert.Equal(4, removedRolls);
        }
    }
}
