using Day05;
using System.Numerics;

namespace Day05Tests
{
    public class FileReaderElfTests
    {
        private readonly FileReaderElf _elf = new();
        private const string _testFilename = "TestFile.txt";

        [Fact]
        public void TestFile_Contains4IngredientIdRanges()
        {
            // Arrange

            // Act
            IEnumerable<IngredientIdRange> ranges = _elf.GetRanges(_testFilename);

            // Assert
            Assert.Equal(4, ranges.Count());
        }

        [Fact]
        public void TestFile_HasRangeThatIncludesId4()
        {
            // Arrange
            IEnumerable<IngredientIdRange> ranges = _elf.GetRanges(_testFilename);
            BigInteger target = 4;

            // Act
            bool freshId = false;
            foreach (IngredientIdRange range in ranges)
                if (range.Contains(target))
                    freshId = true;

            // Assert
            Assert.True(freshId);
        }

        [Fact]
        public void TestFile_DoesNotHaveRangeThatIncludesId7()
        {
            // Arrange
            IEnumerable<IngredientIdRange> ranges = _elf.GetRanges(_testFilename);
            BigInteger target = 7;

            // Act
            bool freshId = false;
            foreach (IngredientIdRange range in ranges)
                if (range.Contains(target))
                    freshId = true;

            // Assert
            Assert.False(freshId);
        }

        [Fact]
        public void TestFile_IncludesId11()
        {
            // Arrange
            BigInteger target = 11;

            // Act
            IEnumerable<BigInteger> ids = _elf.GetIds(_testFilename);

            // Assert
            Assert.Contains(target, ids);
        }

        [Fact]
        public void TestFile_DoesNotIncludesId12()
        {
            // Arrange
            BigInteger target = 12;

            // Act
            IEnumerable<BigInteger> ids = _elf.GetIds(_testFilename);

            // Assert
            Assert.DoesNotContain(target, ids);
        }
    }
}
