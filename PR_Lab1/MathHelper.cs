using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PR_Lab1
{
    static class MathHelper
    {
        public static int GetMaxElementOfTheRow(int[,] matrix, int rowNumber)
        {
            var row = new List<int>();
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                row.Add(matrix[rowNumber, i]);
            }
            return row.Max();
        }

        public static int GetMinElementOfTheRow(int[,] matrix, int rowNumber)
        {
            var row = new List<int>();
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                row.Add(matrix[rowNumber, i]);
            }
            return row.Min();
        }
    }
}
