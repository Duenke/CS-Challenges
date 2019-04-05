using System;

namespace ArrayPracticeP1
{
    internal class Program : Util
    {
        private static void Main(string[] args)
        {
            #region CheckPalindrome
            /*
            Given a string, check to see if it is a palindrome. Return true or false.

            Constraints:
            - The string will be ALL UPPERCASE.
            - The string will contain no special characters or spaces.
            - The string will not be NULL.
            
            In-puts / Out-puts:
            - "RACECAR" / True
            - "110011" / True
            - "BALL" / False

            Logical Approach:
            - Check the first and last characters to see if they are the same.
            - Repeat going in to the middle until the string is completely checked.
            - Return true or false.
            */

            Console.WriteLine("CheckPalindrome");
            Console.WriteLine("Given a string, check to see if it is a palindrome.\n");

            string s = "RACECAR";
            string t = "110011";
            string u = "BALL";

            Console.WriteLine($"{s} is a palindrome: {CheckPalindrome(s)}");
            Console.WriteLine($"{t} is a palindrome: {CheckPalindrome(t)}");
            Console.WriteLine($"{u} is a palindrome: {CheckPalindrome(u)}");

            Console.ReadKey();

            Console.WriteLine("-----------------------------");
            #endregion

            #region GetMin
            /*
            Given an integer array, find the smallest integer in the array.

            Constraints:
            - The array will not be empty.
            - The array may not be in any order.
            - The array will not be all 0s.
            
            In-puts / Out-puts:
            - int[] a = new int[] { 99, 2, 4 } / 2
            - int[] b = new int[] { 11, 255, 34, 77, 8 } / 8
            - int[] c = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } / 1

            Logical Approach:
            - Declare a variable for the smallest value called min.
            - Check each element in the array for the values.
            - If the value is smaller than the min variable, assign it to min.
            */

            Console.WriteLine("GetMin");
            Console.WriteLine("Given an integer array, find the smallest integer in the array.\n");

            int[] a = new int[] { 99, 2, 4 };
            int[] b = new int[] { 11, 255, 34, 77, 8 };
            int[] c = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            PrintArray(a);
            Console.WriteLine($"The smallest value in int[] a is: {GetMin(a)}.");
            PrintArray(b);
            Console.WriteLine($"The smallest value in int[] b is: {GetMin(b)}.");
            PrintArray(c);
            Console.WriteLine($"The smallest value in int[] c is: {GetMin(c)}.");

            Console.ReadKey();

            Console.WriteLine("-----------------------------");
            #endregion

            #region GetMax
            /*
            Given an integer array, find the largest integer in the array.

            Constraints:
            - The array will not be empty.
            - The array may not be in any order.
            - The array will not be all 0s.
            
            In-puts / Out-puts:
            - int[] a = new int[] { 99, 2, 4 } / 99
            - int[] b = new int[] { 11, 255, 34, 77, 8 } / 255
            - int[] c = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } / 10

            Logical Approach:
            - Declare a variable for the largest value called max.
            - Check each element in the array for the values.
            - If the value is larger than the max variable, assign it to max.
            */

            Console.WriteLine("GetMax");
            Console.WriteLine("Given an integer array, find the largest integer in the array.\n");

            a = new int[] { 99, 2, 4 };
            b = new int[] { 11, 255, 34, 77, 8 };
            c = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            PrintArray(a);
            Console.WriteLine($"The largest value in int[] a is: {GetMax(a)}.");
            PrintArray(b);
            Console.WriteLine($"The largest value in int[] b is: {GetMax(b)}.");
            PrintArray(c);
            Console.WriteLine($"The largest value in int[] c is: {GetMax(c)}.");

            Console.ReadKey();

            Console.WriteLine("-----------------------------");
            #endregion

            #region PickTeams
            /*
            Given a character array of any size, randomly populate it with half A and half Z characters.

            Constraints:
            - The array must be equal parts A and Z.
            - The array size will be an even number.
            - The array must be populated randomly A or Z.
            
            In-puts / Out-puts:
            - 100 / 50 As and 50 Zs
            - 50 / 25 As and 25 Zs

            Logical Approach:
            - Create a char[].
            - Use loops to populate the array.
            - Use random.next to randomly choose between A and Z.
            - Decrement counters for A and Z each time they are placed to insure equality.
            */

            Console.WriteLine("PickTeams");
            Console.WriteLine("Given a character array of any size, randomly populate it with half A and half Z characters.\n");

            int gameSize = 100;

            char[] players = PickTeams(gameSize);

            Console.WriteLine("The players were picked in this order:");
            PrintArray(players);

            Console.ReadKey();

            Console.WriteLine("-----------------------------");
            #endregion
        }
    }
}
