using Microsoft.VisualStudio.TestTools.UnitTesting;
using PigLatinTranslator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatinTranslator.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void TransToPigLatinTest_ExpectedResult()
        {
            Form1 form = new Form1();
            string s = "My English goes here"; //caps will be casted to lowercase
            string pLatin = form.TransToPigLatin(s);
            Assert.AreEqual(pLatin, "ymay englishyay oesgay erehay "); 
            //last space is needed due to the nature of the stringbuilder used
        }

        [TestMethod()]
        public void StartsWithVowelTest_ReturnTrue()
        {
            Form1 form = new Form1();
            string s = "easy"; //does indeed start with a vowel
            bool startsWithVowel = form.StartsWithVowel(s);
            Assert.IsTrue(startsWithVowel);
        }

        [TestMethod()]
        public void StartsWithVowelTest_ReturnFalse()
        {
            Form1 form = new Form1();
            string s = "peasy"; //clearly does not start with a vowel
            bool startsWithVowel = form.StartsWithVowel(s);
            Assert.IsFalse(startsWithVowel);
        }

        [TestMethod()]
        public void FindFirstVowelTest_ExpectedResult()
        {
            Form1 form = new Form1();
            string s = "pleased"; //the third letter [index = 2] is the first vowel
            int index = form.FindFirstVowel(s);
            Assert.AreEqual(index, 2);
        }
    }
}