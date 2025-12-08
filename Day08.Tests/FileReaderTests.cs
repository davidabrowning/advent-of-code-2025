namespace Day08.Tests
{
    public class FileReaderTests
    {
        string _filename = "Day08TestInput.txt";
        FileReader _fileReader = new();

        [InlineData(0, "162,817,812")]
        [InlineData(3, "592,479,940")]
        [InlineData(4, "352,342,300")]
        [Theory]
        public void GetRows_ReturnsCorrectRowStrings(int rowNum, string expectedOutput)
        {
            // Arrange

            // Act
            IEnumerable<string> rows = _fileReader.GetRows(_filename);

            // Assert
            Assert.Equal(expectedOutput, rows.ElementAt(rowNum));
        }

        [InlineData(0, 162, 817, 812)]
        [InlineData(5, 466, 668, 158)]
        [Theory]
        public void GetJunctionBoxes_ReturnsCorrectJunctionBoxes(int junctionBoxNum, int expectedX, int expectedY, int expectedZ)
        {
            // Arrange
            JunctionBox expectedJunctionBox = new JunctionBox(expectedX, expectedY, expectedZ);

            // Act
            IEnumerable<JunctionBox> junctionBoxes = _fileReader.GetJunctionBoxes(_filename);

            // Assert
            Assert.Equal(expectedJunctionBox, junctionBoxes.ElementAt(junctionBoxNum));
        }
    }
}
