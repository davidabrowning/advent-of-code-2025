using System.Numerics;

namespace Day06
{
    public static class Day06Runner
    {
        public static void Run()
        {
            string filename = "Day06PuzzleInput.txt";

            // Part 1
            LeftFileReaderElf leftFileReaderElf = new();
            IEnumerable<IEnumerable<string>> fileContents = leftFileReaderElf.Read(filename);
            LeftParserElf leftParserElf = new();
            IEnumerable<IEnumerable<int>> integers = leftParserElf.ParseIntegers(fileContents);
            IEnumerable<string> operations = leftParserElf.ParseOperations(fileContents);
            LeftMathElf leftMathElf = new();
            BigInteger leftTotal = leftMathElf.Calculate(integers, operations);
            Console.WriteLine("Homework total read from left is: " + leftTotal);

            // Part 2
            RightFileReaderElf rightFileReaderElf = new();
            IEnumerable<string> columns = rightFileReaderElf.Read(filename);
            List<List<int>> integerLists = new();
            List<string> operationList = new();
            RightParserElf rightParserElf = new();
            rightParserElf.Parse(columns, integerLists, operationList);
            RightMathElf rightMathElf = new();
            BigInteger rightTotal = rightMathElf.Calculate(integerLists, operationList);
            Console.WriteLine("Homework total read from right is: " + rightTotal);
        }
    }
}
