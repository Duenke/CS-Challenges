using System;
using System.Text;
using System.Windows.Forms;

namespace PigLatinTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Translate(object sender, EventArgs e)
        {
            PigLatinBox.Text = TransToPigLatin(EnglishBox.Text);
        }

        /// <summary>
        /// Translates a string from English to PigLatin.
        /// </summary>
        /// <param name="english"></param>
        /// <returns>string</returns>
        public string TransToPigLatin(string english)
        {
            string[] engArr = english.ToLower().Split(' ');
            string pigLatin = "";
            StringBuilder pigSB = new StringBuilder();

            for (int i = 0; i < engArr.Length; i++) //cycles through each word
            {
                if (StartsWithVowel(engArr[i])) //checks if the word starts with a vowel
                {
                    pigSB.Append(engArr[i]);
                    pigSB.Append("yay "); //too easy
                }
                else
                {
                    int index = FindFirstVowel(engArr[i]); //finds the first vowel INCLUDING y as a vowel
                    char[] temp = engArr[i].ToCharArray();
                    for (int j = index; j < temp.Length; j++)
                        pigSB.Append(temp[j]); //PigLatin words start with the first vowel
                    for (int j = 0; j < index; j++)
                        pigSB.Append(temp[j]); //adds the first part of the English word we broke off
                    pigSB.Append("ay ");
                }
            }
            pigLatin = pigSB.ToString();
            return pigLatin;
        }

        /// <summary>
        /// Checks a string for a proper vowel in the [0] index, and returns true, else false.
        /// </summary>
        /// <param name="word"></param>
        /// <returns>bool</returns>
        public bool StartsWithVowel(string word)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < vowels.Length; i++)
                if (word[0] == vowels[i])
                    return true;

            return false;
        }

        /// <summary>
        /// Finds the first vowel INCLUDING 'Y', and returns the index of that vowel.
        /// </summary>
        /// <param name="word"></param>
        /// <returns>int</returns>
        public int FindFirstVowel(string word)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'y' };
            int index = 0;

            for (int i = 0; i < word.Length; i++)
                for (int j = 0; j < vowels.Length; j++)
                    if (word[i] == vowels[j])
                    {
                        index = i;
                        i = word.Length;
                        break;
                    }
            return index;
        }
    }
}
