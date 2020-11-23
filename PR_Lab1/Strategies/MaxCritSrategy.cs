using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PR_Lab1.Strategies
{
    class MaxCritSrategy : ICalculateBestOption
    {

        public string Name { get; }
        public MaxCritSrategy()
        {
            Name = "'Maximum criterion'";
        }
        public int CalculateBestOption(int[,] matrix, out int bestStrategy)
        {
            var columnOfMaximums = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                columnOfMaximums[i] = MathHelper.GetMaxElementOfTheRow(matrix, i);
            }

            int result = columnOfMaximums.Max();
            bestStrategy = Array.IndexOf(columnOfMaximums, result);
            return result;
        }
    }
}
