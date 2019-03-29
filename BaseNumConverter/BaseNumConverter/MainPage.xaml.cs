using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BaseNumConverter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ConvertNum(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((bool)Dec_2_Bin.IsChecked)
                {
                    // Thows exception if user inputs letters.
                    foreach (int i in oldNum.Text)
                    {
                        if (i > 57)
                        {
                            throw new Exception("Invalid Decimal Input...");
                        }
                    }
                    newNum.Text = Dec2Bin(oldNum.Text);
                }
                else if ((bool)Dec_2_Oct.IsChecked)
                {
                    // Thows exception if user inputs letters.
                    foreach (int i in oldNum.Text)
                    {
                        if (i > 57)
                        {
                            throw new Exception("Invalid Decimal Input...");
                        }
                    }
                    newNum.Text = Dec2Oct(oldNum.Text);
                }
                else if ((bool)Bin_2_Dec.IsChecked)
                {
                    // Thows exception if user inputs an invalid binary.
                    foreach (int i in oldNum.Text)
                    {
                        if (i > 49)
                        {
                            throw new Exception("Invalid Binary Input...");
                        }
                    }
                    newNum.Text = Bin2Dec(oldNum.Text);
                }
                else if ((bool)Bin_2_Oct.IsChecked)
                {
                    // Thows exception if user inputs an invalid binary.
                    foreach (int i in oldNum.Text)
                    {
                        if (i > 49)
                        {
                            throw new Exception("Invalid Binary Input...");
                        }
                    }
                    newNum.Text = Bin2Oct(oldNum.Text);
                }
                else if ((bool)Oct_2_Dec.IsChecked)
                {
                    // Thows exception if user inputs an invalid octal.
                    foreach (int i in oldNum.Text)
                    {
                        if (i > 55)
                        {
                            throw new Exception("Invalid Octal Input...");
                        }
                    }
                    newNum.Text = Oct2Dec(oldNum.Text);
                }
                else if ((bool)Oct_2_Bin.IsChecked)
                {
                    // Thows exception if user inputs an invalid octal.
                    foreach (int i in oldNum.Text)
                    {
                        if (i > 55)
                        {
                            throw new Exception("Invalid Octal Input...");
                        }
                    }
                    newNum.Text = Oct2Bin(oldNum.Text);
                }
                else
                {
                    newNum.Text = "Select A Conversion Method...";
                }
            }
            catch (Exception ex)
            {
                newNum.Text = ex.Message;
            }
        }

        private string Oct2Bin(string text)
        {
            // Variables.
            int oldNum = Int32.Parse(text);
            int lastDigit = 0;
            string newNum = string.Empty;
            StringBuilder newSB = new StringBuilder();
            // Until there are no digits left to convert.
            do
            {
                // Grab the last digit of the octal.
                lastDigit = oldNum % 10;
                // Remove that digit.
                oldNum /= 10;
                // Convert digit into binary(in / out as a string).
                newNum = Dec2Bin(lastDigit.ToString());
                // Insert that binary(string) into the front of the new binary.
                newSB.Insert(0, newNum);
            }
            while (oldNum != 0);

            return newSB.ToString();
        }

        private string Bin2Oct(string text)
        {
            // Long variables required due to length of binary numbers.
            long oldNum = Int64.Parse(text);
            long lastThree = 0;
            string newNum = string.Empty;
            StringBuilder newSB = new StringBuilder();
            // Until there are no digits left to convert.
            do
            {
                // Grab the last three digits of the binary.
                lastThree = oldNum % 1000;
                // Remove those digits.
                oldNum /= 1000;
                // Convert those digits into decimal(in / out as a string).
                newNum = Bin2Dec(lastThree.ToString());
                // Insert that decimal(string) into the front of the new octal.
                newSB.Insert(0, newNum);
            }
            while (oldNum != 0);

            return newSB.ToString();
        }

        private string Bin2Dec(string text)
        {
            // Long variables required due to length of binary numbers.
            long oldNum = Int64.Parse(text);
            long lastDigit = 0;
            long newNum = 0;
            int place = 0;
            // Until there are no digits left to convert.
            do
            {
                // Grab the last digit of the binary.
                lastDigit = oldNum % 10;
                // Remove that digit.
                oldNum /= 10;
                // Convert that digit into decimal and accumulate.
                newNum += lastDigit * (int)Math.Pow(2, place);
                // Increment the power of 2(the "place" of the digit in binary notation).
                place++;
            }
            while (oldNum != 0);

            return newNum.ToString();
        }

        private string Oct2Dec(string text)
        {
            // Variables.
            int oldNum = Int32.Parse(text);
            int lastDigit = 0;
            int newNum = 0;
            int place = 0;
            // Until there are no digits left to convert.
            do
            {
                // Grab the last digit of the octal.
                lastDigit = oldNum % 10;
                // Remove that digit.
                oldNum /= 10;
                // Convert that digit into decimal and accumulate.
                newNum += lastDigit * (int)Math.Pow(8, place);
                // Increment the power of 8(the "place" of the digit in octal notation).
                place++;
            }
            while (oldNum != 0);

            return newNum.ToString();
        }

        private string Dec2Oct(string text)
        {
            // Variables.
            int oldNum = Int32.Parse(text);
            StringBuilder newSB = new StringBuilder();
            // Until there are no digits left to convert.
            do
            {
                // Rules to convert decimal to octal.
                newSB.Insert(0, oldNum % 8);
                oldNum /= 8;
            }
            while (oldNum != 0);

            return newSB.ToString();
        }

        private string Dec2Bin(string text)
        {
            // Variables.
            int oldNum = Int32.Parse(text);
            StringBuilder newSB = new StringBuilder();
            // Until there are no digits left to convert.
            do
            {
                // Rules to convert decimal to binary.
                newSB.Insert(0, oldNum % 2);
                oldNum /= 2;
            }
            while (oldNum != 0);
            // Required to maintain leading '0' structure.
            while (newSB.Length % 3 != 0)
            {
                newSB.Insert(0, 0);
            }
            return newSB.ToString();
        }
    }
}
