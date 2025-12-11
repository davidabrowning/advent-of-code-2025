namespace Day09.Tests
{
    public class FileReaderTests
    {

        [InlineData(0, 7, 1)]
        [InlineData(1, 11, 1)]
        [InlineData(2, 11, 7)]
        [Theory]
        public void GetRedTiles_GetsCorrectTileValues(int elementNum, int expectedX, int expectedY)
        {
            // Arrange
            string filename = "Day09TestInput.txt";
            FileReader fileReader = new();
            Tile expectedRedTile = new(expectedX, expectedY);
            List<Tile> redTiles;

            // Act
            redTiles = fileReader.GetRedTiles(filename);

            // Assert
            Assert.Equal(expectedRedTile, redTiles.ElementAt(elementNum));
        }
    }
}
