namespace Day03.Tests
{
    public class FileReaderTests
    {
        [Fact]
        public void GetRows_HasCorrectCount()
        {
            // Arrange
            string filename = "Day03TestInput.txt";
            IEnumerable<string> rows;
            int expectedRowCount = 4;

            // Act
            rows = FileReader.GetRows(filename);

            // Assert
            Assert.Equal(expectedRowCount, rows.Count());
        }

        [Fact]
        public void GetRows_HasCorrectValue()
        {
            // Arrange
            string filename = "Day03TestInput.txt";
            IEnumerable<string> rows;
            string expectedLastValue = "818181911112111";

            // Act
            rows = FileReader.GetRows(filename);

            // Assert
            Assert.Equal(expectedLastValue, rows.Last());
        }

        [Fact]
        public void GetBatteryBanks_HasCorrectValue()
        {
            // Arrange
            string filename = "Day03TestInput.txt";
            IEnumerable<BatteryBank> rows;
            string expectedLastValue = "818181911112111";

            // Act
            rows = FileReader.GetBatteryBanks(filename);

            // Assert
            Assert.Equal(expectedLastValue, rows.Last().Batteries);
        }
    }
}
