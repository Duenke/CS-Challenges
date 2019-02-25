using System;

namespace ConvertStandardToMilitaryTime
{
    class Program
    {
        static void Main(string[] args)
        {            
            /*
            Given a string representing a standard 12hr time format, return a military 24hr format string.
            
            In-puts / Out-puts:
            "7:00 am" / "0700"
            "12:00 am" / "0000"
            "12:00 pm" / "1200"

            Logical Approach:
            - Split given string into three parts; hour, time, and am/pm.
            - Convert hour to integer.
            - If 12:00 am, replace hour with 00.
            - If 1 - 11:00 pm, add 12 to hour.
            - If 1 - 9:00 am, add 0 before hour.
            - If 10:00 am - 12:00 pm, do nothing to hour.
            - Stringbuild new time.
            - Convert SB to string.
            */

            Console.WriteLine("ConvertStandardToMilitaryTime");
            Console.WriteLine();
            Console.WriteLine("Given a string representing a standard 12hr time format, return a military 24hr format string.\n");

            string time12 = "7:00 am";
            string time24 = ConvertTo24(time12);
            Console.WriteLine($"[{time12}] converted to 24hr time format is [{time24}]\n");

            time12 = "12:00 am";
            time24 = ConvertTo24(time12);
            Console.WriteLine($"[{time12}] converted to 24hr time format is [{time24}]\n");

            time12 = "12:00 pm";
            time24 = ConvertTo24(time12);
            Console.WriteLine($"[{time12}] converted to 24hr time format is [{time24}]\n");
            try
            {
                Console.Write("Check a custom time in the same format: ");
                time12 = Console.ReadLine();
                time24 = ConvertTo24(time12);
                Console.WriteLine($"\n[{time12}] converted to 24hr time format is [{time24}]\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        private static string ConvertTo24(string time1)
        {
            string[] time2 = time1.Split(' ', ':');
            int hour = Int32.Parse(time2[0]);
            string mins = time2[1];
            System.Text.StringBuilder time3 = new System.Text.StringBuilder();

            if (time2[2] == "am" && hour == 12)
            {
                hour = 0;
                time3.Append(0);
                time3.Append(hour);
                time3.Append(mins);
            }
            else if (time2[2] == "pm" && hour < 12)
            {
                hour += 12;
                time3.Append(hour);
                time3.Append(mins);
            }
            else if (time2[2] == "am" && hour < 10)
            {
                time3.Append(0);
                time3.Append(hour);
                time3.Append(mins);
            }
            else
            {
                time3.Append(hour);
                time3.Append(mins);
            }
            return time3.ToString();
        }

        public static void PrintArray(string[] s)
        {
            foreach (string i in s)
            {
                Console.Write(i);
            }
        }
    }
}
