using Day05;
using System.Numerics;

namespace Day05Tests
{
    public class MathElfTests
    {
        [Fact]
        public void Ranges1To4And2To5_BecomeOneRange()
        {
            // Arrange
            MathElf elf = new();
            IngredientIdRange range14 = new(1, 4);
            IngredientIdRange range25 = new(2, 5);
            List<IngredientIdRange> ranges = new();
            ranges.Add(range14);
            ranges.Add(range25);

            // Act
            IEnumerable<IngredientIdRange> result = elf.CombineRanges(ranges);

            // Assert
            Assert.Single(result);
        }

        [Fact]
        public void Ranges1To2And4To5_BecomeTwoRanges()
        {
            // Arrange
            MathElf elf = new();
            IngredientIdRange range12 = new(1, 2);
            IngredientIdRange range45 = new(4, 5);
            List<IngredientIdRange> ranges = new();
            ranges.Add(range12);
            ranges.Add(range45);

            // Act
            IEnumerable<IngredientIdRange> result = elf.CombineRanges(ranges);

            // Assert
            Assert.Equal(2, result.Count());
        }

        [Fact]
        public void Ranges1To4And2To5_Produce5FreshIds()
        {
            // Arrange
            MathElf elf = new();
            IngredientIdRange range14 = new(1, 4);
            IngredientIdRange range25 = new(2, 5);
            List<IngredientIdRange> ranges = new();
            ranges.Add(range14);
            ranges.Add(range25);


            // Act
            BigInteger result = elf.CountFreshIds(ranges);

            // Assert
            Assert.Equal(5, result);
        }
    }
}
