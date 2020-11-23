using System;
using System.Collections.Generic;
using System.Text;

namespace PR_Lab1
{
    interface ICalculateBestOption
    {
        public string Name { get;}
        public int CalculateBestOption(int[,] matrix, out int bestStrategy);
    }
}
