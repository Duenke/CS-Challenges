using System;

namespace DartboardPi
{
    internal class Program : Util
    {
        private static void Main(string[] args)
        {
            /*
            Given the Dartboard Method of calculating Pi, write a program that throws random darts on a grid and calculate Pi.

            Constraints:
            - Number of darts will always be a positive integer above 10,000.

            In-puts / Out-puts:
            - Number of darts / ~3.14...

            Logical Approach:
            - Create a data structure with x,y values.
            - Randomly populate the values.
            - Determine how many of the random points are within a circle.
            - Do the math.
            */

            Console.WriteLine("DartboardPi");
            Console.WriteLine("Given the Dartboard Method of calculating Pi, write a program that throws random darts on a grid and calculate Pi.\n");

            Console.Write("Enter the number of darts to throw at your circle on a grid: ");
            int numDarts = int.Parse(Console.ReadLine());

            Point[] points = new Point[numDarts];
            points = PopulatePoints(points);

            int numHits = CheckIfHit(points);
            Console.WriteLine($"[{numHits}] of your darts hit within the circle!");

            double Pi = CalcPi(numDarts, numHits);
            Console.WriteLine($"Using the Dartboard Method, Pi is calculated to be ~[{Pi}]!");

            Console.ReadKey();

            Console.WriteLine("-----------------------------");
        }
    }
}
