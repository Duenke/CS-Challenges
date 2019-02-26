using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGame
{
    class Util
    {
        public static int GetWinners(string v1, string v2, string v3, string v4, string v5, string bet, int randNum, int money)
        {
            bool flip = false;
            string num = randNum.ToString();
            if (bet == v1)
            {
                flip = true;
                money += 200;
                Console.WriteLine($"You Win a Dozens! You're up to ${money}!");
            }
            if (bet == v2)
            {
                flip = true;
                money += 200;
                Console.WriteLine($"You Win a Columns! You're up to ${money}!");
            }
            if (bet == v3)
            {
                flip = true;
                money += 100;
                Console.WriteLine($"You Win a 'Red' Black! You're up to ${money}!");
            }
            if (bet == v4)
            {
                flip = true;
                money += 100;
                Console.WriteLine($"You Win a 'High' Low! You're up to ${money}!");
            }
            if (bet == v5)
            {
                flip = true;
                money += 100;
                Console.WriteLine($"You Win an 'Even' Odds! You're up to ${money}!");
            }


            string[] arrBet = bet.Split(',', ' ');
            for (int i = 0; i < arrBet.Length; i++)
                if (arrBet[i] == num && arrBet.Length == 1)
                {
                    flip = true;
                    money += 3500;
                    Console.WriteLine($"You Win a Straight! You're up to ${money}!");
                }
                else if (arrBet[i] == num && arrBet.Length == 3)
                {
                    flip = true;
                    money += 1700;
                    Console.WriteLine($"You Win a Split! You're up to ${money}!");
                }
                else if (arrBet[i] == num && arrBet.Length == 5)
                {
                    flip = true;
                    money += 1100;
                    Console.WriteLine($"You Win a Street! You're up to ${money}!");
                }
                else if (arrBet[i] == num && arrBet.Length == 7)
                {
                    flip = true;
                    money += 800;
                    Console.WriteLine($"You Win a Corner! You're up to ${money}!");
                }
                else if (arrBet[i] == num && arrBet.Length == 11)
                {
                    flip = true;
                    money += 500;
                    Console.WriteLine($"You Win a Six Line! You're up to ${money}!");
                }

            if (flip == false)
            {
                money -= 100;
                Console.WriteLine($"You Lose! You're down to ${money}!");
            }
            return money;
        }

        public static string GetEvenOdd(int x, int[] y, char[] z)
        {
            if (y[x] == 0 || y[x] == 37)
                return "Zero! House Wins!";
            else if (y[x] % 2 == 0)
                return "Evens";
            else
                return "Odds";
        }

        public static string GetHighLow(int x, int[] y, char[] z)
        {
            if (y[x] == 0 || y[x] == 37)
                return "Zero! House Wins!";
            else if (y[x] > 18)
                return "High";
            else //if (y[x] < 19 || y[x] == 37)
                return "Low";
        }

        internal static string GetRedBlack(int x, int[] y, char[] z)
        {
            if (z[x] == 'g')
                return "Green! House Wins!";
            else if (z[x] == 'r')
                return "Red";
            else
                return "Black";
        }

        public static string GetColumn(int x, int[] y, char[] z)
        {
            int g = y[x];
            if ((g % 3) == 1)
                return "1st Column";
            else if (g % 3 == 2)
                return "2nd Column";
            else
                return "3rd Column";
        }

        public static string GetDozen(int x, int[] y, char[] z)
        {
            if (y[x] > 0 && y[x] < 13)
                return "1st Dozen";
            else if (y[x] > 12 && y[x] < 25)
                return "2nd Dozen";
            else if (y[x] > 24 && y[x] < 37)
                return "3rd Dozen";
            else
                return "Zero! House Wins!";
        }

        public static string GetSixLine(int x, int[] y, char[] z)
        {
            if (y[x] == 0 || y[x] == 37)
                return "(0, 00, 1, 2, 3)";
            else if (y[x] > 0 && y[x] < 3)
                return "(0, 00, 1, 2, 3)/(1, 2, 3, 4, 5, 6)";
            else if (y[x] > 33 && y[x] < 37)
                return "(31, 32, 33, 34, 35, 36)";
            else if (y[x] > 3 && y[x] < 34 && GetColumn(x, y, z) == "1st Column")
                return $"({y[x] - 3}, {y[x] - 2}, {y[x] - 1}, {y[x]}, {y[x] + 1}, {y[x] + 2})/({y[x]}, {y[x] + 1}, {y[x] + 2}, {y[x] + 3}, {y[x] + 4}, {y[x] + 5})";
            else if (y[x] > 3 && y[x] < 34 && GetColumn(x, y, z) == "2nd Column")
                return $"({y[x] - 4}, {y[x] - 3}, {y[x] - 2}, {y[x] - 1}, {y[x]}, {y[x] + 1})/({y[x] - 1}, {y[x]}, {y[x] + 1}, {y[x] + 2}, {y[x] + 3}, {y[x] + 4})";
            else if (y[x] > 3 && y[x] < 34 && GetColumn(x, y, z) == "3rd Column")
                return $"({y[x] - 5}, {y[x] - 4}, {y[x] - 3}, {y[x] - 2}, {y[x] - 1}, {y[x]})/({y[x] - 2}, {y[x] - 1}, {y[x]}, {y[x] + 1}, {y[x] + 2}, {y[x] + 3})";
            else
                return "";
        }

        public static string GetCorner(int x, int[] y, char[] z)
        {
            if (y[x] == 0)
                return "(0, 1, 2)/(0, 00, 2)";
            else if (y[x] == 37)
                return "(0, 00, 2)/(00, 2, 3)";
            else if (y[x] == 1)
                return "(0, 1, 2)/(1, 2, 4, 5)";
            else if (y[x] == 2)
                return "(0, 1, 2)/(0, 00, 2)/(00, 2, 3)/(1, 2, 4, 5)/(2, 3, 5, 6)";
            else if (y[x] == 3)
                return "(00, 2, 3)/(2, 3, 5, 6)";
            else if (y[x] == 34)
                return $"(31, 32, 34, 35)";
            else if (y[x] == 35)
                return $"(31, 32, 34, 35)/(32, 33, 35, 36)";
            else if (y[x] == 36)
                return $"(32, 33, 35, 36)";
            else if (y[x] > 3 && GetColumn(x, y, z) == "1st Column")
                return $"({y[x] - 3}, {y[x] - 2}, {y[x]}, {y[x] + 1})/({y[x]}, {y[x] + 1}, {y[x] + 3}, {y[x] + 4})";
            else if (y[x] > 3 && GetColumn(x, y, z) == "2nd Column")
                return $"({y[x] - 4}, {y[x] - 3}, {y[x] - 1}, {y[x]})/({y[x] - 3}, {y[x] - 2}, {y[x]}, {y[x] + 1})/({y[x] - 1}, {y[x]}, {y[x] + 2}, {y[x] + 3})/({y[x]}, {y[x] + 1}, {y[x] + 3}, {y[x] + 4})";
            else if (y[x] > 3 && GetColumn(x, y, z) == "3rd Column")
                return $"({y[x] - 4}, {y[x] - 3}, {y[x] - 1}, {y[x]})/({y[x] - 1}, {y[x]}, {y[x] + 2}, {y[x] + 3})";
            else
                return "";
        }

        public static string GetStreet(int x, int[] y, char[] z)
        {
            if (GetColumn(x, y, z) == "Zero! House Wins!")
                return "(0, 00)";
            else if (GetColumn(x, y, z) == "1st Column")
                return $"({y[x]}, {y[x] + 1}, {y[x] + 2})";
            else if (GetColumn(x, y, z) == "2nd Column")
                return $"({y[x] - 1}, {y[x]}, {y[x] + 1})";
            else if (GetColumn(x, y, z) == "3rd Column")
                return $"({y[x] - 2}, {y[x] - 1}, {y[x]})";
            else
                return "";
        }

        public static string GetSplit(int x, int[] y, char[] z)
        {
            if (y[x] == 0)
                return "(0, 00)/(0, 1)/(0, 2)";
            else if (y[x] == 37)
                return "(0, 00)/(00, 2)/(00, 3)";
            else if (y[x] == 1)
                return "(0, 1)/(1, 2)/(1, 4)";
            else if (y[x] == 2)
                return "(0, 2)/(00, 2)/(1, 2)/(2, 3)/(2, 5)";
            else if (y[x] == 3)
                return "(00, 3)/(2, 3)/(3, 6)";
            else if (y[x] == 34)
                return "(31, 34)/(34, 35)";
            else if (y[x] == 35)
                return "(32, 35)/(34, 35)/(35, 36)";
            else if (y[x] == 36)
                return "(33, 36)/(35, 36)";
            else if (y[x] > 3 && GetColumn(x, y, z) == "1st Column")
                return $"({y[x] - 3}, {y[x]})/({y[x]}, {y[x] + 1})/({y[x]}, {y[x] + 3})";
            else if (y[x] > 3 && GetColumn(x, y, z) == "2nd Column")
                return $"({y[x] - 3}, {y[x]})/({y[x] - 1}, {y[x]})/({y[x]}, {y[x] + 1})/({y[x]}, {y[x] + 3})";
            else if (y[x] > 3 && GetColumn(x, y, z) == "3rd Column")
                return $"({y[x] - 3}, {y[x]})/({y[x] - 1}, {y[x]})/({y[x]}, {y[x] + 3})";
            else
                return "";
        }

        public static string GetStraight(int x, int[] y, char[] z)
        {
            return $"({y[x]})";
        }
    }
}
