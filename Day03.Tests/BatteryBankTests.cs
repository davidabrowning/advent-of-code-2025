using System.Numerics;

namespace Day03.Tests
{
    public class BatteryBankTests
    {
        [InlineData("987654321111111", 2, 98)]
        [InlineData("811111111111119", 2, 89)]
        [InlineData("234234234234278", 2, 78)]
        [InlineData("818181911112111", 2, 92)]
        [InlineData("987654321111111", 12, 987654321111)]
        [InlineData("811111111111119", 12, 811111111119)]
        [InlineData("234234234234278", 12, 434234234278)]
        [InlineData("818181911112111", 12, 888911112111)]
        [Theory]
        public void MaxJoltage_ReturnsExpectedResult(string batteryBankString, int numBatteries, BigInteger expectedJoltage)
        {
            // Arrange
            BatteryBank batteryBank = new() { Batteries = batteryBankString };
            BigInteger actualJoltage;

            // Act
            actualJoltage = batteryBank.MaxJoltage(numBatteries);

            // Assert
            Assert.Equal(expectedJoltage, actualJoltage);
        }
    }
}
