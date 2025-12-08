namespace Day06.Tests
{
    public class LeftFileReaderElfTests
    {
        [Fact]
        public void TestInput_ContainsFourRows()
        {
            // Arrange
            string filename = "Day06TestInput.txt";
            LeftFileReaderElf elf = new();

            // Act
            IEnumerable<IEnumerable<string>> result = elf.Read(filename);

            // Assert
            Assert.Equal(4, result.Count());
        }

        [Fact]
        public void TestInput_ContainsFourColumns()
        {
            // Arrange
            string filename = "Day06TestInput.txt";
            LeftFileReaderElf elf = new();

            // Act
            IEnumerable<IEnumerable<string>> result = elf.Read(filename);

            // Assert
            Assert.Equal(4, result.ElementAt(2).Count());
        }
    }
}
