using System;
using System.Collections.Generic;

namespace ArrayPracticeP1
{
    public class Util
    {
        /// <summary>
        /// Randomly picks between A and Z to populate a char[], ensuring equal teams.
        /// </summary>
        /// <param name="gameSize"></param>
        /// <returns>char[]</returns>
        public static char[] PickTeams(int gameSize)
        {
            // Console.WriteLine("Exec: PickTeams");
            char[] x = new char[gameSize];
            int alpha = x.Length / 2;
            int zulu = x.Length / 2;
            int checkA = 0;
            int checkZ = 0;
            Random r = new Random();

            for (int i = 0; i < x.Length; i++)
            {
                int m = r.Next() % 2;
                if (m == 0 && alpha > 0)
                {
                    x[i] = 'A';
                    alpha--;
                    checkA++;
                }
                else if (m == 1 && zulu > 0)
                {
                    x[i] = 'Z';
                    zulu--;
                    checkZ++;
                }
                else //Keeps the loop going if one team is full and the random.next doesn't do a good job filling the other team.
                    i--;
            }
            Console.WriteLine($"There are: {checkA} alphas and there are: {checkZ} zulus.");
            return x;
        }

        /// <summary>
        /// Returns the largest integer in an array.
        /// </summary>
        /// <param name="x"></param>
        /// <returns>int</returns>
        public static int GetMax(int[] x)
        {
            // Console.WriteLine("Exec: GetMax");
            int max = x[0];
            for (int i = 0; i < x.Length; i++)
                if (x[i] > max)
                    max = x[i];
            return max;
        }

        /// <summary>
        /// Returns the smallest integer in an array.
        /// </summary>
        /// <param name="x">int[]</param>
        /// <returns>int</returns>
        public static int GetMin(int[] x)
        {
            // Console.WriteLine("Exec: GetMin");
            int min = x[0];
            for (int i = 0; i < x.Length; i++)
                if (x[i] < min)
                    min = x[i];
            return min;
        }

        /// <summary>
        /// Checks a string to see if it is a palindrome(spelled the same forward and backward).
        /// </summary>
        /// <param name="s">string</param>
        /// <returns>bool</returns>
        public static bool CheckPalindrome(string s)
        {
            // Console.WriteLine("Exec: CheckPalindrome");
            for (int i = 0, j = s.Length - 1; i < j; i++, j--) //Checks both sides of a single word at the same time going inward.
            {
                if (s[i] != s[j])
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Prints an array to the console window.
        /// </summary>
        /// <param name="c"></param>
        public static void PrintArray<T>(IEnumerable<T> array)
        {
            // Console.WriteLine("Exec: PrintArray");
            foreach (var v in array)
                Console.Write($"{v} ");
            Console.WriteLine();
        }
    }
}
