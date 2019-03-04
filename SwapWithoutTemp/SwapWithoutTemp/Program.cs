using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapWithoutTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Given two integer variables, swap their value without using a "temp" variable.

            Constraints:
            - No temp variable.
            - Only using integers.

            In-puts / Out-puts:
            - int a = 3, b = 7 / int a = 7, b = 3
            - int a = -32, b = -18 / int a = -18, b = -32
            - int a = 5, b = 0 / int a = 0, b = 5

            Logical Approach:
            - Take two integers and add them together.
            - Assign sum to int c.
            - Assign one to the other.
            - Assign the other to c minus itself.
            */

            Console.WriteLine("SwapWithoutTemp");
            Console.WriteLine("Given two integer variables, swap their value without using a 'temp' variable.\n");

            int a = -32, b = -18;

            Console.WriteLine($"Integer a is: {a}.\n" +
                $"Integer b is: {b}.\n");

            Console.WriteLine("Do magic.\n");

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Integer a is: {a}.\n" +
                $"Integer b is: {b}.");

            Console.ReadKey();
        }
    }
}
