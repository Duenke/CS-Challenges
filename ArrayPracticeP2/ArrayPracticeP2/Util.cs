using System;
using System.Collections.Generic;

namespace ArrayPracticeP2
{
    public class Util
    {
        /// <summary>
        /// Rounds grades up in an int[] to the next multiple of 5 if they within 2 points.
        /// </summary>
        /// <param name="grades"></param>
        /// <returns>int[]</returns>
        public static int[] GradingStudents(int[] grades)
        {
            int[] curvedGrades = new int[grades.Length];
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] < 68)
                {
                    curvedGrades[i] = grades[i];
                }
                else if (grades[i] % 5 > 2)
                {
                    int newGrade = grades[i] + (5 - grades[i] % 5);
                    curvedGrades[i] = newGrade;
                }
                else
                {
                    curvedGrades[i] = grades[i];
                }
            }

            return curvedGrades;
        }

        /// <summary>
        /// Counts and returns the number of vowels in a string.
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns>int</returns>
        public static int VowelCount(string sentence)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int vowelCount = 0;
            for (int i = 0; i < sentence.Length; i++)
                for (int j = 0; j < vowels.Length; j++)
                    if (sentence[i] == vowels[j])
                        vowelCount++;

            return vowelCount;
        }

        /// <summary>
        /// Finds and returns the longest word in a sentence.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>string</returns>
        public static string MaxString(string input)
        {
            string[] arr = input.Split(' ', '.', '!', '?', '&');
            string max = arr[0];

            for (int i = 0; i < arr.Length; i++)
                if (max.Length < arr[i].Length)
                    max = arr[i];

            return max;
        }

        /// <summary>
        /// Checks a string "main" for the sub string "sub", and prints the index where "sub" starts in "main".
        /// If "sub" does not exist in "main", prints as such.
        /// </summary>
        /// <param name="main"></param>
        /// <param name="sub"></param>
        public static void SubStringCheck(string main, string sub)
        {
            int index = -1;
            int match = 0;
            bool checking = false;

            for (int i = 0; i < main.Length; i++)
            {
                for (int j = match; j < sub.Length; j++)
                {
                    if (match == sub.Length)
                    {
                        break;
                    }
                    else if (main[i] == sub[j] && checking == false)
                    {
                        checking = true;
                        index = i;
                        match++;
                        break;
                    }
                    else if (main[i] == sub[j] && checking == true)
                    {
                        match++;
                        break;
                    }
                    else
                    {
                        checking = false;
                        match = 0;
                        index = -1;
                        break;
                    }
                }
            }
            if (index > -1)
                Console.WriteLine($"The sub-string ({sub}) begins in the main string ({main}) at index: {index}.");
            else
                Console.WriteLine($"The sub-string ({sub}) does NOT exist in the main string ({main}).");
        }

        /// <summary>
        /// Calculates and prints the smallest and largest sum of an int[] without one of it's elements.
        /// </summary>
        /// <param name="x"></param>
        public static void MinMaxSum(int[] x)
        {
            long sum = 0;
            long lSum = Int64.MaxValue;
            long hSum = 0;
            long skip = 0;

            for (int j = 0; j < x.Length; j++)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if (i == skip)
                        continue;

                    sum += x[i];
                }

                if (hSum < sum)
                    hSum = sum;

                if (lSum > sum)
                    lSum = sum;

                sum = 0;
                skip++;
            }

            Console.WriteLine($"The minimum sum is: {lSum}\n" +
                $"The maximum sum is: {hSum}");
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
