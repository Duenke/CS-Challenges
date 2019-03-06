using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPracticeP2
{
    class Util
    {
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
                skip++;
                if (hSum < sum)
                    hSum = sum;
                if (lSum > sum)
                    lSum = sum;
                sum = 0;
            }

            Console.WriteLine($"The minimum sum is: {lSum}\n" +
                $"The maximum sum is: {hSum}");
        }
    }
}
