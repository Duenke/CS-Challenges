using System.Collections;
using System.Collections.Generic;

namespace OrderCharDesc
{
    public class CharCompare : IComparer
    {
        public int Compare(object x, object y)
        {
            // Convert the parameters to KVPs to access Properties.
            KeyValuePair<char, int> a = (KeyValuePair<char, int>)x;
            KeyValuePair<char, int> b = (KeyValuePair<char, int>)y;
            // Compare the Int Values and Char Keys for sorting.
            if (a.Value < b.Value)
            {
                return 1;
            }
            else if (a.Value > b.Value)
            {
                return -1;
            }
            else if (a.Value == b.Value)
            {
                if (a.Key < b.Key)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}
