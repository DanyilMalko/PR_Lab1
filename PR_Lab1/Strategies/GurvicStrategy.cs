using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PR_Lab1.Strategies
{
    class GurvicStrategy : ICalculateBestOption
    {

        public string Name { get; }
        public GurvicStrategy()
        {
            Name = "'Gurvic'";
        }
        public int CalculateBestOption(int[,] matrix, out int bestStrategy)
        {
            var columnOfMaximums = new int[matrix.GetLength(0)];
            var columnOfMinimums = new int[matrix.GetLength(0)];
            var calculatedColumn = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                columnOfMaximums[i] = MathHelper.GetMaxElementOfTheRow(matrix, i);
                columnOfMinimums[i] = MathHelper.GetMinElementOfTheRow(matrix, i);
                calculatedColumn[i] = columnOfMaximums[i] / 2 + columnOfMinimums[i] / 2;
            }

            int result = calculatedColumn.Min();
            bestStrategy = Array.IndexOf(calculatedColumn, result);
            return result;
        }
    }
}
