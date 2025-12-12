namespace Day02.Tests
{
    public class FileReaderTests
    {
        [InlineData(0, 11, 22)]
        [InlineData(1, 95, 115)]
        [InlineData(2, 998, 1012)]
        [InlineData(10, 2121212118, 2121212124)]
        [Theory]
        public void GetIdRanges_ReturnsCorrectValues(int elementNum, int expectedFirstId, int expectedLastId)
        {
            // Arrange
            string filename = "Day02TestInput.txt";
            IdRange expectedIdRange = new(expectedFirstId, expectedLastId);
            IEnumerable<IdRange> idRanges;

            // Act
            idRanges = FileReader.GetIdRanges(filename);

            // Assert
            Assert.Equal(expectedIdRange, idRanges.ElementAt(elementNum));
        }
    }
}
