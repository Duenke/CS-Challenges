using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IODataFile
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string fileData = @"C:\Users\jacob\Downloads\imports-85.data";

            string[] lines = File.ReadAllLines(fileData);
            foreach (string line in lines)
                Console.WriteLine(line);
        }
    }
}