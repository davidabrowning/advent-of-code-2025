using Day05;
using System.Numerics;

namespace Day05Tests
{
    public class FreshnessElfTests
    {
        private const string _testFilename = "Day05TestFile.txt";

        [Fact]
        public void GetFreshIds_Includes5_FromTestFile()
        {
            // Arrange
            FileReaderElf readerElf = new();
            IEnumerable<IngredientIdRange> ranges = readerElf.GetRanges(_testFilename);
            IEnumerable<BigInteger> ids = readerElf.GetIds(_testFilename);
            FreshnessElf counterElf = new();
            BigInteger targetFreshIngredientId = 5;

            // Act
            List<BigInteger> freshIngredients = counterElf.GetFreshIngredients(ranges, ids);

            // Assert
            Assert.Contains(targetFreshIngredientId, freshIngredients);
        }

        [Fact]
        public void GetFreshIds_HasCount3_FromTestFile()
        {
            // Arrange
            FileReaderElf readerElf = new();
            IEnumerable<IngredientIdRange> ranges = readerElf.GetRanges(_testFilename);
            IEnumerable<BigInteger> ids = readerElf.GetIds(_testFilename);
            FreshnessElf counterElf = new();
            BigInteger targetCount = 3;

            // Act
            List<BigInteger> freshIngredients = counterElf.GetFreshIngredients(ranges, ids);

            // Assert
            Assert.Equal(targetCount, freshIngredients.Count());
        }
    }
}
