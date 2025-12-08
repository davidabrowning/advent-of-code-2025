using Day04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC25Day04PrintingDeptTests
{
    public class PuzzleInputHandlerTests
    {
        [Fact]
        public void HandlePuzzleInput_Creates3x3Floor_WhenInputIs3x3()
        {
            // Arrange
            string input = """
                @@@
                @@@
                @@@
                """;

            // Act
            PrintingDepartmentFloor printingDepartmentFloor = PuzzleInputHandler.HandlePuzzleInput(input);

            // Assert
            Assert.Equal(3, printingDepartmentFloor.Width);
            Assert.Equal(3, printingDepartmentFloor.Height);
        }

        [Fact]
        public void HandlePuzzleInput_Creates5x2Floor_WhenInputIs5x2()
        {
            // Arrange
            string input = """
                @@@@@
                @@@@@
                """;

            // Act
            PrintingDepartmentFloor printingDepartmentFloor = PuzzleInputHandler.HandlePuzzleInput(input);

            // Assert
            Assert.Equal(5, printingDepartmentFloor.Width);
            Assert.Equal(2, printingDepartmentFloor.Height);
        }
    }
}
