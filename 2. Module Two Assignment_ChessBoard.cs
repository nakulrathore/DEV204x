using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        public static void Main()
        {
            var grid = CreateGrid(8, 'o', 'x');
            PrintGrid(grid);
        }

        private static void PrintGrid(char[,] grid)
        {
            for (var row = 0; row < grid.GetLength(0); row++)
            {
                for (var col = 0; col < grid.GetLength(0); col++)
                {
                    Console.Write(grid[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static char[,] CreateGrid(int gridSize, char light, char dark)
        {
            var grid = new char[gridSize, gridSize];

            for (var row = 0; row < gridSize; row++)
            {
                for (var col = 0; col < gridSize; col++)
                {
                    if (row % 2 == 0)
                    {
                        grid[row, col] = (col % 2 == 0) ? dark : light;
                    }
                    else
                    {
                        grid[row, col] = (col % 2 == 0) ? light : dark;
                    }
                }
            }

            return grid;
            Console.ReadLine();
        }
    }
}