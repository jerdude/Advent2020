using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Advent2020
{
    class Day2
    {
        private List<string> _inputs;

        public Day2()
        {
            _inputs = File.ReadLines("Inputs\\Day2.txt")
                        .ToList();
        }

        public (long solution, long bonus) GetSolution()
        {
            return (GetPart1(),GetPart2());
        }

        private int GetPart1()
        {
            int validCount = 0;

            foreach(var input in _inputs)
            {
                var inputChars = input.ToCharArray();

                int lowerBound = 0;
                int upperBound = 0;
                char matchChar = '^';

                string holding = "";

                for(int i = 0; i < inputChars.Length; i++)
                {
                    char c = inputChars[i];

                    if(c == '-')
                    {
                        lowerBound = int.Parse(holding);
                        holding = "";
                    }
                    else if(c == ' ')
                    {
                        upperBound = int.Parse(holding);
                        holding = "";
                    }
                    else if(c == ':')
                    {
                        matchChar = inputChars[i-1];
                        //exit the loop once we've parsed out what we need
                        break;
                    }
                    else
                    {
                        holding = string.Concat(holding.Append(c));
                    }
                }

                int matchCount = inputChars.Where(x => x == matchChar).Count() - 1;

                if(matchCount >= lowerBound && matchCount <= upperBound)
                    validCount = validCount + 1;
                    
            }

            return validCount;
        }

        private int GetPart2()
        {

           int validCount = 0;

            foreach(var input in _inputs)
            {
                var inputChars = input.ToCharArray();

                int lowerBound = 0;
                int upperBound = 0;
                char matchChar = '^';

                string holding = "";

                for(int i = 0; i < inputChars.Length; i++)
                {
                    char c = inputChars[i];

                    if(c == '-')
                    {
                        lowerBound = int.Parse(holding);
                        holding = "";
                    }
                    else if(c == ' ')
                    {
                        upperBound = upperBound == 0 ? int.Parse(holding) : upperBound;
                        holding = "";
                    }
                    else if(c == ':')
                    {
                        matchChar = inputChars[i-1];
                    }
                    else
                    {
                        holding = string.Concat(holding.Append(c));
                    }
                }

                var holdingArray = holding.ToCharArray();

                var position1Valid = holdingArray[lowerBound - 1] == matchChar;
                var position2Vaild = holdingArray[upperBound - 1] == matchChar;

                if(position1Valid ^ position2Vaild)
                    validCount = validCount + 1;

                Console.WriteLine(validCount);
            }

            return validCount;
        }

    }

}