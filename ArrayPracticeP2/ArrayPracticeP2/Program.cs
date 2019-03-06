using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPracticeP2
{
    class Program : Util
    {
        static void Main(string[] args)
        {
            /*
           Given an integer array, calculate the minimum and maximum sum of all integers in the array except one integer.

           Constraints:
           - The array may be any length under 100 elements.
           - The integers will be positive.

           In-puts / Out-puts:
           - int[] a = new int[] { 1, 2, 3, 4, 5} / min: 10 max: 14
           - int[] b = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10} / min: 45 max: 54

           Logical Approach:
           - Loop through the array adding the integers.
           - Skip one integer per loop. Different index is skipped per loop.
           - Assign lowest and highest sums to variables.
           */

            Console.WriteLine("MinMaxSum");
            Console.WriteLine("Given an integer array, calculate the minimum and maximum sum of all integers in the array except one integer.\n");

            int[] a = new int[] { 1, 2, 3, 4, 5 };
            int[] b = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("The min/max of int[] a is:");
            MinMaxSum(a);
            Console.WriteLine("The min/max of int[] b is:");
            MinMaxSum(b);

            Console.ReadKey();

            Console.WriteLine("-----------------------------");
        }
    }
}
