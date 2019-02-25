using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a console app that simulates an American Roulette game. Spin the wheel and return all the winning bets for the spin.
            
            In-puts / Out-puts:
            Straight: "12" / You Win!
            Split: "12, 15" / You Lose!
            Street: "4, 5, 6" / You Win!
            'Red' Black: "Red" / You Lose!
            Columns: "1st Column" / House Wins!

            Logical Approach:
            - Build an array representing the wheel with 38 slots.
            - Build a results format, calling necessary methods.
            - "Spin the wheel" landing on a random number between 0 - 37.
            - Implement the necessary methods.
            - Implement custom bets and a method to check for winning bets.
            - Implement winning and losing money.
            */

            Console.WriteLine("ConvertStandardToMilitaryTime");
            Console.WriteLine();
            Console.WriteLine("Welcome to Casino Royale!\n" +
                "You have five chances to win. Each bet is $100, and you'll start with $500.\n");

            int[] num = new int[] { 0, 28, 9, 26, 30, 11, 7, 20, 32, 17, 5, 22, 34, 15, 3, 24, 36, 13, 1, 37, 27, 10, 25, 29, 12, 8, 19, 31, 18, 6, 21, 33, 16, 4, 23, 35, 14, 2 };  //wheel of numbers on American wheel
            char[] col = new char[] { 'g', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'g', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b', 'r', 'b' }; //corrisponding colors on the wheel.

            Random rnd = new Random(); //the ball
            int randNum = 0;
            int money = 500;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter your bet here: ");
                string bet = Console.ReadLine();
                randNum = 37;//rnd.Next(0, 37);
                Console.WriteLine("The croupier spins the wheel in one direction, then spins the ball in the opposite direction!\n" +
                    $"The ball lands on: {num[randNum]}!\n");
                Console.WriteLine($"The Straight winner is: {Util.GetStraight(randNum, num, col)}\n" +
                    $"The Split winners are: {Util.GetSplit(randNum, num, col)}\n" +
                    $"The Street winners are: {Util.GetStreet(randNum, num, col)}\n" +
                    $"The Corner winners are: {Util.GetCorner(randNum, num, col)}\n" +
                    $"The Six Line winners are: {Util.GetSixLine(randNum, num, col)}\n" +
                    $"The Dozens winner is: {Util.GetDozen(randNum, num, col)}\n" +
                    $"The Columns winner is: {Util.GetColumn(randNum, num, col)}\n" +
                    $"The 'Red' Black winner is: {Util.GetRedBlack(randNum, num, col)}\n" +
                    $"The 'High' Low winner is: {Util.GetHighLow(randNum, num, col)}\n" +
                    $"The 'Even' Odds winner is: {Util.GetEvenOdd(randNum, num, col)}\n");
                money = Util.GetWinners(Util.GetDozen(randNum, num, col), Util.GetColumn(randNum, num, col), Util.GetRedBlack(randNum, num, col), Util.GetHighLow(randNum, num, col), Util.GetEvenOdd(randNum, num, col), bet, num[randNum], money);
                Console.WriteLine("PRESS ENTER TO SPIN AGAIN\n");
                Console.ReadKey();
            }
        }
    }
}
