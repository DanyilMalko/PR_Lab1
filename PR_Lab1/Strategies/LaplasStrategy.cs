using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PR_Lab1.Strategies
{
    class LaplasStrategy : ICalculateBestOption
    {

        public string Name { get; }
        public LaplasStrategy()
        {
            Name = "'Laplas'";
        }
        public int CalculateBestOption(int[,] matrix, out int bestStrategy)
        {
            var calculatedColumn = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                calculatedColumn[i] = (matrix[i,0]+ matrix[i, 1] + matrix[i, 2])/3;
            }

            int result = calculatedColumn.Min();
            bestStrategy = Array.IndexOf(calculatedColumn, result);
            return result;
        }
    }
}
