using PR_Lab1.Strategies;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PR_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = GetMatrixFromFile();
            int bestStrategy;
            foreach (var strategy in GenerateStrategies())
            {
                int result = strategy.CalculateBestOption(matrix, out bestStrategy);
                Console.WriteLine("Best option for the {0} strategy is R{1}={2}\n",strategy.Name, bestStrategy+1, result);
                Console.WriteLine("----------------------------------\n");
            }
            
        }

        private static List<ICalculateBestOption> GenerateStrategies()
        {
            return new List<ICalculateBestOption> { 
                new ValdaStrategy(),
                new MaxCritSrategy(),
                new LaplasStrategy(),
                new GurvicStrategy(),
                new BaesLaplasStrategy()
            };
        }

        private static int[,] GetMatrixFromFile()
        {
            var directory = System.IO.Directory.GetCurrentDirectory();
           var allrows =  File
            .ReadLines($"{directory}\\myMatrix.txt")
            .Select(line => line.Split(" ").Select(int.Parse).ToList())
            .ToList();

            var matrix = new int[allrows.Count, allrows[0].Count];
            for (int row = 0; row != allrows.Count; row++)
            {
                for (int col = 0; col != allrows[0].Count; col++)
                {
                    matrix[row, col] = allrows[row][col];
                }
            }

            return matrix;
        }
    }
}
