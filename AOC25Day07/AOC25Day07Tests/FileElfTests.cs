using Day07;

namespace Day07Tests
{
    public class FileElfTests
    {
        [Fact]
        public void TestInput_Has16Rows()
        {
            // Arrange
            string filename = "Day07TestInput.txt";
            FileElf elf = new();

            // Act
            Manifold manifold = elf.GetManifoldFromFile(filename);

            // Assert
            Assert.Equal(16, manifold.Locations().Where(l => l.X == 0).Count());
        }

        [Fact]
        public void TestInput_Has15Cols()
        {
            // Arrange
            string filename = "Day07TestInput.txt";
            FileElf elf = new();

            // Act
            Manifold manifold = elf.GetManifoldFromFile(filename);

            // Assert
            Assert.Equal(15, manifold.Locations().Where(l => l.Y == 0).Count());
        }

        [Fact]
        public void TestInput_HasSInLocation8()
        {
            // Arrange
            string filename = "TestInput.txt";
            FileElf elf = new();

            // Act
            Manifold manifold = elf.GetManifoldFromFile(filename);

            // Assert
            Assert.Equal('S', manifold.GetLocation(7, 0).Value);
        }
    }
}
