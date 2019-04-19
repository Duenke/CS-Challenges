using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFactorials
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Write a recursive method to calculate factorial.");
            int start = 1;
            int acc = 1;
            int end = 10;

            int fac = GetFac(start, acc, end);
            Console.WriteLine($"The factorial of {end} is {fac}.");
        }

        private static int GetFac(int start, int acc, int end)
        {
            Console.WriteLine($"{start}, {acc}, {end}");
            start++;
            acc *= start;
            if (start < end)
            {
                acc = GetFac(start, acc, end);
            }
            return acc;
        }
    }
}
