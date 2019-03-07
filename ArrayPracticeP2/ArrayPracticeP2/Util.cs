using System;

namespace ArrayPracticeP2
{
    class Util
    {
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
                        break;
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
