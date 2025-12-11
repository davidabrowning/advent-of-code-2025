namespace Day01.Tests
{
    public class FileReaderTests
    {
        private string _filename = "Day01TestInput.txt";

        [Fact]
        public void GetRows_Contains10Rows()
        {
            // Arrange
            int expectedRows = 10;
            int actualRows;

            // Act
            IEnumerable<string> rows = FileReader.GetRows(_filename);
            actualRows = rows.Count();

            // Assert
            Assert.Equal(expectedRows, actualRows);
        }

        [InlineData(0, -68)]
        [InlineData(1, -30)]
        [InlineData(2, 48)]
        [Theory]
        public void GetRotations_HasExpectedValues(int index, int expectedValue)
        {
            // Arrange

            // Act
            IEnumerable<int> rotations = FileReader.GetRotations(_filename);

            // Assert
            Assert.Equal(expectedValue, rotations.ElementAt(index));
        }
    }
}
