using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinqExercises");
            Console.WriteLine();

            Console.WriteLine("\nPrint the even numbers in a list.");
            int[] n1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var query = from num in n1
                        where (num % 2) == 0
                        select num;

            foreach (var v in query)
            {
                Console.Write($"{v} ");
            }

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("\nPrint the positive numbers in a list.");
            int[] n2 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var query2 = from num in n2
                         where (num > 0 && num < 12)
                         select num;

            foreach (var v in query2)
            {
                Console.Write($"{v} ");
            }

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("\nPrint the squares over twenty.");
            int[] n3 = { 3, 9, 2, 8, 6, 5 };

            var query3 = from num in n3
                         where (num * num) > 20
                         select num;

            foreach (int i in query3)
            {
                Console.WriteLine($"Number: {i}, SqrNum: {i * i}");
            }

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("\nPrint the frequency of digits.");
            //int[] n4 = { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            //Dictionary<int, int> qDict = new Dictionary<int, int>();

            //foreach(int i in n4)
            //{
            //    if (qDict.ContainsKey(i))
            //        qDict[i]++;
            //    else
            //        qDict.Add(i, 1);
            //}

            //foreach(KeyValuePair<int,int> kvp in qDict)
            //    Console.WriteLine($"Number {kvp.Key} appears {kvp.Value} times");
            int[] n4 = { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var query4 = from num in n4
                         group num by num;

            foreach (var group in query4)
            {
                Console.WriteLine($"Int [{group.Key}] freq is [{group.Count()}]");
            }

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("\nPrint the frequency of characters.");
            string s5 = "Hello, I am a string. How do you like me?";

            var query5 = from chr in s5
                         group chr by chr;

            foreach (var group in query5)
            {
                Console.WriteLine($"Char [{group.Key}] freq is [{group.Count()}]");
            }

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("\nPrint the days of the week.");
            string[] s6 = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            var query6 = from day in s6
                         select day;

            foreach (var v in query6)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("\nPrint digit, frequency, and product.");
            int[] n7 = { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            var query7 = from num in n7
                         group num by num;
            Console.WriteLine("Int  Freq    Product");
            Console.WriteLine("--------------------");

            foreach (var group in query7)
            {
                Console.WriteLine($"{group.Key}     {group.Count()}         {group.Key * group.Count()}");
            }

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("\nPrint the cities beginning and ending with specified characters.");
            string[] s8 = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            Console.WriteLine("The cities are:");
            foreach (var v in s8)
            {
                Console.Write($"{v}, ");
            }

            Console.Write("Inter starting character for the city: ");
            string start = Console.ReadLine().ToUpper();
            Console.Write("Inter ending character for the city: ");
            string end = Console.ReadLine().ToUpper();

            var query8 = from city in s8
                         where city.StartsWith(start) && city.EndsWith(end)
                         select city;

            Console.Write($"The cities starting with [{start}] and ending with [{end}] are: ");
            int count = query8.Count();
            int and = count;
            foreach (var v in query8)
            {
                Console.Write(v);
                if (count > 2)
                {
                    Console.Write(", ");
                    count--;
                }
                else if (count > 1)
                {
                    Console.Write(", and ");
                    count--;
                }
            }
            Console.WriteLine();

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("\nPrint the top 'n' values of an array.");
            int[] n9 = { 5, 13, 4, 21, 2, 6, 9, 50 };

            Console.Write("Enter the number of values to display, 'n': ");
            int n = int.Parse(Console.ReadLine());
            var query9 = (from num in n9
                         orderby num descending
                         select num).Take(n);


            Console.Write($"\nThe top {n} values are: ");
            foreach(var v in query9)
            {
                Console.Write($"{v} ");
            }

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("\nPrint the UPPERCASE words.");
            string s10 = "my name is JACOB AGUSTIN BARQUET SALAZAR DANGER DUENKE.";

            var query10 = from chr in s10
                          where chr > 64 && chr < 91
                          select chr;

            foreach (var v in query10)
                Console.Write($"{v} ");
            Console.WriteLine();

            string[] s11 = s10.Split(' ');

            var query11 = from word in s11
                          where string.Equals(word, word.ToUpper())
                          select word;

            foreach (var v in query11)
                Console.Write($"{v} ");
            Console.WriteLine();

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("\nPrint the string after deleting the specified character.");
            string s12 = "The credit belongs to the man who is actually in the arena.";

            Console.WriteLine($"Original String:" +
                $"\n{s12}");
            Console.Write("\nEnter one character to remove: ");
            string s = Console.ReadLine();
            char c = s[0];

            var query12 = from chr in s12
                          where chr != c
                          select chr;

            Console.WriteLine("\nUpdated String:");
            foreach(var v in query12)
                Console.Write(v);
            Console.WriteLine();
        }
    }
}
