using System;
using System.Collections.Generic;
using System.Text;

namespace OrderCharDesc
{
    public class Util
    {
        public static string OrderCharDesc(string unSorted)
        {
            // Assign each character and frequency as a KVP.
            Dictionary<char, int> charDict = new Dictionary<char, int>();
            foreach (char c in unSorted)
            {
                if (charDict.ContainsKey(c))
                {
                    charDict[c]++;
                }
                else
                {
                    charDict.Add(c, 1);
                }
            }
            // Migrate the KVPs to an Array for manipulation.
            int i = 0;
            object[] objArr = new object[charDict.Count];
            foreach (KeyValuePair<char, int> kvp in charDict)
            {
                objArr[i++] = kvp;
            }
            // Sort the KVPs by descending frequency.
            CharCompare monsterTruck = new CharCompare();
            Array.Sort(objArr, monsterTruck);
            // Migrate the KVPs to a one dimensional StringBuilder.
            StringBuilder charSB = new StringBuilder();
            foreach(KeyValuePair<char, int> kvp in objArr)
            {
                int repeat = kvp.Value;
                while (repeat > 0)
                {
                    charSB.Append(kvp.Key);
                    repeat--;
                }
            }
            // Finally, convert the StringBuilder to a regular String for return.
            string sorted = charSB.ToString();
            return sorted;
        }
    }
}
