using System;

namespace DartboardPi
{
    public class Util
    {
        private static Random rnd = new Random();

        public static Point[] PopulatePoints(Point[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i].x = rnd.NextDouble();
                points[i].y = rnd.NextDouble();
            }
            return points;
        }

        public static int CheckIfHit(Point[] points)
        {
            int numHit = 0;
            foreach (Point p in points)
            {
                if (Math.Sqrt((p.x * p.x) + (p.y * p.y)) < 1)
                    numHit++;
            }
            return numHit;
        }

        public static double CalcPi(int numDarts, int numHits) => 4 * numHits / (double)numDarts;
    }
}
