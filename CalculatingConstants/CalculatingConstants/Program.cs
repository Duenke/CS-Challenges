using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingConstants
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region CalculatePi
            /*
            Given the formula(Pi = 4/n1 - 4/n2 + 4/n3...), write a method to calculate Pi.

            Logical Approach:
            - Create a loop.
            - Increment n to the next odd number each loop.
            - Accumulate.
            - Stop calculating at some defined point.
            */

            Console.WriteLine("CalculatePi");
            Console.WriteLine("Given the formula(Pi = 4/n1 - 4/n2 + 4/n3...), write a method to calculate Pi.\n");

            int i = 1000000;
            double Pi = 0.0;
            for (double n = 1; n < i;)
            {
                Pi += 4 / n;
                n += 2;
                Pi -= 4 / n;
                n += 2;
            }

            Console.WriteLine($"After [{i}] calculations, Pi = [{Pi}].");

            Console.ReadKey();

            Console.WriteLine("-----------------------------");
            #endregion

            #region CalculateEuler
            /*
            Given the formula(e = 1/n1! + 1/n2! + 1/n3!...), write a method to calculate e.

            Logical Approach:
            - Create a loop.
            - Create another method to CalculateFactorial of n.
            - Increment n each loop.
            - Accumulate.
            - Stop calculating at some defined point.
            */

            Console.WriteLine("CalculateEuler");
            Console.WriteLine("Given the formula(e = 1/n1! + 1/n2! + 1/n3!...), write a method to calculate e.\n");

            i = 15;
            double e = 0;
            for (int n = 1; n < i; n++)
            {
                e += 1.0 / GetFactorial(n);
            }

            Console.WriteLine($"After [{i}] calculations, e = [{e}].");

            Console.ReadKey();

            Console.WriteLine("-----------------------------");
            #endregion

            #region CalculateFibonacci
            /*
            Given the formula(Fn = Fn-1 + Fn-2), write a method to calculate Fib.

            Logical Approach:
            - Create a loop.
            - Increment n each loop.
            - Accumulate.
            - Stop calculating at some defined point.
            */


            Console.WriteLine("CalculateFibonacci");
            Console.WriteLine("Given the formula(Fn = Fn-1 + Fn-2), write a method to calculate Fib.\n");

            i = 10;
            double Fib1 = 1.0;
            double Fib2 = 1.0;
            double Fib3 = 0.0;
            for (int n = 0; n < i; n++)
            {
                Fib3 = (Fib2) + (Fib1);
                if (i - n > 1)
                    Console.Write($"{Fib3}, ");
                else
                    Console.WriteLine(Fib3);
                Fib1 = Fib2;
                Fib2 = Fib3;
            }

            Console.ReadKey();

            Console.WriteLine("-----------------------------");
            #endregion
        }

        public static int GetFactorial(int n)
        {
            int sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            }
            return sum;
        }
    }
}
