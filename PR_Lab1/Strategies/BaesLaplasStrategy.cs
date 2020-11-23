using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PR_Lab1.Strategies
{
    class BaesLaplasStrategy : ICalculateBestOption
    {

        public string Name { get; }
        public BaesLaplasStrategy()
        {
            Name = "'Baesa-Laplasa'";
        }

        public int CalculateBestOption(int[,] matrix, out int bestStrategy)
        {
            if (matrix.GetLength(1) != 3)
            {
                Console.WriteLine("{0} method is not supported for this size of array, due to hardcoded probabilities.", this.Name);
                bestStrategy = 0;
                return 0;
            }

            var probabilities = new double[] { 0.5, 0.35, 0.15 };
            var calculatedColumns = new double[matrix.GetLength(0)];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    calculatedColumns[row] = calculatedColumns[row] +  matrix[row,column]*probabilities[column];
                }              
            }

            int result = (int)calculatedColumns.Max();
            bestStrategy = Array.IndexOf(calculatedColumns, result);
            return result;
        }
    }
}
