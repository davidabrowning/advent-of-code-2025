namespace Day06.Tests
{
    public class RightFileReaderElfTests
    {
        [Fact]
        public void LastTestColumn_Is4()
        {
            // Arrange
            string filename = "TestInput.txt";
            RightFileReaderElf elf = new();

            // Act
            IEnumerable<string> columns = elf.Read(filename);

            // Assert
            Assert.Equal("4", columns.Last().Trim());
        }

        [Fact]
        public void FirstTestColumn_Is1SpaceSpaceAsterisk()
        {
            // Arrange
            string filename = "TestInput.txt";
            RightFileReaderElf elf = new();

            // Act
            IEnumerable<string> columns = elf.Read(filename);

            // Assert
            Assert.Equal("1  *", columns.First().Trim());
        }
    }
}
