using Day05;

namespace AOC25Day05Tests
{
    public class IngredientIdRangeTests
    {
        [Fact]
        public void Contains_IsFalse_For2IfRangeIs3To5()
        {
            // Arrange
            IngredientIdRange range = new(3, 5);

            // Act
            bool result = range.Contains(2);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Contains_IsTrue_For5IfRangeIs3To5()
        {
            // Arrange
            IngredientIdRange range = new(3, 5);

            // Act
            bool result = range.Contains(5);

            // Assert
            Assert.True(result);
        }
    }
}
