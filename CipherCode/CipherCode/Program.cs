using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherCode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Creating a simple cypher.");
            Console.Write($"Enter a string as your plain text: ");
            string plainText = Console.ReadLine();
            Console.Write($"Enter a character as your single key: ");
            string singleKey = Console.ReadLine();
            Console.Write($"Enter a string as your multi key: ");
            string multiKey = Console.ReadLine();
            Console.WriteLine();

            string cleanText = Util.Clean(plainText);
            string cleanSKey = Util.Clean(singleKey);
            string cleanMKey = Util.Clean(multiKey);

            string encSingle = Util.SimpleEnc(cleanText, cleanSKey);
            string encMulti = Util.SimpleEnc(cleanText, cleanMKey);
            string encCont = Util.ContEnc(cleanText, cleanMKey);

            Console.WriteLine($"Encrypted message with single key is [{encSingle}].");
            Console.WriteLine($"Encrypted message with multi key is [{encMulti}].");
            Console.WriteLine($"Encrypted message with continuous key is [{encCont}].");
            Console.WriteLine();

            string decSingle = Util.SimpleDec(encSingle, cleanSKey);
            string decMulti = Util.SimpleDec(encMulti, cleanMKey);
            string decCont = Util.ContDec(encCont, cleanMKey);

            Console.WriteLine($"Decrypted message with single key is [{decSingle}].");
            Console.WriteLine($"Decrypted message with multi key is [{decMulti}].");
            Console.WriteLine($"Decrypted message with continuous key is [{decCont}].");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
