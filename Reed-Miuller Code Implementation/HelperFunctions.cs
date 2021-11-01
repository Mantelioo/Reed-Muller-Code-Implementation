using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reed_Miuller_Code_Implementation
{
    class HelperFunctions
    {
        //Helper function that convers the 2D array to string
        public static string Matrix2DToString(int[,] matrix)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    builder.Append(matrix[i, j] + " ");
                }
                builder.Append(Environment.NewLine);
            }
            return builder.ToString();
        }

        public static int Combination(int n, int k)
        {
            return factorial(n) / (factorial(k) * factorial(n-k));
        }

        public static int factorial (int number)
        {
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
