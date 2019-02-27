﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPracticeP1
{
    public class Util
    {
        /// <summary>
        /// Returns the largest integer in an array.
        /// </summary>
        /// <param name="x"></param>
        /// <returns>int</returns>
        public static int GetMax(int[] x)
        {
            Console.WriteLine("Exec: GetMax");
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
            Console.WriteLine("Exec: GetMin");
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
            Console.WriteLine("Exec: CheckPalindrome");
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                if (s[i] != s[j])
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Prints a character array to the console window.
        /// </summary>
        /// <param name="c"></param>
        public static void PrintArray(char[] c)
        {
            Console.WriteLine("Exec: PrintArray");
            foreach (char a in c)
                Console.Write(a);
        }
        /// <summary>
        /// Prints an integer array to the console window.
        /// </summary>
        /// <param name="x"></param>
        public static void PrintArray(int[] x)
        {
            Console.WriteLine("Exec: PrintArray");
            foreach (int a in x)
                Console.Write(a);
        }
        /// <summary>
        /// Prints a string array to the console window.
        /// </summary>
        /// <param name="s"></param>
        public static void PrintArray(string[] s)
        {
            Console.WriteLine("Exec: PrintArray");
            foreach (string a in s)
                Console.Write(a);
        }
    }
}
