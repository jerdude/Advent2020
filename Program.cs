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
                        Console.WriteLine("1");
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
