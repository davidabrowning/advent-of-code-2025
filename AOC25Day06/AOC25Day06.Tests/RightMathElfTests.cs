using System.Numerics;

namespace Day06.Tests
{
    public class RightMathElfTests
    {
        [Fact]
        public void TestTotal_Is3263827()
        {
            // Arrange
            string filename = "TestInput.txt";
            RightFileReaderElf readerElf = new();
            IEnumerable<string> columns = readerElf.Read(filename);
            List<List<int>> integerLists = new();
            List<string> operationList = new();
            RightParserElf parserElf = new();
            parserElf.Parse(columns, integerLists, operationList);
            RightMathElf mathElf = new();

            // Act
            BigInteger total = mathElf.Calculate(integerLists, operationList);

            // Assert
            Assert.Equal(3263827, total);
        }
    }
}
