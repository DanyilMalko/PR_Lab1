using PR_Lab1.Strategies;
using System;
using System.Collections.Generic;

namespace PR_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {{100,80,30 },
                             {90,90,40},
                             {50,60,70}};
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
    }
}
