using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Advent2020
{
    class Day3
    {
        private List<string> _inputs;

        public Day3()
        {
            _inputs = File.ReadLines("Inputs\\Day3.txt")
                        .ToList();
        }

        public (long solution, long bonus) GetSolution()
        {
            return (GetPart1(),GetPart2());
        }

        private long GetPart1()
        {
            var grid = _inputs.Select(x => x.ToCharArray()).ToArray();

            int x = 0;
            int treeCount = 0;
            foreach(char[] row in grid)
            {
                if(x > row.Length - 1)
                    x = x - (row.Length);

                if(row[x] == '#')
                    treeCount = treeCount + 1;
                
                x = x + 3;
            }

            return treeCount;
        }

        private long GetPart2()
        {
            var grid = _inputs.Select(x => x.ToCharArray()).ToArray();

            return TestSlope(1, 3, grid) *
                    TestSlope(1, 1, grid) *
                    TestSlope(1, 5, grid) *
                    TestSlope(1, 7, grid) *
                    TestSlope(2, 1, grid);
        }

        private long TestSlope(int incry, int incrx, char[][] grid)
        {
            int x = 0;
            int treeCount = 0;

            for(int y = 0; y < grid.Length; y = y + incry)
            {
                var row = grid[y];

                if(x > row.Length - 1)
                    x = x - (row.Length);

                if(row[x] == '#')
                    treeCount = treeCount + 1;
                
                x = x + incrx;
            }

            return treeCount;
        }

    }

}