using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherCode
{
    public class Util
    {
        /// <summary>
        /// Accepts any string and returns a contiguous string of only the alphabetical characters in ALL CAPS.
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        public static string Clean(string plainText)
        {
            plainText = plainText.ToUpper();
            List<char> cleanChars = new List<char>();
            foreach (char c in plainText)
            {
                if (c > 64 && c < 91)
                {
                    cleanChars.Add(c);
                }
            }
            return new string(cleanChars.ToArray());
        }

        /// <summary>
        /// Encodes a string based on a given cipher key.
        /// </summary>
        /// <param name="cleanText"></param>
        /// <param name="cleanKey"></param>
        /// <returns></returns>
        public static string SimpleEnc(string cleanText, string cleanKey)
        {
            List<char> encChars = new List<char>();
            for (int i = 0; i < cleanText.Length; i++)
            {
                int c = cleanText[i];
                int key = cleanKey[i % cleanKey.Length] - 64;
                int encChar = c + key;
                if (encChar > 90)
                    encChars.Add((char)((encChar % 90) + 64));
                else
                    encChars.Add((char)encChar);
            }
            return new string(encChars.ToArray());
        }

        //public static string SingleEnc(string cleanText, string cleanSKey) => throw new NotImplementedException();

        /// <summary>
        /// Encodes a string based on a given cipher key, then the string itself.
        /// </summary>
        /// <param name="cleanText"></param>
        /// <param name="cleanKey"></param>
        /// <returns></returns>
        public static string ContEnc(string cleanText, string cleanKey)
        {
            List<char> encChars = new List<char>();
            for (int i = 0, j = 0; i < cleanText.Length; i++)
            {
                int c = cleanText[i];
                int key = cleanKey[i % cleanKey.Length] - 64;
                int contKey = cleanText[j] - 64;
                int encChar;
                if (i < cleanKey.Length)
                    encChar = c + key;
                else
                {
                    encChar = c + contKey;
                    j++;
                }
                if (encChar > 90)
                    encChars.Add((char)((encChar % 90) + 64));
                else
                    encChars.Add((char)encChar);
            }
            return new string(encChars.ToArray());
        }

        /// <summary>
        /// Decodes a string based on a given cipher key.
        /// </summary>
        /// <param name="encSimple"></param>
        /// <param name="cleanKey"></param>
        /// <returns></returns>
        public static string SimpleDec(string encSimple, string cleanKey)
        {
            List<char> decChars = new List<char>();
            for (int i = 0; i < encSimple.Length; i++)
            {
                int c = encSimple[i];
                int key = cleanKey[i % cleanKey.Length] - 64;
                int decChar = c - key;
                if (decChar < 65)
                    decChars.Add((char)(decChar + 26));
                else
                    decChars.Add((char)decChar);
            }
            return new string(decChars.ToArray());
        }

        //public static string MultiDec(string encMulti, string cleanMKey) => throw new NotImplementedException();

        public static string ContDec(string encCont, string cleanKey)
        {
            List<char> decChars = new List<char>();
            for (int i = 0, j = 0; i < encCont.Length; i++)
            {
                int c = encCont[i];
                int key = cleanKey[i % cleanKey.Length] - 64;
                int decChar;
                if (i < cleanKey.Length)
                    decChar = c - key;
                else
                {
                    decChar = c - (decChars[j] - 64);
                    j++;
                }
                if (decChar < 65)
                    decChars.Add((char)((decChar + 26)));
                else
                    decChars.Add((char)decChar);
            }
            return new string(decChars.ToArray());
        }
    }
}
