using System.Numerics;

namespace Day02.Tests
{
    public class IdMathTests
    {
        [InlineData(123)]
        [InlineData(1)]
        [InlineData(9888123)]
        [Theory]
        public void IsValid_IsTrue_ForValidIds(int validId)
        {
            // Arrange
            bool isValid;

            // Act
            isValid = IdMath.IsValid(validId);

            // Assert
            Assert.True(isValid);
        }

        [InlineData(6464)]
        [InlineData(123123)]
        [InlineData(22)]
        [Theory]
        public void IsValid_IsFalse_ForInvalidIds(int invalidId)
        {
            // Arrange
            bool isValid;

            // Act
            isValid = IdMath.IsValid(invalidId);

            // Assert
            Assert.False(isValid);
        }

        [InlineData(11, 22, 2)]
        [InlineData(1698522, 1698528, 0)]
        [InlineData(38593856, 38593862, 1)]
        [Theory]
        public void GetInvalidIdsInRange_ReturnsExpectedCounts(int rangeStart, int rangeEnd, int expectedCount)
        {
            // Arrange
            IEnumerable<BigInteger> invalidIds;
            IdRange idRange = new(rangeStart, rangeEnd);

            // Act
            invalidIds = IdMath.GetInvalidIdsInRange(idRange);

            // Assert
            Assert.Equal(expectedCount, invalidIds.Count());
        }

        [Fact]
        public void SumInvalidIds_ReturnsExpectedResult()
        {
            // Arrange
            IEnumerable<IdRange> idRanges = FileReader.GetIdRanges("Day02TestInput.txt");
            BigInteger expectedSum = 1227775554;
            BigInteger actualSum;

            // Act
            actualSum = IdMath.SumInvalidIds(idRanges);

            // Assert
            Assert.Equal(expectedSum, actualSum);
        }

        [InlineData(123)]
        [InlineData(18)]
        [InlineData(9888123)]
        [Theory]
        public void IsValidAdvanced_IsTrue_ForValidIds(int validId)
        {
            // Arrange
            bool isValid;

            // Act
            isValid = IdMath.IsValidAdvanced(validId);

            // Assert
            Assert.True(isValid);
        }

        [InlineData(11)]
        [InlineData(1188511885)]
        [InlineData(999)]
        [Theory]
        public void IsValidAdvanced_IsFalse_ForInvalidIds(int invalidId)
        {
            // Arrange
            bool isValid;

            // Act
            isValid = IdMath.IsValidAdvanced(invalidId);

            // Assert
            Assert.False(isValid);
        }

        [Fact]
        public void SumInvalidIdsAdvanced_ReturnsExpectedResult()
        {
            // Arrange
            IEnumerable<IdRange> idRanges = FileReader.GetIdRanges("Day02TestInput.txt");
            BigInteger expectedSum = 4174379265;
            BigInteger actualSum;

            // Act
            actualSum = IdMath.SumInvalidIdsAdvanced(idRanges);

            // Assert
            Assert.Equal(expectedSum, actualSum);
        }
    }
}
