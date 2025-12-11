using System.Numerics;

namespace Day09.Tests
{
    public class TheaterMathTests
    {
        IEnumerable<Tile> _redTiles;
        IEnumerable<Tile> _blackTiles;

        public TheaterMathTests()
        {
            string filename = "Day09TestInput.txt";
            FileReader fileReader = new();
            _redTiles = fileReader.GetRedTiles(filename);
        }

        [InlineData(24, 2, 5, 9, 7)]
        [InlineData(35, 7, 1, 11, 7)]
        [InlineData(6, 7, 3, 2, 3)]
        [Theory]
        public void CalculateArea_ReturnsExpectedResult(BigInteger expectedArea, int x1, int y1, int x2, int y2)
        {
            // Arrange
            Tile tileA = new(x1, y1);
            Tile tileB = new(x2, y2);
            BigInteger actualArea;

            // Act
            actualArea = TheaterMath.CalculateArea(tileA, tileB);

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void MaxArea_Is50()
        {
            // Arrange

            // Act
            BigInteger maxArea = TheaterMath.MaxArea(_redTiles);

            // Assert
            Assert.Equal(50, maxArea);
        }

        [Fact]
        public void ContainsAdjacentDiagonals_IsTrue_WhenRectangleContainsAllFourAdjacentDiagonals()
        {
            // Arrange
            Tile rectangleVertex1 = new Tile(0, 0);
            Tile rectangleVertext2 = new Tile(3, 3);
            Tile targetTile = new(1, 1);

            // Act
            bool containsAdjacentDiagonals = TheaterMath.ContainsAdjacentDiagonals(rectangleVertex1, rectangleVertext2, targetTile);

            // Assert
            Assert.True(containsAdjacentDiagonals);
        }

        [Fact]
        public void ContainsAdjacentDiagonals_IsFalse_WhenRectangleDoesNotContainAllFourAdjacentDiagonals()
        {
            // Arrange
            Tile rectangleVertex1 = new Tile(0, 0);
            Tile rectangleVertext2 = new Tile(3, 3);
            Tile targetTile = new(0, 1);

            // Act
            bool containsAdjacentDiagonals = TheaterMath.ContainsAdjacentDiagonals(rectangleVertex1, rectangleVertext2, targetTile);

            // Assert
            Assert.False(containsAdjacentDiagonals);
        }

        [Fact]
        public void MaxAreaRedGreenOnly_Is24()
        {
            // Arrange

            // Act
            BigInteger maxArea = TheaterMath.MaxAreaRedGreenOnly(_redTiles);

            // Assert
            Assert.Equal(24, maxArea);
        }
    }
}
