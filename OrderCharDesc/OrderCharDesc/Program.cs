using System;

namespace OrderCharDesc
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Given a string of characters, order the characters by descending frequency of appearance. Return a string.

            Constraints:
            - Contiguous line of letters.
            - No space characters, numbers, or other characters.
            - All lowercase letters.

            In-puts / Out-puts:
            - abbccccddddde / dddddccccbbae

            Logical Approach:
            - Loop through input string.
            - Assign new characters found to Dictionary key.
            - Increment Dictionary value for repeat characters found.
            - Sort KVPs.
            - Return result string.
             */

            Console.WriteLine("OrderCharDesc");
            Console.WriteLine("Given a string of characters, order the characters by descending frequency of appearance.\n");

            string unSorted = "abbccccddddde";
            string sorted = Util.OrderCharDesc(unSorted);
            Console.WriteLine($"The string [{unSorted}] sorted by descending character frequency is [{sorted}].\n");

            unSorted = "loremipsumdolorsitametconsecteturadipisicingelitin";
            sorted = Util.OrderCharDesc(unSorted);
            Console.WriteLine($"The string [{unSorted}] sorted by descending character frequency is [{sorted}].\n");

            Console.Write("Try a custom string in the same format: ");
            unSorted = Console.ReadLine();
            sorted = Util.OrderCharDesc(unSorted);
            Console.WriteLine($"The string [{unSorted}] sorted by descending character frequency is [{sorted}].\n");

            Console.ReadKey(); 

            Console.WriteLine("-----------------------------");
        }
    }
}
