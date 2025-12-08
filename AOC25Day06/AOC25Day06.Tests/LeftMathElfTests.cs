using System.Numerics;

namespace Day06.Tests
{
    public class LeftMathElfTests
    {
        private IEnumerable<IEnumerable<int>> _integers;
        private IEnumerable<string> _operations;

        public LeftMathElfTests()
        {
            LeftFileReaderElf fileReaderElf = new();
            string filename = "Day06TestInput.txt";
            IEnumerable<IEnumerable<string>> fileContents = fileReaderElf.Read(filename);
            LeftParserElf parserElf = new();
            _integers = parserElf.ParseIntegers(fileContents);
            _operations = parserElf.ParseOperations(fileContents);
        }

        [Fact]
        public void TestInputTotal_Is4277556()
        {
            // Arrange
            LeftMathElf mathElf = new();

            // Act
            BigInteger result = mathElf.Calculate(_integers, _operations);

            // Assert
            Assert.Equal(4277556, result);
        }
    }
}
