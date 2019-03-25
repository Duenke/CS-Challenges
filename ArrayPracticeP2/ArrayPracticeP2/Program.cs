using System;

namespace ArrayPracticeP2
{
    class Program : Util
    {
        static void Main(string[] args)
        {
            #region MinMaxSum
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
            #endregion

            #region SubStringCheck
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
            #endregion

            #region MaxString
            /*
            Given a sentence as a string, return the longest word in the string. Ignore special characters and spaces. If two words are the same length, return the first word.

            Constraints:
            - Strings will not be null.
            - Srtings will not contain numbers.

            In-puts / Out-puts:
            - Hello World / Hello
            - I Love Dogs / Love
            - Fun &!! Time / Time

            Logical Approach:
            - Split the main string into a string[].
            - Assign the first element to MAX variable.
            - Compare length of each element to MAX variable.
            - Keep and return the longest element.
            */

            Console.WriteLine("MaxString");
            Console.WriteLine("Given a sentence as a string, return the longest word in the string. Ignore special characters and spaces. If two words are the same length, return the first word.\n");

            string input = "Hello World";
            string output = MaxString(input);
            Console.WriteLine(output);

            input = "I Love Dogs";
            output = MaxString(input);
            Console.WriteLine(output);

            input = "Fun &!! Time";
            output = MaxString(input);
            Console.WriteLine(output);

            Console.ReadKey(); 
            
            Console.WriteLine("-----------------------------");
            #endregion

            #region VowelCount
            /*
            Given a sentence as a string, counts the number of vowels in the text.

            Constraints:
            - Srting will not be null.

            In-puts / Out-puts:
            - "The quick brown fox jumps over the lazy dog." / 11 vowels
            - "Kindra, Malachi, and Jacob are left on the island." / 15 vowels

            Logical Approach:
            - Create an array holding all possible vowels(not Y).
            - Loop through the sentence as an array, checking each character for a vowel.
            - Increment a vowelCount integer.
            - Return vowelCount.
            */

            Console.WriteLine("VowelCount");
            Console.WriteLine("Given a sentence as a string, counts the number of vowels in the text.\n");

            string sentence = "The quick brown fox jumps over the lazy dog.";
            int vowelCount = VowelCount(sentence);
            Console.WriteLine($"There are ({vowelCount}) vowels in '{sentence}'.");

            sentence = "Kindra, Malachi, and Jacob are left on the island.";
            vowelCount = VowelCount(sentence);
            Console.WriteLine($"There are ({vowelCount}) vowels in '{sentence}'.");

            Console.ReadKey(); 

            Console.WriteLine("-----------------------------");
            #endregion

            #region GradingStudents
            /*
            Given an int[] of student grades, round the grades up to the next multiple of 5 if the original grade is within 2 points. Return a new int[].

            Constraints:
            - Grades range from 0 to 100.
            - Only round up grades that are within 2 points.
            - Leave other grades alone.
            - Don't bother rounding grades that will still result in an F.

            In-puts / Out-puts:
            - int[] { 68, 72, 83, 99 } / int[] { 70, 72, 85, 100 }
            - int[] { 0, 70, 48, 95 } / int[] { 0, 70, 48, 95 }

            Logical Approach:
            - Create our new int[].
            - If grades will fail anyway, assign old value.
            - If grades are not within 2 points of next multiple of 5, assign old value.
            - If grade qualifies to round up, assign new value.
            - Return new int[].
            */

            Console.WriteLine("GradingStudents");
            Console.WriteLine("Given an int[] of student grades, round the grades up to the next multiple of 5 if the original grade is within 2 points.\n");

            int[] oldGrades = new int[] { 68, 72, 83, 99 };
            Console.WriteLine("The old grades are:");
            PrintArray(oldGrades);
            int[] newGrades = GradingStudents(oldGrades);
            Console.WriteLine("The new grades are:");
            PrintArray(newGrades);

            oldGrades = new int[] { 0, 70, 48, 95, 98 };
            Console.WriteLine("The old grades are:");
            PrintArray(oldGrades);
            newGrades = GradingStudents(oldGrades);
            Console.WriteLine("The new grades are:");
            PrintArray(newGrades);


            Console.ReadKey(); 

            Console.WriteLine("-----------------------------");
            #endregion

            #region 
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
            #endregion

        }
    }
}
