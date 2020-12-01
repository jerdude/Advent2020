using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Advent2020
{
    class Day1
    {
        private List<int> _inputs;

        public Day1()
        {
            _inputs = File.ReadLines("Inputs\\Day1.txt")
                        .Select(x => int.Parse(x))
                        .ToList();
        }

        public (long solution, long bonus) GetSolution()
        {
            return (GetPart1(),GetPart2());
        }

        private int GetPart1()
        {
            foreach(int i in _inputs)
            {
                foreach(int y in _inputs)
                {
                    if(i + y == 2020)
                    {
                        return(i * y);
                    }
                }
            }

            return 0;
        }

        //Brute forcin' with a O(N^3). Will go back for clever solution later.
        private int GetPart2()
        {
            foreach(int i in _inputs)
            {
                foreach(int y in _inputs)
                {
                    foreach(int z in _inputs)
                    {
                        if(i + y + z == 2020)
                        {
                            return(i * y * z);
                        }
                    }
                }
            }

            return 0;
        }

    }

}