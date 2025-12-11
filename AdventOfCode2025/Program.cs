using Day01;
using Day04;
using Day05;
using Day06;
using Day07;
using Day08;
using Day09;

namespace AdventOfCode2025
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrintGreeting();
            RunSelectedDay();
            PrintGoodbye();
        }

        private static void PrintGreeting()
        {
            Console.WriteLine("Welcome to Advent of Code 2025!");
        }

        private static void RunSelectedDay()
        {
            bool userWantsToContinue = true;
            while (userWantsToContinue)
            {
                Console.WriteLine();
                Console.Write("Which day to run (1-12, Q to quit): ");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1": Day01Runner.Run(); break;
                    case "4": Day04Runner.Run(); break;
                    case "5": Day05Runner.Run(); break;
                    case "6": Day06Runner.Run(); break;
                    case "7": Day07Runner.Run(); break;
                    case "8": Day08Runner.Run(); break;
                    case "9": Day09Runner.Run(); break;
                    case "q":
                    case "Q": userWantsToContinue = false; break;
                    default:
                        Console.WriteLine("Sorry, I did not understand that input.");
                        break;
                }
            }
        }

        private static void PrintGoodbye()
        {
            Console.WriteLine("Ending program. Goodbye!");
        }
    }
}
