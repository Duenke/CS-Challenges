using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMode
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Given an integer of any size, sum the numbers of the integer.

            Constraints:
            - IReadOnlyCollection positive integers.

            In-puts / Out-puts:
            - 17 / 8
            - 123 / 6
            - 123456789 / 
            */

            Console.WriteLine("SumNumbersInAnInteger");
            Console.WriteLine("Given an integer of any size, sum the numbers of the integer.\n");

            int n = 123456789;
            int acc = 0;

            Console.WriteLine($"The integer {n} summed is: ");
            while (n > 0)
            {
                acc += n % 10;
                n = n / 10;
            }

            Console.WriteLine(acc);

            Console.WriteLine("-----------------------------");

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

            Console.WriteLine("Do math.\n");

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Integer a is: {a}.\n" +
                $"Integer b is: {b}.");

            Console.ReadKey();
        }
    }
}
