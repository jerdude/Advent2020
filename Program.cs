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
                Console.WriteLine("aboo");
                switch(input)
                {
                    case "1":
                        var day1 = new Day1();
                        var results = day1.GetSolution();
                        Console.WriteLine("Solution: " + results.solution);
                        Console.WriteLine("Bonus:" + results.bonus);
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
            while (input != "q");
        }
    }
}
