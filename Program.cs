using System;

namespace Advent2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day's challenge would you like to run?");
            
            string input;
            
            do
            {
                input = Console.ReadLine();

                switch(input)
                {
                    case "1":
                        var day1 = new Day1();
                        var day1Results = day1.GetSolution();
                        Program.PrintSolution(day1Results.solution, day1Results.bonus);
                        break;
                    case "2":
                        var day2 = new Day2();
                        var day2Results = day2.GetSolution();
                        Program.PrintSolution(day2Results.solution, day2Results.bonus);
                        break;
                    case "3":
                        var day3 = new Day3();
                        var day3Results = day3.GetSolution();
                        Program.PrintSolution(day3Results.solution, day3Results.bonus);
                        break;
                    case "q":
                        Console.WriteLine("Later.");
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
            while (input != "q");
        }

        private static void PrintSolution(long solution, long bonus)
        {
            Console.WriteLine("Solution: " + solution);
            Console.WriteLine("Bonus: " + bonus);
        }
    }
}
