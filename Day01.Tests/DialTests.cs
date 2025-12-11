namespace Day01.Tests
{
    public class DialTests
    {
        private Dial _dial;
        private IEnumerable<int> _rotations;

        public DialTests()
        {
            _dial = new();
            string filename = "Day01TestInput.txt";
            _rotations = FileReader.GetRotations(filename);
        }

        [Fact]
        public void Value_StartsAt50()
        {
            // Assert
            Assert.Equal(50, _dial.Value);
        }

        [InlineData(1, 82)]
        [InlineData(2, 52)]
        [InlineData(3, 0)]
        [InlineData(4, 95)]
        [InlineData(5, 55)]
        [InlineData(10, 32)]
        [Theory]
        public void Value_IsCorrectAfterEachRotation(int numRotations, int expectedValue)
        {
            // Act
            for (int i = 0; i < numRotations; i++)
                _dial.Rotate(_rotations.ElementAt(i));

            // Assert
            Assert.Equal(expectedValue, _dial.Value);
        }

        [Fact]
        public void Password_Is3_AfterAllRotations()
        {
            // Arrange
            int expectedPassword = 3;

            // Act
            foreach (int rotation in _rotations)
                _dial.Rotate(rotation);

            // Assert
            Assert.Equal(expectedPassword, _dial.Password);
        }

        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 2)]
        [InlineData(5, 3)]
        [InlineData(6, 4)]
        [InlineData(7, 4)]
        [InlineData(8, 5)]
        [InlineData(9, 5)]
        [InlineData(10, 6)]
        [Theory]
        public void PasswordMethodB_IsCorrect(int numRotations, int expectedValue)
        {
            // Act
            for (int i = 0; i < numRotations; i++)
                _dial.Rotate(_rotations.ElementAt(i));

            // Assert
            Assert.Equal(expectedValue, _dial.PasswordMethodB);
        }
    }
}
