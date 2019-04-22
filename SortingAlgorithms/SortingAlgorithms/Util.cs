using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class Util
    {
        public static int[] SelectSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int smV = int.MaxValue;
                int smI = int.MaxValue;
                int temp = 0;

                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < smV)
                    {
                        smV = arr[j];
                        smI = j;
                    }
                }
                temp = arr[i];
                arr[i] = smV;
                arr[smI] = temp;
            }
            return arr;
        }
    }
}
