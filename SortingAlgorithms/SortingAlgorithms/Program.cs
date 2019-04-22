using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region SelectSort
            /*
            Given an integer array, use the Select Sort method to order the array least to greatest.

            Constraints:
            - The integers will be within range of Int32.
            
            In-puts / Out-puts:
            - { 9, 3, 8, 2, 5, 1, 4, 7, 6, 10 } / { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }

            Logical Approach:
            - Loop through array.
            - Select the smallest integer and it's index.
            - Swap the smallest integer with the first index.
            - Increment the first index to check.
            */

            Console.WriteLine("SelectSort");
            Console.WriteLine("Given an integer array, use the Select Sort method to order the array least to greatest.\n");

            int[] arr = { 9, 3, 8, 2, 5, 1, 4, 7, 6, 10 };

            Console.WriteLine($"Starting with array:");
            PrintCollection(arr);

            arr = Util.SelectSort(arr);

            Console.WriteLine($"Ending with array:");
            PrintCollection(arr);
            #endregion
        }

        private static void PrintCollection<T>(IEnumerable<T> coll)
        {
            foreach (T v in coll)
            {
                Console.Write($"{v} ");
            }
            Console.WriteLine();
        }
    }
}
