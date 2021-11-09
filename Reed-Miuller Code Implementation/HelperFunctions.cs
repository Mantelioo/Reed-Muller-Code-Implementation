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

        //Functions that calculations combination C
        public static int Combination(int n, int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }

        //Returns factorial of the number
        public static int Factorial(int number)
        {
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            return fact;
        }

        //This gets the permutations of all the elements in the array or list
        public static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> items, int count)
        {
            int i = 0;
            foreach (var item in items)
            {
                if (count == 1)
                    yield return new T[] { item };
                else
                {
                    foreach (var result in GetPermutations(items.Skip(i + 1), count - 1))
                        yield return new T[] { item }.Concat(result);
                }
                ++i;
            }
        }

        //Helper Function to print Array. Using for testing purposes if needed
        public static string PrintArray(int[] array)
        {
            string a = "";
            foreach (var item in array)
            {
                a += item + " ";
            }
            return a;
        }

        //This function multiplies matrix rows. Using generics
        //start row - from which line start multiplying
        public static void MultiplyMatrixRows<T>(int[,] array, IEnumerable<IEnumerable<T>> result, int startRow)
        {
            foreach (var permutation in result)
            {
                for (int i = 1; i < permutation.Count(); i++)
                {
                    int previous = Convert.ToInt32(permutation.ElementAt(i-1));
                    int next = Convert.ToInt32(permutation.ElementAt(i));

                    for (int column = 0; column < array.GetLength(1); column++)
                    {
                        array[startRow, column] = array[previous, column] * array[next, column];
                    }
                    startRow++;
                }
            }
        }
    }
}