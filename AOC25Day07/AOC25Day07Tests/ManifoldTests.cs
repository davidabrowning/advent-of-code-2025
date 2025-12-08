using Day07;

namespace AOC25Day07Tests
{
    public class ManifoldTests
    {
        private Manifold _manifold;
        public ManifoldTests()
        {
            string filename = "Day07TestInput.txt";
            FileElf fileElf = new();
            _manifold = fileElf.GetManifoldFromFile(filename);
        }

        [Fact]
        public void Above_ReturnsCorrectLocation()
        {
            // Arrange
            Location location = _manifold.GetLocation(7, 1);

            // Assert
            Assert.Equal('S', _manifold.Above(location).Value);
        }

        [Fact]
        public void Below_ReturnsCorrectLocation()
        {
            // Arrange
            Location location = _manifold.GetLocation(7, 1);

            // Assert
            Assert.Equal('^', _manifold.Below(location).Value);
        }

        [Fact]
        public void Left_ReturnsCorrectLocation()
        {
            // Arrange
            Location location = _manifold.GetLocation(8, 0);

            // Assert
            Assert.Equal('S', _manifold.Left(location).Value);
        }

        [Fact]
        public void Right_ReturnsCorrectLocation()
        {
            // Arrange
            Location location = _manifold.GetLocation(6, 0);

            // Assert
            Assert.Equal('S', _manifold.Right(location).Value);
        }

        [Fact]
        public void TestHeight_IsCorrect()
        {
            // Assert
            Assert.Equal(16, _manifold.Height());
        }

        [Fact]
        public void TestWidth_IsCorrect()
        {
            // Assert
            Assert.Equal(15, _manifold.Width());
        }

        [Fact]
        public void ProcessBeam_AddsFirstBeamCorrectly()
        {
            // Act
            _manifold.ProcessBeam();

            // Assert
            Assert.True(_manifold.GetLocation(7, 1).HasBeam());
        }

        [Fact]
        public void ProcessBeam_AddsBottomLeftBeamCorrectly()
        {
            // Act
            _manifold.ProcessBeam();

            // Assert
            Assert.True(_manifold.GetLocation(0, 15).HasBeam());
        }

        [Fact]
        public void CountSplits_HasCorrectOutput()
        {
            // Arrange
            _manifold.ProcessBeam();

            // Act

            // Assert
            Assert.Equal(21, _manifold.CountSplits());
        }

        [Fact]
        public void CountBeamPathsMathematically_HasCorrectOutput()
        {
            // Arrange
            _manifold.ProcessBeamPathsMathematically();

            // Act

            // Assert
            Assert.Equal(40, _manifold.CountBeamPathsMathematically());
        }
    }
}
