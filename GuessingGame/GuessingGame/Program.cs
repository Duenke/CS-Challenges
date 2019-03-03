using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Using the bisection algorithm, write a program that will find any number in a given range within log2N number of guesses.
            The person(or computer) who picks the secret number will respond "too high", "too low", or "correct" after each guess by the player.
            Create both positions of the game. (I did a version with arrays and without for comparrison. Without arrays was much easier.)

            Constraints:
            - The range will be integers.
            - The range will have more than 1 integer.

            In-puts / Out-puts:
            - Range 1 to 1000. / a single integer

            Logical Approach Computer Guessing:
            - Create and populate an array for the initial range.
            - If the guess is too high, create a new array with the range above the guess to the max possible number and recurse.
            - If too low, create a new array with the range from the min possible number to the guess - 1 and recurse.
            - If correct, game is won.

            Logical Approach Human Guessing:
            - Have the computer pick a random number within a given range of integers.
            - Tell the computer my guess.
            - Computer responds with "too high", "too low", or "correct" after each guess.
            */

            Console.WriteLine("GuessingGame");
            Console.WriteLine();

            int numValues = 1000;
            int min = 0;
            int max = numValues + 1;

            Console.WriteLine("Initializing Computer M:SmarterThanYouWithoutArrays....\n");
            Console.WriteLine($"Choose a number between 0 and {numValues}. Do not tell me your number!\n");
            RoboGuess(min, max);

            Console.ReadKey();
            Console.WriteLine();

            int[] possValues = new int[numValues];
            for (int i = 0; i < numValues; i++)
            {
                possValues[i] = i + 1;
            }

            Console.WriteLine("Initializing Computer M:SmarterThanYouWithArrays....\n");
            Console.WriteLine($"Choose a number between 1 and {numValues}. Do not tell me your number!\n");
            RoboGuessWithArrays(possValues);

            Console.WriteLine();

            Random rnd = new Random();
            int answer = rnd.Next(0, numValues);

            Console.WriteLine($"Now it's your turn. I've got my number between 0 and {numValues}...try to guess it.\n");
            HoomanGuess(answer);

            Console.ReadKey();
        }

        private static void RoboGuessWithArrays(int[] arr)
        {
            Console.WriteLine($"I guess: {arr[(arr.Length - 1) / 2]}\n" +
                $"Press 1 if too high.\n" +
                $"Press 2 if too low.\n" +
                $"Press 3 if I'm right.\n");
            int highLow = Int32.Parse(Console.ReadLine());
            switch (highLow)
            {
                case 1:
                    TooHigh(arr);
                    break;
                case 2:
                    TooLow(arr);
                    break;
                case 3:
                    Console.WriteLine("Ha! I knew it all along!");
                    break;
            }
        }

        private static void TooLow(int[] arr)
        {
            if (arr.Length % 2 == 0)
            {
                int len = arr.Length / 2;
                int[] rtrn = new int[len];
                Array.Copy(arr, len, rtrn, 0, len);
                RoboGuessWithArrays(rtrn);
            }
            else
            {
                int len = arr.Length / 2;
                int[] rtrn = new int[len];
                Array.Copy(arr, len + 1, rtrn, 0, len);
                RoboGuessWithArrays(rtrn);
            }
        }

        private static void TooHigh(int[] arr)
        {
            if (arr.Length % 2 == 0)
            {
                int len = (arr.Length - 1) / 2;
                int[] rtrn = new int[len];
                Array.Copy(arr, 0, rtrn, 0, len);
                RoboGuessWithArrays(rtrn);
            }
            else
            {
                int len = arr.Length / 2;
                int[] rtrn = new int[len];
                Array.Copy(arr, 0, rtrn, 0, len);
                RoboGuessWithArrays(rtrn);
            }
        }

        private static void HoomanGuess(int x)
        {
            Console.Write("My guess is: ");
            int guess = Int32.Parse(Console.ReadLine());
            if (guess > x)
            {
                Console.WriteLine("Too high.");
                HoomanGuess(x);
            }
            else if (guess < x)
            {
                Console.WriteLine("Too low.");
                HoomanGuess(x);
            }
            else
                Console.WriteLine("Yea, you guessed it...");
        }

        private static void RoboGuess(int x, int y)
        {
            int min = x;
            int max = y;
            int guess = (min + max) / 2;
            Console.WriteLine($"My guess is: {guess}\n" +
                "Press 1 if too high.\n" +
                "Press 2 if too low.\n" +
                "Press 3 if I'm right.");
            int hL = Int32.Parse(Console.ReadLine());
            switch (hL)
            {
                case 1:
                        max = guess;
                        RoboGuess(min, max);
                        break;
                case 2:
                        min = guess;
                        RoboGuess(min, max);
                        break;
                case 3:
                        Console.WriteLine("Ha! I knew it all along!");
                        break;
            }
        }

        private static void PrintArray(int[] x)
        {
            foreach (int i in x)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}
