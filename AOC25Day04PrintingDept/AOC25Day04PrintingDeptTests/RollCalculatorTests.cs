using Day04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC25Day04PrintingDeptTests
{
    public class RollCalculatorTests
    {
        [Fact]
        public void HasRoll_IsTrue_ForLocationWithRoll()
        {
            // Arrange
            string puzzleInput = """
                ....@
                .....
                """;
            PrintingDepartmentFloor floor = PuzzleInputHandler.HandlePuzzleInput(puzzleInput);

            // Act
            bool hasRoll = RollCalculator.HasRoll(floor, 4, 0);

            // Assert
            Assert.True(hasRoll);
        }

        [Fact]
        public void HasRoll_IsFalse_ForLocationWithoutRoll()
        {
            // Arrange
            string puzzleInput = """
                ....@
                .....
                """;
            PrintingDepartmentFloor floor = PuzzleInputHandler.HandlePuzzleInput(puzzleInput);

            // Act
            bool hasRoll = RollCalculator.HasRoll(floor, 3, 0);

            // Assert
            Assert.False(hasRoll);
        }

        [Fact]
        public void HasRoll_IsFalse_IfXIsNegative()
        {
            // Arrange
            string puzzleInput = """
                ....@
                .....
                """;
            PrintingDepartmentFloor floor = PuzzleInputHandler.HandlePuzzleInput(puzzleInput);

            // Act
            bool hasRoll = RollCalculator.HasRoll(floor, -1, 0);

            // Assert
            Assert.False(hasRoll);
        }

        [Fact]
        public void HasRoll_IsFalse_IfXIsTooHigh()
        {
            // Arrange
            string puzzleInput = """
                ....@
                .....
                """;
            PrintingDepartmentFloor floor = PuzzleInputHandler.HandlePuzzleInput(puzzleInput);

            // Act
            bool hasRoll = RollCalculator.HasRoll(floor, 5, 0);

            // Assert
            Assert.False(hasRoll);
        }

        [Fact]
        public void AdjacentRollsCount_Returns3_When3AdjacentRolls()
        {
            // Arrange
            string puzzleInput = """
                ...@@
                ...@@
                """;
            PrintingDepartmentFloor floor = PuzzleInputHandler.HandlePuzzleInput(puzzleInput);

            // Act
            int adjacentRollsCount = RollCalculator.AdjacentRollsCount(floor, 4, 0);

            // Assert
            Assert.Equal(3, adjacentRollsCount);
        }

        [Fact]
        public void AdjacentRollsCount_Returns8_When8AdjacentRolls()
        {
            // Arrange
            string puzzleInput = """
                @@@
                @@@
                @@@
                """;
            PrintingDepartmentFloor floor = PuzzleInputHandler.HandlePuzzleInput(puzzleInput);

            // Act
            int adjacentRollsCount = RollCalculator.AdjacentRollsCount(floor, 1, 1);

            // Assert
            Assert.Equal(8, adjacentRollsCount);
        }

        [Fact]
        public void IsAccessible_ReturnsTrue_When3AdjacentRolls()
        {
            // Arrange
            string puzzleInput = """
                ...@@
                ...@@
                """;
            PrintingDepartmentFloor floor = PuzzleInputHandler.HandlePuzzleInput(puzzleInput);

            // Act
            bool isAccessible = RollCalculator.IsAccessible(floor, 4, 0);

            // Assert
            Assert.True(isAccessible);
        }

        [Fact]
        public void IsAccessible_ReturnsFalse_When4AdjacentRolls()
        {
            // Arrange
            string puzzleInput = """
                ..@@@
                ...@@
                """;
            PrintingDepartmentFloor floor = PuzzleInputHandler.HandlePuzzleInput(puzzleInput);

            // Act
            bool isAccessible = RollCalculator.IsAccessible(floor, 3, 0);

            // Assert
            Assert.False(isAccessible);
        }

        [Fact]
        public void AccessibleRollsCount_Returns4_When4AccessibleRolls()
        {
            // Arrange
            string puzzleInput = """
                @...@
                @..@.
                """;
            PrintingDepartmentFloor floor = PuzzleInputHandler.HandlePuzzleInput(puzzleInput);

            // Act
            int accessibleRollsCount = RollCalculator.AccessibleRollsCount(floor);

            // Assert
            Assert.Equal(4, accessibleRollsCount);
        }

        [Fact]
        public void ExamplePuzzleInput_Returns13()
        {
            // Arrange
            string puzzleInput = """
                ..@@.@@@@.
                @@@.@.@.@@
                @@@@@.@.@@
                @.@@@@..@.
                @@.@@@@.@@
                .@@@@@@@.@
                .@.@.@.@@@
                @.@@@.@@@@
                .@@@@@@@@.
                @.@.@@@.@.
                """;
            PrintingDepartmentFloor floor = PuzzleInputHandler.HandlePuzzleInput(puzzleInput);

            // Act
            int accessibleRollsCount = RollCalculator.AccessibleRollsCount(floor);

            // Assert
            Assert.Equal(13, accessibleRollsCount);
        }
    }
}
