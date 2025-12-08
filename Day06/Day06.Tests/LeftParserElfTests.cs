namespace Day06.Tests
{
    public class LeftParserElfTests
    {
        private readonly IEnumerable<IEnumerable<string>> _fileContents;
        public LeftParserElfTests()
        {
            LeftFileReaderElf fileReaderElf = new();
            string filename = "Day06TestInput.txt";
            _fileContents = fileReaderElf.Read(filename);
        }

        [Fact]
        public void FirstIntInTestFile_Equals123()
        {
            // Arrange
            LeftParserElf parserElf = new();

            // Act
            IEnumerable<IEnumerable<int>> integers = parserElf.ParseIntegers(_fileContents);

            // Assert
            Assert.Equal(123, integers.ElementAt(0).ElementAt(0));
        }

        [Fact]
        public void LastntInTestFile_Equals314()
        {
            // Arrange
            LeftParserElf parserElf = new();

            // Act
            IEnumerable<IEnumerable<int>> integers = parserElf.ParseIntegers(_fileContents);

            // Assert
            Assert.Equal(314, integers.ElementAt(2).ElementAt(3));
        }

        [Fact]
        public void FirstOperatorInTestFile_IsAsterisk()
        {
            // Arrange
            LeftParserElf parserElf = new();

            // Act
            IEnumerable<string> operations = parserElf.ParseOperations(_fileContents);

            // Assert
            Assert.Equal("*", operations.First());
        }

        [Fact]
        public void LastOperatorInTestFile_IsPlus()
        {
            // Arrange
            LeftParserElf parserElf = new();

            // Act
            IEnumerable<string> operations = parserElf.ParseOperations(_fileContents);

            // Assert
            Assert.Equal("+", operations.Last());
        }
    }
}
