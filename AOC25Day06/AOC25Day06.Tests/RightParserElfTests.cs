namespace Day06.Tests
{
    public class RightParserElfTests
    {
        private List<string> _columns;

        public RightParserElfTests()
        {
            string filename = "TestInput.txt";
            RightFileReaderElf readerElf = new();
            _columns = readerElf.Read(filename);
        }

        [Fact]
        public void FirstInt_Is4()
        {
            // Arrange
            List<List<int>> integerLists = new();
            List<string> operationList = new();
            RightParserElf parserElf = new();

            // Act
            parserElf.Parse(_columns, integerLists, operationList);

            // Assert
            Assert.Equal(4, integerLists.First().First());
        }

        [Fact]
        public void ThirdInt_Is623()
        {
            // Arrange
            List<List<int>> integerLists = new();
            List<string> operationList = new();
            RightParserElf parserElf = new();

            // Act
            parserElf.Parse(_columns, integerLists, operationList);

            // Assert
            Assert.Equal(623, integerLists.First().ElementAt(2));
        }

        [Fact]
        public void SecondOperator_IsAsterisk()
        {
            // Arrange
            List<List<int>> integerLists = new();
            List<string> operationList = new();
            RightParserElf parserElf = new();

            // Act
            parserElf.Parse(_columns, integerLists, operationList);

            // Assert
            Assert.Equal("*", operationList.ElementAt(1));
        }
    }
}
