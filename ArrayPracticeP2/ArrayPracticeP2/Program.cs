using System;

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

            /*
            Given a "main" string and a "sub" string, check if the "sub" string exists in the "main" string, and print the index at witch it starts.

            Constraints:
            - Both strings will be ALL CAPS.
            - Both strings will contain only alphanumeric characters and will not be null.
            - Must return the index at witch the "sub" string occurs FIRST if it occurs more than once.
            - If the "sub" string does not exist in the "main" string, print.

            In-puts / Out-puts:
            - TACTCAT & CAT / index: 4
            - WHITECAR & CAR / index: 5
            - TACTICAL TIC REMOVER & TIC / index: 3
            - DONKEY & TEA / Does not exist

            Logical Approach:
            - Create two loops to check each character in both strings.
            - If a matching carachter is found, mark the index and keep checking.
            - If false positive, reset variables.
            - If the entire "sub" string is found in once piece, stop checking and print the index.
            */

            Console.WriteLine("SubStringCheck");
            Console.WriteLine("Given a 'main' string and a 'sub' string, check if the 'sub' string exists in the 'main' string, and return the index at witch it starts.\n");

            string main = "TACOCAT";
            string sub = "CAT";
            SubStringCheck(main, sub);

            main = "WHITECAR";
            sub = "CAR";
            SubStringCheck(main, sub);

            main = "TACTICAL TIC REMOVER";
            sub = "TIC";
            SubStringCheck(main, sub);

            main = "DONKEY";
            sub = "TEA";
            SubStringCheck(main, sub);

            Console.ReadKey(); 

            Console.WriteLine("-----------------------------"); 

            /*
            Given 

            Constraints:
            - 

            In-puts / Out-puts:
            - 

            Logical Approach:
            - 
            

            Console.WriteLine(" ");
            Console.WriteLine(" \n");



            Console.ReadKey(); 
            
            Console.WriteLine("-----------------------------"); */
        }
    }
}
